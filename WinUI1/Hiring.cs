using BLL;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinUI1
{
    public partial class Hiring : Form
    {
        private readonly EmployeeService _employeeService;

        public Hiring()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            LoadData();
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

            // DataGridView sütunlarını temizle
            dataGridView1.Columns.Clear();

            // DataGridView'e veriyi atama
            dataGridView1.DataSource = filteredEmployees;
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            ageCount.Value = 18; // Clear the NumericUpDown control
            cbEnglishLevel.SelectedIndex = -1; // Clear the ComboBox selection

            LoadData(); // Load sample data
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
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

        private void LoadData()
        {
            // DataGridView sütunlarını oluştur
            dataGridView1.Columns.Clear(); // Mevcut sütunları temizle

            // İsim Soyisim sütunu
            var nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "İsim Soyisim";
            nameColumn.DataPropertyName = "FirstName";
            dataGridView1.Columns.Add(nameColumn);

            // Telefon Numarası sütunu
            var phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.HeaderText = "Telefon Numarası";
            phoneColumn.DataPropertyName = "phone";
            dataGridView1.Columns.Add(phoneColumn);

            // Email sütunu
            var emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.DataPropertyName = "email";
            dataGridView1.Columns.Add(emailColumn);

            // Yaş sütunu
            var ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.HeaderText = "Yaş";
            ageColumn.DataPropertyName = "age";
            dataGridView1.Columns.Add(ageColumn);

            // Yabancı Dil Seviyesi sütunu
            var languageLevelColumn = new DataGridViewTextBoxColumn();
            languageLevelColumn.HeaderText = "Yabancı Dil Seviyesi";
            languageLevelColumn.DataPropertyName = "languageLevel";
            dataGridView1.Columns.Add(languageLevelColumn);

            // Örnek veri oluşturma
            List<AppUsersEmployee> sampleData = new List<AppUsersEmployee>
            {
                new AppUsersEmployee { FirstName = "John", phone = "123456789", email = "john@example.com", age = 30, languageLevel = "C1" },
                new AppUsersEmployee { FirstName = "Jane", phone = "987654321", email = "jane@example.com", age = 25, languageLevel = "C2" },
                new AppUsersEmployee { FirstName = "Alice", phone = "456123789", email = "alice@example.com", age = 35, languageLevel = "C1" },
                new AppUsersEmployee { FirstName = "Bob", phone = "987321654", email = "bob@example.com", age = 40, languageLevel = "B1" },
                new AppUsersEmployee { FirstName = "Eve", phone = "654789321", email = "eve@example.com", age = 28, languageLevel = "B2" }
            };

            // Örnek verileri DisplayEmployee tipine dönüştürme
            List<DisplayEmployee> displayData = sampleData.Select(employee => new DisplayEmployee
            {
                FirstName = employee.FirstName,
                phone = employee.phone,
                email = employee.email,
                age = employee.age,
                languageLevel = employee.languageLevel
            }).ToList();

            // DataGridView'e veriyi atama
            dataGridView1.DataSource = displayData;
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            PanelInfo.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın verilerine erişme
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // DataGridView'de kullanılan veri sınıfından oluşturduğunuz alt sınıf türüne dönüştürme
                DisplayEmployee selectedEmployee = (DisplayEmployee)selectedRow.DataBoundItem;

                // Seçilen satırdaki verilere erişme
                string firstName = selectedEmployee.FirstName;
                string phone = selectedEmployee.phone;
                string email = selectedEmployee.email;
                double age = selectedEmployee.age;
                string languageLevel = selectedEmployee.languageLevel;

                showOnPanel($"{firstName}-{phone}-{email}-{age}-{languageLevel}");
                //MessageBox.Show($"İsim: {firstName}\nTelefon: {phone}\nEmail: {email}\nYaş: {age}\nYabancı Dil Seviyesi: {languageLevel}");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void showOnPanel(String info)
        {
            string[] infos = info.Split('-');
            lblPersonName.Text = infos[0];
            lblPhoneNumber.Text = infos[1];
            lblMail.Text = infos[2];
            lblAge.Text = infos[3];
            lblLanguage.Text = infos[4];
        }
    }

   

    public class DisplayEmployee
    {
        public string FirstName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public double age { get; set; }
        public string languageLevel { get; set; }
    }

}
