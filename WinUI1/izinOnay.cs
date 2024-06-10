using Entities.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI1
{
    public partial class izinOnay : Form
    {
        public izinOnay()
        {
            InitializeComponent();
            connectionCheck_Load();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "6Z0KM9sVW6mj8zOqeOLgS1FtJy9jRamR81JUEYKc",
            BasePath = "https://humanresourcemanagmentsy-588b9-default-rtdb.europe-west1.firebasedatabase.app/",
        };
        IFirebaseClient client;

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

        private void btnGoster_Click(object sender, EventArgs e)
        {
            

            if (client == null)
            {
                MessageBox.Show("Firebase bağlantısı kurulamadı.");
                return;
            }

            try
            {
                // wantPermission veritabanından verileri al
                FirebaseResponse responsePermissions = client.Get("wantPermission/");
                Dictionary<string, permission> wantPermissionList = responsePermissions.ResultAs<Dictionary<string, permission>>();

                // Tüm AppUsersEmployee verilerini al
                FirebaseResponse responseEmployees = client.Get("Person/");
                Dictionary<string, AppUsersEmployee> employeesList = responseEmployees.ResultAs<Dictionary<string, AppUsersEmployee>>();

                // Eşleşen TC numaralarını takip etmek için HashSet kullan
                HashSet<string> matchedTCs = new HashSet<string>();

                // TC numaraları eşleşen kullanıcıları filtrele ve izin tarihlerini dahil et
                var filteredEmployees = (from emp in employeesList.Values
                                         join perm in wantPermissionList.Values on emp.tc equals perm.TC
                                         where matchedTCs.Add(emp.tc) // Aynı TC numarasını ikinci kez eklemeyi engelle
                                         select new
                                         {
                                             emp.tc,
                                             emp.FirstName,
                                             emp.LastName,
                                             emp.department,
                                             perm.startDateTime,
                                             perm.endDateTime
                                         }).ToList();

                // DataGridView'e veri kaynağını bağla
                dataGridView1.DataSource = filteredEmployees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }



        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string tc = selectedRow.Cells["tc"].Value.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string department = selectedRow.Cells["department"].Value.ToString(); 
                DateTime startDateTime = (DateTime)selectedRow.Cells["startDateTime"].Value;
                DateTime endDateTime = (DateTime)selectedRow.Cells["endDateTime"].Value;

                // Onay mesajını oluştur
                string message = $"Merhaba {firstName} {lastName},\n\n" +
                                 $"{startDateTime.ToShortDateString()} - {endDateTime.ToShortDateString()} tarihleri arasında izin talebiniz onaylanmıştır.\n\n" +
                                 $"Departman: {department} ,\n\n+" ;

                // E-posta adresini Firebase'den çek
                string email = GetEmailByTC(tc);
                if (!string.IsNullOrEmpty(email))
                {
                    // Onay mesajını gönder
                    SendEmail(email, message);
                }
                else
                {
                    MessageBox.Show("E-posta adresi bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }
        private string GetEmailByTC(string tc)
        {
            try
            {
              
                FirebaseResponse response = client.Get("Person/");
                Dictionary<string, AppUsersEmployee> employeesList = response.ResultAs<Dictionary<string, AppUsersEmployee>>();
               
                var employee = employeesList.Values.FirstOrDefault(emp => emp.tc == tc);
                MessageBox.Show(employee?.email);
                return employee?.email; // Email alanının adı veritabanınızdaki alan adıyla uyuşmalıdır
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
                return null;
            }
           
        }


        private void SendEmail(string email, string message)
        {
            //// E-posta göndermek için gerekli bilgiler
            //string subject = "İzin Onayı";

            //MailMessage mail = new MailMessage("altuntasfatih0@outlook.com", email);
            //mail.Subject = subject;
            //mail.Body = message;

            //SmtpClient client = new SmtpClient("smtp.example.com", 587); // SMTP sunucusu ve port
            //client.Credentials = new NetworkCredential("altuntasfatih0@outlook.com", "Fatih1103");
            //client.EnableSsl = true;

            //try
            //{
            //    client.Send(mail);
            //    MessageBox.Show("E-posta başarıyla gönderildi.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"E-posta gönderilirken hata oluştu: {ex.Message}");
            //}
            //MailMessage mailMessage = new MailMessage();    
            //SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Credentials = new System.Net.NetworkCredential("projedeneme0@hotmail.com", "deneme123");
            //smtpClient.Port = 587;
            //smtpClient.Host = "smtp.live.com";
            //smtpClient.EnableSsl = true;
            //mailMessage.To.Add(email);
            //mailMessage.From = new MailAddress("projedeneme0@hotmail.com");
            try
            {
                string subject = "İzin Onayı";

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("projedeneme0@hotmail.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = subject;
                mailMessage.Body = message;

                SmtpClient smtpClient = new SmtpClient("smtp.live.com", 587);
                smtpClient.Credentials = new NetworkCredential("projedeneme0@hotmail.com", "deneme123");
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
                MessageBox.Show("E-posta başarıyla gönderildi.");
            }
            catch (SmtpException smtpEx)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"SMTP Hatası: {smtpEx.Message}");
                sb.AppendLine($"StatusCode: {smtpEx.StatusCode}");

                if (smtpEx.InnerException != null)
                {
                    sb.AppendLine($"Inner Exception: {smtpEx.InnerException.Message}");
                }

                MessageBox.Show("mail gönderildi ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta gönderilirken hata oluştu: {ex.Message}");
            }

        }

    }
}                          
