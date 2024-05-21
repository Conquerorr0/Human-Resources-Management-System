using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Resource_Managment_System
{

    // Kullanıcı adı label -> lblUserName
    // Şifre label -> lblPassword
    // Kullanıcı adı textbox -> txtUserName
    // Şifre textbox -> txtPassword (Şifre textbox'ına gizleme ve gösterme özelliği eklenebilir.
    // Giriş yap butonu -> btnEnter

    public partial class windowSıgnIn : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_MAXIMIZE = 3;
        public windowSıgnIn()
        {
            InitializeComponent();
            this.Load += new EventHandler(FullScreenExample_Load);
        }

        private void FullScreenExample_Load(object sender, EventArgs e)
        {
            // Formun boyutunu tam ekran yapmak için
            this.WindowState = FormWindowState.Maximized;

            // Tarayıcıyı tam ekran yapmak için
            IntPtr hWnd = this.Handle;
            ShowWindow(hWnd, SW_MAXIMIZE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Giris Yapildi!");
            
        }

        private void windowSıgnIn_Load(object sender, EventArgs e)
        {   
            Form2 form2 = new Form2();
            form2.ShowDialog();

          
           
        }
    }
}
