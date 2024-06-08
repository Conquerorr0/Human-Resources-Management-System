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
        }
        IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "6Z0KM9sVW6mj8zOqeOLgS1FtJy9jRamR81JUEYKc",
            BasePath = "https://humanresourcemanagmentsy-588b9-default-rtdb.europe-west1.firebasedatabase.app/",
        };

        IFirebaseClient client;

        private void PersonelBligiGirisi_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch
            {
                MessageBox.Show("Veri tabanı baglantısı sorunlu ");
            }
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
                || string.IsNullOrEmpty(txtYas.Text) || string.IsNullOrEmpty(txtCocukSayisi.Text) || string.IsNullOrEmpty(cobCinsiyet.Text) || string.IsNullOrEmpty(cobEvliMi.Text))
            {
                MessageBox.Show("Lütfen bütün bilgileri giriniz!!");
            }
            else
            {
                string randomId = Guid.NewGuid().ToString();//random şd yaratır 

                AppUsersEmployee person1 = new AppUsersEmployee()
                {   
                    tc=txtTC.Text,
                    id=randomId,
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





        }
    
    }
}
