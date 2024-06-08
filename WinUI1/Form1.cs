using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using Entities.Models;


namespace WinUI1
{

    public partial class Form1 : Form
    {
        private bool isHide;
        string password;

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
        
        public static string usernamepass;
        



        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtRegisterPassword.PasswordChar = '*';
            isHide = true;
            connectionCheck_Load();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMessage.Text = "LinkLabel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //login
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurunuz!");
                }
                else
                {
                    connectionCheck_Load(); // internet baglantisi kontrolu
                FirebaseResponse response = client.Get("Users/");
                        Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();
                        foreach (var get in result)
                        {
                            string userresul = get.Value.username;
                            string passresult = get.Value.password;
                            if (txtUsername.Text == userresul)
                            {
                                if (txtPassword.Text == passresult)
                                {
                            if (get.Value.isUser==false)
                            {
                                MessageBox.Show("Hoşgeldin " + txtUsername.Text + " hesabınizin onaylanılması bekleniliyor!");
                            }else
                            {
                                    usernamepass = txtUsername.Text;
                                    Home form = new Home();
                                    form.Show();
                                    this.Hide();
                                    MessageBox.Show("Hoşgeldin " + txtUsername.Text);
                            }
                        }
                            }
                        }
                        Console.WriteLine("Giris Yapildi!");
                    }
            //lblMessage.Text = "Button";  //bunun ne ise yaradigini anlamadim diye kaldirdim
            
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (isHide)
            {
                txtPassword.PasswordChar = '\0'; // Show text
                txtRegisterPassword.PasswordChar = '\0'; // Show text
                btnShowHide.Image = imageList1.Images["show.png"]; // "show" resmini kullan
                btnShowHide1.Image = imageList1.Images["show.png"]; // "show" resmini kullan
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Mask text with *
                txtRegisterPassword.PasswordChar = '*';
                btnShowHide.Image = imageList1.Images["hide.png"]; // "hide" resmini kullan
                btnShowHide1.Image = imageList1.Images["hide.png"]; // "hide" resmini kullan
            }
            isHide = !isHide;
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show(); this.Hide();
        }

        //kayit
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //login
            if (string.IsNullOrEmpty(txtRegisterUsername.Text) || string.IsNullOrEmpty(txtRegisterPassword.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz!");
            }
            else
            {
                connectionCheck_Load(); // internet baglantisi kontrolu
                string randomId = Guid.NewGuid().ToString(); //random id yaratiyoruz
                var register = new register
                {
                    username = txtRegisterUsername.Text,
                    password = txtRegisterPassword.Text,
                    id = randomId,
                    isUser = false
                };

                FirebaseResponse response = client.Set("Users/" + randomId, register);

                register res = response.ResultAs<register>();
                MessageBox.Show("Kayit başarılı. Hesabınızın onaylanılması bekleniliyor!");

                randomId = String.Empty;
                txtRegisterUsername.Text = String.Empty;
                txtRegisterPassword.Text=String.Empty;

            }
        }
    }
}
