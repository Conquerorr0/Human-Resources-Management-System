using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Models;
using Google.Protobuf.Compiler;
using Newtonsoft.Json;

namespace WinUI1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Firebase URL'inizi buraya yazın (veritabanı referansı yoluyla)
                    string firebaseUrl = "https://your-firebase-url.firebaseio.com/people.json";

                    // Firebase'den veriyi çek
                    HttpResponseMessage response = await client.GetAsync(firebaseUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // JSON verisini deseri hale getir
                    Dictionary<string, AppUsersEmployee> people = JsonConvert.DeserializeObject<Dictionary<string, AppUsersEmployee>>(responseBody);

                    // Verileri DataGridView'e ekle
                    dataGridView1.DataSource = new BindingList<AppUsersEmployee>(new List<AppUsersEmployee>(people.Values));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnLessWage_Click(object sender, EventArgs e)
        {

        }

        private void btnMoreWage_Click(object sender, EventArgs e)
        {

        }
    }
}
