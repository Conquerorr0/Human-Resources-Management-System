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

namespace WinUI1
{

    public partial class Form1 : Form
    {
        private bool isHide;
        string password;
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtRegisterPassword.PasswordChar = '*';
            isHide = true;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMessage.Text = "LinkLabel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Button";
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            

            if (isHide)
            {
                txtPassword.PasswordChar = '\0'; // Show text
                txtRegisterPassword.PasswordChar = '\0'; // Show text
                btnShowHide.Image = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\HRMS\\Human-Resources-Management-System\\WinUI1\\Icon\\show.png");
                btnShowHide1.Image = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\HRMS\\Human-Resources-Management-System\\WinUI1\\Icon\\show.png");
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Mask text with *
                txtRegisterPassword.PasswordChar = '*';
                btnShowHide.Image = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\HRMS\\Human-Resources-Management-System\\WinUI1\\Icon\\hide.png");
                btnShowHide1.Image = Image.FromFile("C:\\Users\\User\\Desktop\\Klasörler\\HRMS\\Human-Resources-Management-System\\WinUI1\\Icon\\hide.png");

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
    }
}
