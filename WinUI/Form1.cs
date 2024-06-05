using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
<<<<<<< HEAD
    public partial class Form1 : Form
    {
=======
   
    public partial class Form1 : Form
    {
        private bool showPassword = false;
>>>>>>> ff41e3278c9c9f71e90c307ddcdc613b5a4cff3b
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            Image iconImage;
            if (showPassword)
            {
                txtHMPassword.PasswordChar = '\0';
                iconImage = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\Human-Resources-Management-System\\WinUI\\Icon\\show.png");
            } else
            {
                txtHMPassword.PasswordChar = '*';
                iconImage = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\Human-Resources-Management-System\\WinUI\\Icon\\hide.png");
            }

            btnHMShowHide.Image = iconImage;

            btnHMShowHide.ImageAlign = ContentAlignment.MiddleCenter;
            btnHMShowHide.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        private void btnShowHide1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            Image iconImage;
            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
                iconImage = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\Human-Resources-Management-System\\WinUI\\Icon\\show.png");
            }
            else
            {
                txtPassword.PasswordChar = '*';
                iconImage = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\Human-Resources-Management-System\\WinUI\\Icon\\hide.png");
            }

            btnHMShowHide.Image = iconImage;

            btnHMShowHide.ImageAlign = ContentAlignment.MiddleCenter;
            btnHMShowHide.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Veri tabanı bağlantısı sonrası kullanıcı adı ve şifre kontrolü ile giriş yapılacak
        }

        private void btnHMEnter_Click(object sender, EventArgs e)
        {
            //Veri tabanı bağlantısı sonrası kullanıcı adı ve şifre kontrolü ile giriş yapılacak
        }
>>>>>>> ff41e3278c9c9f71e90c307ddcdc613b5a4cff3b
    }
}
