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

            // Filtrelenmiş çalışanların alınması
            var filteredEmployees = _employeeService.GetFilteredEmployees(criteria);

            // DataGridView'e veriyi atama
            dataGridView1.DataSource = filteredEmployees;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ageCount.Value = 18; // NumericUpDown kontrolünü sıfırla
            cbEnglishLevel.SelectedIndex = -1; // ComboBox seçimini temizle
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
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
    }
}
