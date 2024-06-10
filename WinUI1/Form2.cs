using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Entities.Models;
using System.Data;

namespace WinUI1
{
    public partial class Form2 : Form
    {
        private IFirebaseClient _firebaseClient;

        public Form2()
        {
            InitializeComponent();

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

        private async void LoadDataFromFirebase()
        {
            FirebaseResponse response = await _firebaseClient.GetAsync("Person");
            if (response.Body != "null") // Firebase'den veri geldi mi kontrolü
            {
                Dictionary<string, AppUsersEmployee> data = response.ResultAs<Dictionary<string, AppUsersEmployee>>();

                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Ad");
                table.Columns.Add("Soyad");
                table.Columns.Add("Yaş");
                table.Columns.Add("Departman");
                table.Columns.Add("Maaş");
                table.Columns.Add("E-posta");
                table.Columns.Add("Telefon");
                table.Columns.Add("Adres");
                table.Columns.Add("Evli");

                foreach (var employee in data.Values)
                {
                    table.Rows.Add(employee.id, employee.FirstName, employee.LastName, employee.age, employee.department, employee.wage, employee.email, employee.phone, employee.Address, employee.married);
                }

                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Firebase'den veri alınamadı!");
            }
        }

        private bool connectionCheck()
        {
            // İnternet bağlantısını kontrol etme kodu
            return true; // Gerçek kontrol mekanizmasını buraya ekleyin
        }

        private void FilterData(string department, string address, bool isMarried, double wage)
        {
            // Filtreleme işlemleri
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataView dataView = dataTable.DefaultView;
            List<string> filters = new List<string>();

            // Departman filtresi
            if (!string.IsNullOrEmpty(department))
                filters.Add($"Departman = '{department}'");

            // Adres filtresi
            if (!string.IsNullOrEmpty(address))
                filters.Add($"Adres = '{address}'");

            // Evli mi filtresi
            if (isMarried)
                filters.Add("Evli = 'true'");

            // Maaş filtresi
            if (wage > 0)
                filters.Add($"Maaş >= {wage}");

            // Filtreleme koşullarını birleştir
            dataView.RowFilter = string.Join(" AND ", filters);

            dataGridView1.DataSource = dataView.ToTable();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string department = cmDepartmants.SelectedItem?.ToString();
            string address = cbAddress.SelectedItem?.ToString();
            bool isMarried = cbMarried.Checked;
            double wage = (double)numericUpDown1.Value;

            FilterData(department, address, isMarried, wage);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells["ID"].Value != null)
                {
                    string id = row.Cells["ID"].Value.ToString();
                    FirebaseResponse response = await _firebaseClient.DeleteAsync($"Person/{id}");

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show($"Silme işlemi başarısız oldu: {id}");
                    }
                }
            }
        }
    }
}
