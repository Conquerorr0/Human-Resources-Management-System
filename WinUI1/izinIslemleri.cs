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
using Entities.Models;

namespace WinUI1
{
    public partial class izinIslemleri : Form
    {
        public izinIslemleri()
        {
            InitializeComponent();
            connectionCheck_Load();
        }
        // firebase baglantilarimiz
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (kontrol(txtTc.Text) == false)
            {
                MessageBox.Show("bu tc'ye sahip bir kişi bulunamdı");
                return;
            }
            // FirebaseClient'in null olup olmadığını kontrol edin
            if (client == null)
            {
                //MessageBox.Show("Firebase bağlantısı kurulamadı.");
                return;
            }
            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("TC numarasını eksik veya fazla girdiniz");
                return;
            }
            var per = new permission
            {
                TC = txtTc.Text,
                startDateTime = startDateTime.Value,
                endDateTime = endDateTime.Value,
            };
            if (string.IsNullOrEmpty(txtTc.Text))
            {
                MessageBox.Show("Lütfen TC'yi giriniz.");
                return;
            }else
            {
                if (txtTc.Text.Length > 11 || txtTc.Text.Length < 11)
                {
                    MessageBox.Show("tc numarasını eksik veya fazal giridiniz");
                }
                else
                {
                      try
            {
                FirebaseResponse response = client.Set("wantPermission/" + txtTc.Text, per);
                MessageBox.Show("izininiz gönderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri kaydedilirken bir hata oluştu: " + ex.Message);
            }
                }
            }
           

           

           

          
        }
       public bool  kontrol(string tc)
        {
            bool esitMi=false;
            // FirebaseClient'in null olup olmadığını kontrol edin
            if (client == null)
            {
                MessageBox.Show("Firebase bağlantısı kurulamadı.");
                
            }

            FirebaseResponse response = client.Get("Person/");
            Dictionary<string, permission> result = response.ResultAs<Dictionary<string,permission>>();
            foreach (var get in result)
            {
                string tc0 = get.Value.TC;
                if(tc0.Equals(tc))
                { 
                    esitMi = true; 
                    break;
                }
            }
            
            return esitMi;

        }
    }
}
