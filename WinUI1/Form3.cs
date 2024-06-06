
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Entities.Models;
using RestSharp.Extensions;
using System.IO;
using Firebase.Storage;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace WinUI1
{
    public partial class Form3 : Form
    {
        // firebase baglantilarimiz
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "6Z0KM9sVW6mj8zOqeOLgS1FtJy9jRamR81JUEYKc",
            BasePath = "https://humanresourcemanagmentsy-588b9-default-rtdb.europe-west1.firebasedatabase.app/",
        };
        IFirebaseClient client;
        private FirestoreDb firestoreDb;
        string downloadUrl="";

        private void InitializeFirestore()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"firebase-adminsdk.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoreDb = FirestoreDb.Create("6Z0KM9sVW6mj8zOqeOLgS1FtJy9jRamR81JUEYKc");
        }

        //interente bagli olup olmadiigmizin kontrolu
        static bool connectionCheck()
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
        private void connectionCheck_Load()
        {
            //internete bagli mi degil mi
            if (connectionCheck() == false)
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz!");
                this.Close();
            }
            else
            {
                //firebase islemleri
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Bağlantı Kurulamadı!");
                }
            }
        }

        public static string usernamepass;

        private async Task<string> UploadFileToFirebaseStorage(string filePath, string fileName)
        {
            var stream = File.Open(filePath, FileMode.Open);
            var task = new FirebaseStorage(
                "humanresourcemanagmentsy-588b9.appspot.com"
            ).Child("pdfs").Child(fileName).PutAsync(stream);

            string downloadUrl = await task;
            return downloadUrl;
        }


        public Form3()
        {
            InitializeComponent();
            connectionCheck_Load();
            InitializeFirestore();
        }

        // basvuru gonderme
        private void btnSend_Click(object sender, EventArgs e)
        {
            connectionCheck_Load(); // internet baglantisi kontrolu

            //login
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMessage.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(ageCount.Value.ToString()) || string.IsNullOrEmpty(comboBoxEnnglishLevel.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz!");
            }
            else
            {
                string randomId = Guid.NewGuid().ToString(); //random id yaratiyoruz
                var recourse = new recourse
                {
                    username = txtUsername.Text,
                    email = txtEmail.Text,
                    message = txtMessage.Text,
                    phoneNumber = txtPhoneNumber.Text,
                    id = randomId,
                    age = ageCount.Value.ToString(),
                    englishLevel = comboBoxEnnglishLevel.Text,
                    cvUrl = downloadUrl,
                };


                FirebaseResponse response = client.Set("Recourse/" + randomId, recourse);

                register res = response.ResultAs<register>();
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                MessageBox.Show("Başvuru Kaydı başarılı");

                randomId = String.Empty;
                txtUsername.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtMessage.Text = String.Empty;
                txtPhoneNumber.Text = String.Empty;
            }
        }

        private async void buttonCv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    // Upload the file to Firebase Storage
                    downloadUrl = await UploadFileToFirebaseStorage(filePath, fileName);
                    MessageBox.Show("PDF yüklenildi");
                }
            }
        }
    }
}
