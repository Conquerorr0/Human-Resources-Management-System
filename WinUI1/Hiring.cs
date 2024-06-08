using BLL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using Entities;
using Entities.Models;
using System.ComponentModel;

namespace WinUI1
{
    public partial class Hiring : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly IFirebaseClient _firebaseClient;

        public Hiring()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();

            // Firebase bağlantısı için gerekli ayarları yapın
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "6Z0KM9sVW6mj8zOqeOLgS1FtJy9jRamR81JUEYKc",
                BasePath = "https://humanresourcemanagmentsy-588b9-default-rtdb.europe-west1.firebasedatabase.app/"
            };

            _firebaseClient = new FireSharp.FirebaseClient(config);
            if (_firebaseClient == null)
            {
                MessageBox.Show("Bağlantı Kurulamadı!");
                Application.Exit();
            }

            // İnternet bağlantısını kontrol et
            if (!connectionCheck())
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz!");
                Application.Exit();
            }
            // Firebase'den verileri yükle
            LoadDataFromFirebase();

            LoadInterviewDataFromFirebase();
        }

        // İnternet bağlantısını kontrol et
        private static bool connectionCheck()
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send("www.google.com", 1000).Status == System.Net.NetworkInformation.IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async void LoadDataFromFirebase()
        {
            try
            {
                FirebaseResponse response = await _firebaseClient.GetAsync("Recourse");

                if (response.Body != "null")
                {
                    // Firebase'den çekilen JSON verisini uygun formata dönüştürme
                    Dictionary<string, recourse> firebaseData = JsonConvert.DeserializeObject<Dictionary<string, recourse>>(response.Body);

                    // DataGridView'e veriyi atama
                    var recourseList = firebaseData.Values.Select(r => new recourse
                    {
                        age = r.age,
                        cvUrl = r.cvUrl,
                        email = r.email,
                        englishLevel = r.englishLevel,
                        id = r.id,
                        message = r.message,
                        phoneNumber = r.phoneNumber,
                        username = r.username
                    }).ToList();

                    // DataGridView'in DataSource özelliğini bu listeye bağlama
                    dataGridView1.DataSource = recourseList;

                }
                else
                {
                    MessageBox.Show("Veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu:  {ex.Message}");
            }
        }

        private async void LoadInterviewDataFromFirebase()
        {
            try
            {
                FirebaseResponse response = await _firebaseClient.GetAsync("Interview");

                if (response.Body != "null")
                {
                    // Firebase'den çekilen JSON verisini uygun formata dönüştürme
                    Dictionary<string, Interview> firebaseData = JsonConvert.DeserializeObject<Dictionary<string, Interview>>(response.Body);

                    // DataGridView2'ye veriyi atama
                    var interviewList = new BindingList<Interview>(firebaseData.Values.ToList());

                    // DataGridView2'nin DataSource özelliğini bu listeye bağlama
                    dataGridView2.DataSource = interviewList;

                    // Kolonların başlıklarını düzenleme (isteğe bağlı)
                    dataGridView2.Columns["name"].HeaderText = "Name";
                    dataGridView2.Columns["date"].HeaderText = "Date";
                    dataGridView2.Columns["departmant"].HeaderText = "Departmant";
                    dataGridView2.Columns["status"].HeaderText = "Status";
                }
                else
                {
                    MessageBox.Show("Veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Kriterlerin oluşturulması
            var criteria = new FilterCriteria();

            // Yaş filtresi
            if (int.TryParse(ageCount.Text, out var age))
            {
                criteria.Age = age;
            }

            // Dil seviyesi filtresi
            if (!string.IsNullOrEmpty(cbEnglishLevel.Text))
            {
                criteria.LanguageLevel = cbEnglishLevel.Text;
            }

            // İsim filtresi
            string nameSearch = txtNameSearch.Text.Trim();

            // Firebase'den gelen verileri filtrele
            var firebaseData = dataGridView1.DataSource as List<recourse>;
            var filteredData = firebaseData.Where(r =>
                (criteria.Age == null || r.age == criteria.Age) &&
                (string.IsNullOrEmpty(criteria.LanguageLevel) || r.englishLevel == criteria.LanguageLevel) &&
                (string.IsNullOrEmpty(nameSearch) || r.username.ToLower().Contains(nameSearch.ToLower()))
            ).ToList();

            // Filtrelenmiş verileri DataGridView'e atama
            dataGridView1.DataSource = filteredData;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ageCount.Value = 18; // NumericUpDown kontrolünü sıfırla
            cbEnglishLevel.SelectedIndex = -1; // ComboBox seçimini temizle
            txtNameSearch.Text = ""; // İsim arama textbox'ını temizle

            // Verileri yeniden Firebase'den yükle
            LoadDataFromFirebase();
        }



        private void cv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Buraya tıklandığında yapılacak işlemleri ekleyin
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Filtreleme butonu işlemleri
            if (btnFilter.Text == "Filtrele")
            {
                FilterButton_Click(sender, e);
                btnFilter.Text = "Reset";
            }
            else
            {
                ResetButton_Click(sender, e);
                btnFilter.Text = "Filtrele";
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string username = row.Cells["username"].Value.ToString();
                string phoneNumber = row.Cells["phoneNumber"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string age = row.Cells["age"].Value.ToString();
                string englishLevel = row.Cells["englishLevel"].Value.ToString();
                string cvlink = row.Cells["cvUrl"].Value.ToString();
                string message = row.Cells["message"].Value.ToString();

                lblPersonName.Text = username;
                lblPhoneNumber.Text = phoneNumber;
                lblMail.Text = email;
                lblAge.Text = age;
                lblLanguage.Text = englishLevel;
                cv.Text = cvlink;
                lblMessage.Text = message;
            }
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            PanelInfo.Visible = true;
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // dataGridView1'den seçili kişinin bilgilerini al
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string username = selectedRow.Cells["username"].Value.ToString();

                    // Yeni Interview nesnesi oluştur
                    var interview = new Interview
                    {
                        name = username,
                        date = "", // Tarih eklemiyoruz
                        departmant = "", // Departman eklemiyoruz
                        status = "Beklemede"
                    };

                    // Yeni Interview nesnesini Firebase'e ekle
                    FirebaseResponse response = await _firebaseClient.PushAsync("Interview", interview);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Veri başarıyla eklendi, yeni verinin Firebase'den dönen Key değerini alarak nesneye ata
                        dynamic result = response.ResultAs<dynamic>();
                        interview.id = result.name;

                        MessageBox.Show("Kişi başarıyla mülakata eklendi.");

                        // dataGridView2'nin veri kaynağını BindingList<Interview> olarak alın
                        var dataSource = dataGridView2.DataSource as BindingList<Interview>;
                        if (dataSource != null)
                        {
                            // Yeni Interview nesnesini listeye ekleyin
                            dataSource.Add(interview);
                        }
                        else
                        {
                            // Eğer DataSource null ise yeni bir BindingList oluştur ve ona ekle
                            dataSource = new BindingList<Interview> { interview };
                            dataGridView2.DataSource = dataSource;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kişi eklenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kişi eklenirken bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen mülakata eklemek istediğiniz kişiyi seçin.");
            }
        }



        private async void btnReject_Click(object sender, EventArgs e)
        {
            // Kişinin mülakat için uygun olmadığını belirleyin ve Firebase'den silin
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string employeeId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString(); // Örnek bir alan adı
                FirebaseResponse response = await _firebaseClient.DeleteAsync("Recourse/" + employeeId);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Kişi başarıyla silindi.");
                    LoadDataFromFirebase(); // Verileri yeniden yükle
                }
                else
                {
                    MessageBox.Show("Kişi silinirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Info.Visible = true;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string name = row.Cells["name"].Value.ToString();
                string departmant = row.Cells["departmant"].Value.ToString();
                string date = row.Cells["date"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();

                lblCandidateName.Text = name;
                lblDepartmant.Text = departmant;
                lblDate.Text = date;
                lblStatus.Text = status;

                txtDeleteInterview.Text = name;
                lblInterviewTime.Text = date;
                txtName.Text = name;
            }
        }

        private async void btnAddInterview_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan verileri al
                string name = txtName.Text;
                string department = cbDepartmant.SelectedItem.ToString();
                string date = calendar.SelectionStart.ToString("dd.MM.yyyy");
                string status = "Beklemede";

                // Yeni Interview nesnesi oluştur
                var newInterview = new Interview
                {
                    name = name,
                    date = date,
                    departmant = department,
                    status = status
                };

                // DataGridView2'de aynı isme sahip bir kayıt olup olmadığını kontrol et
                var dataSource = dataGridView2.DataSource as BindingList<Interview>;
                var existingInterview = dataSource?.FirstOrDefault(i => i.name == name);

                if (existingInterview != null)
                {
                    // Mevcut kaydı Firebase'den sil
                    FirebaseResponse deleteResponse = await _firebaseClient.DeleteAsync($"Interview/{existingInterview.id}");
                    if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Mevcut kaydı listeden de sil
                        dataSource.Remove(existingInterview);
                    }
                    else
                    {
                        MessageBox.Show("Eski veri silinirken bir hata oluştu.");
                        return;
                    }
                }

                // Yeni veriyi Firebase'e ekle
                FirebaseResponse response = await _firebaseClient.PushAsync("Interview", newInterview);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Veri başarıyla eklendi, yeni verinin Firebase'den dönen Key değerini alarak nesneye ata
                    dynamic result = response.ResultAs<dynamic>();
                    newInterview.id = result.name;

                    MessageBox.Show("Veri başarıyla eklendi.");

                    if (dataSource != null)
                    {
                        dataSource.Add(newInterview);
                    }
                    else
                    {
                        // Eğer DataSource null ise yeni bir BindingList oluştur ve ona ekle
                        dataSource = new BindingList<Interview> { newInterview };
                        dataGridView2.DataSource = dataSource;
                    }
                }
                else
                {
                    MessageBox.Show("Veri eklenirken bir hata oluştu.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri eklenirken bir hata oluştu: {ex.Message}");
            }
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = dataGridView2.SelectedRows[0].Index;
                    string interviewId = dataGridView2.Rows[selectedIndex].Cells["id"].Value?.ToString();

                    if (string.IsNullOrEmpty(interviewId))
                    {
                        MessageBox.Show("Silme işlemi için geçerli bir veri bulunamadı.");
                        return;
                    }

                    // Firebase'den ilgili veriyi sil
                    FirebaseResponse response =  _firebaseClient.Delete("Interview/" + interviewId);
                    MessageBox.Show(interviewId);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // DataGridView'e bağlı olan BindingList'ten ilgili öğeyi kaldırın
                        BindingList<Interview> dataSource = (BindingList<Interview>)dataGridView2.DataSource;
                        dataSource.RemoveAt(selectedIndex);

                        MessageBox.Show("Veri başarıyla silindi.");
                    }
                    else
                    {
                        // Firebase'den silme işlemi başarısız olursa, hata mesajı göster
                        MessageBox.Show($"Veri silinirken bir hata oluştu. Hata: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veri silinirken bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir satırı seçin.");
            }
        }


    }
}
