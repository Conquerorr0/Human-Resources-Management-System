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

        private void Form1_Load(object sender, EventArgs e)
        {

                string randomId = Guid.NewGuid().ToString();//random şd yaratır 

                AppUsersEmployee person1 = new AppUsersEmployee()
                {
                    tc = "11111111111",
                    id = randomId,
                    FirstName = "Ali ",
                    LastName = "Demir",
                    age = 24,
                    department = "Pazarlam",
                    email ="aliDemir@gmail.com",
                    phone = "05555555555",
                    Address = "Ankara",
                    ChildrenNumber = "0",
                    wage =50000,
                    married =false,
                    gender = "Erkek",



                };
                FirebaseResponse response = client.Set("Person/" + randomId, person1);

            string randomId2 = Guid.NewGuid().ToString();//random şd yaratır 

            AppUsersEmployee person2 = new AppUsersEmployee()
            {
                tc = "54326578213",
                id = randomId,
                FirstName = "Mahir",
                LastName = "Kara",
                age = 26,
                department = "Muhasebe",
                email = "MahirKara@gmail.com",
                phone = "05555215421",
                Address = "Ankara",
                ChildrenNumber = "0",
                wage = 55000,
                married = false,
                gender = "Erkek",



            };
          response = client.Set("Person/" + randomId2, person2);

            string randomId3 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person3 = new AppUsersEmployee()
            {
                tc = "54326578283",
                id = randomId,
                FirstName = "Deniz",
                LastName = "Üçdere",
                age = 22,
                department = "Bilgi Teknolojileri (IT)",
                email = "deniz@gmail.com",
                phone = "05555215441",
                Address = "İzmir",
                ChildrenNumber = "0",
                wage = 55000,
                married = false,
                gender = "Erkek",



            };
            response = client.Set("Person/" + randomId3, person3);
            string randomId4 = Guid.NewGuid().ToString();//random şd yaratır 

            AppUsersEmployee person4 = new AppUsersEmployee()
            {
                tc = "54356578213",
                id = randomId,
                FirstName = "Boran",
                LastName = "Üçdere",
                age = 25,
                department = "Satış",
                email = "boran@gmail.com",
                phone = "05595215421",
                Address = "Kahramanmaraş",
                ChildrenNumber = "0",
                wage = 60000,
                married = false,
                gender = "Erkek",



            };
            response = client.Set("Person/" + randomId4, person4);

            string randomId5 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person5 = new AppUsersEmployee()
            {
                tc = "54326572313",
                id = randomId,
                FirstName = "Hasan",
                LastName = "Kara",
                age = 45,
                department = "Muhasebe",
                email = "hasanKara@gmail.com",
                phone = "05577215421",
                Address = "Ankara",
                ChildrenNumber = "2",
                wage = 55000,
                married = true,
                gender = "Erkek",



            };
            response = client.Set("Person/" + randomId5, person5);

            string randomId6 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person6 = new AppUsersEmployee()
            {
                tc = "54326572313",
                id = randomId,
                FirstName = "Hüseyin",
                LastName = "Üçdere",
                age = 30,
                department = "Muhasebe",
                email = "ucderehuseyin@gmail.com",
                phone = "05577216621",
                Address = "Gaziantep",
                ChildrenNumber = "1",
                wage = 55000,
                married = true,
                gender = "Erkek",



            };
            response = client.Set("Person/" + randomId6, person6);

            string randomId7 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person7 = new AppUsersEmployee()
            {
                tc = "54036572313",
                id = randomId,
                FirstName = "Mehmet",
                LastName = "Karadere",
                age = 33,
                department = "Satış",
                email = "karadereM@gmail.com",
                phone = "05577246021",
                Address = "Ankara",
                ChildrenNumber = "3",
                wage = 60000,
                married = true,
                gender = "Erkek",



            };
            response = client.Set("Person/" + randomId7, person7  );

            string randomId8 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person8= new AppUsersEmployee()
            {
                tc = "54036951313",
                id = randomId,
                FirstName = "Cem",
                LastName = "Deniz",
                age = 24,
                department = "Bilgi Teknolojileri",
                email = "cemDeniz@gmail.com",
                phone = "05577247821",
                Address = "Ankara",
                ChildrenNumber = "0",
                wage = 60000,
                married = false,
                gender = "Erkek",



            };
            response = client.Set("Person/" + randomId8, person8);


            string randomId9 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person9 = new AppUsersEmployee()
            {
                tc = "52366572313",
                id = randomId,
                FirstName = "Ecem",
                LastName = "Karadere",
                age = 35,
                department = "Satış",
                email = "karadereEcem@gmail.com",
                phone = "05557146021",
                Address = "istanbul",
                ChildrenNumber = "0",
                wage = 60000,
                married = true,
                gender = "Kadın",



            };
            response = client.Set("Person/" + randomId9, person9);

            string randomId10 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person10 = new AppUsersEmployee()
            {
                tc = "52366572313",
                id = randomId,
                FirstName = "Nergiz",
                LastName = "Karadere",
                age = 25,
                department = "Satış",
                email = "karadereNergiz@gmail.com",
                phone = "05557143321",
                Address = "istanbul",
                ChildrenNumber = "0",
                wage = 60000,
                married = true,
                gender = "Kadın",



            };
            response = client.Set("Person/" + randomId10, person10);

            string randomId11 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person11 = new AppUsersEmployee()
            {
                tc = "528966572313",
                id = randomId,
                FirstName = "Deran",
                LastName = "Tüm",
                age = 22,
                department = "Muhasebe",
                email = "deranTum@gmail.com",
                phone = "05559646021",
                Address = "istanbul",
                ChildrenNumber = "0",
                wage = 60000,
                married = true,
                gender = "Kadın",



            };
            response = client.Set("Person/" + randomId11, person11);

            string randomId12 = Guid.NewGuid().ToString();//random şd yaratır 
            AppUsersEmployee person12 = new AppUsersEmployee()
            {
                tc = "52366572313",
                id = randomId,
                FirstName = "Azra",
                LastName = "Sucu",
                age = 35,
                department = "Bilgi teknolojileri (IK)",
                email = "azraSucu@gmail.com",
                phone = "05596146021",
                Address = "istanbul",
                ChildrenNumber = "0",
                wage = 60000,
                married = true,
                gender = "Kadın",



            };

            response = client.Set("Person/" + randomId12, person12);
           
        }
    }
}
