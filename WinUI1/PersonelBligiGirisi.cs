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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI1
{
    public partial class PersonelBligiGirisi : Form
    {
        public PersonelBligiGirisi()
        {
            InitializeComponent();
            connectionCheck_Load();
        }
        IFirebaseConfig config = new FirebaseConfig()
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

        private void PersonelBligiGirisi_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool evliMi = false;
            if (cobEvliMi.Text == "evet")
            {
                evliMi = true;
            }
            if (string.IsNullOrEmpty(cobEvliMi.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtMaas.Text)
                || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtDepartman.Text) || string.IsNullOrEmpty(txtTelefonNo.Text) || string.IsNullOrEmpty(txtTelefonNo.Text)
                || string.IsNullOrEmpty(txtYas.Text) || string.IsNullOrEmpty(txtCocukSayisi.Text) || string.IsNullOrEmpty(cobCinsiyet.Text) || string.IsNullOrEmpty(cobEvliMi.Text) || string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Lütfen bütün bilgileri giriniz!!");
            }
            else
            {
                string randomId = Guid.NewGuid().ToString();//random şd yaratır 

                AppUsersEmployee person1 = new AppUsersEmployee()
                {
                    tc = txtTC.Text,
                    id = randomId,
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    age = Convert.ToDouble(txtYas.Text),
                    department = txtDepartman.Text,
                    email = txtMail.Text,
                    phone = txtTelefonNo.Text,
                    Address = txtAdres.Text,
                    ChildrenNumber = txtCocukSayisi.Text,
                    wage = Convert.ToDouble(txtMaas.Text),
                    married = evliMi,
                    gender = cobCinsiyet.Text,
                };
                FirebaseResponse response = client.Set("Person/" + randomId, person1);

                var register = new register
                {
                    username = textBoxUsername.Text,
                    password = textBoxPassword.Text,
                    id = randomId,
                    isUser = false,
                    isPerson = true,
                };
                FirebaseResponse prs = client.Set("Users/" + randomId, register);
                MessageBox.Show(textBoxUsername.Text + " Ekleníldi ");
            }
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtYas.Text = "";
            txtDepartman.Text = "";
            txtMail.Text = "";
            txtTelefonNo.Text = "";
            txtAdres.Text = "";
            txtCocukSayisi.Text = "";
            cobCinsiyet.Text = "";
            cobEvliMi.Text = "";
            txtMaas.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Text = "";
        }
    
    }
}
