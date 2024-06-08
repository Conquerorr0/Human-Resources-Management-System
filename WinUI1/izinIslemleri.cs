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

            string randomId = Guid.NewGuid().ToString(); //random id yaratiyoruz
            
            //mdelde buraya özle brir yapı kur ve caçr zin için
            var res = new register
            {
                username = txtRegisterUsername.Text,
                password = txtRegisterPassword.Text,
                id = randomId,
                isUser = false
            };

            FirebaseResponse firebaseResponse = client.Set("employessOnLeave/" +randomId, res);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
