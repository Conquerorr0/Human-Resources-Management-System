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
    public partial class PersonalHome : Form
    {
        public PersonalHome()
        {
            InitializeComponent();
            InitializeMainScreen();
        }

        private void PersonalHome_Load(object sender, EventArgs e)
        {

        }

        private void InitializeMainScreen()
        {
            // Pencere ayarları
            this.Text = "Personel Ana Sayfa";
            this.Size = new System.Drawing.Size(800, 600);
            this.BackColor = Color.LightSteelBlue;

            // Panel
            Panel panel = new Panel()
            {
                Size = new Size(760, 540),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point((this.ClientSize.Width - 760) / 2, (this.ClientSize.Height - 540) / 2)
            };
            this.Controls.Add(panel);

            // Butonların yaratıcı yerleşimi ve tasarımı
            int buttonWidth = 300;
            int buttonHeight = 50;
            int spacing = 20;
            Color buttonColor = Color.LightGray;
            int startX = (panel.Width - buttonWidth) / 2; // Butonları ortalamak için X konumu
            int startY = 20; // İlk butonun Y konumu

            Button btnLeaveManagement = CreateButton("İzin İsteme", new Point(startX, startY + (buttonHeight + spacing) * 4), buttonWidth, buttonHeight, buttonColor);
            btnLeaveManagement.Click += (sender, e) => OpenForm(new izinIslemleri());

            Button btnEmployeeSatisfaction = CreateButton("Çalışan Memnuniyeti Anketi", new Point(startX, startY + (buttonHeight + spacing) * 3), buttonWidth, buttonHeight, buttonColor);
            btnEmployeeSatisfaction.Click += (sender, e) => OpenForm(new Anket());

            // Çıkış Yap butonu
            int logoutButtonWidth = 100;
            Button btnLogout = CreateButton("Çıkış Yap", new Point(panel.Width - logoutButtonWidth - 20, panel.Height - buttonHeight - 20), logoutButtonWidth, buttonHeight, Color.Red);
            btnLogout.Click += (sender, e) => OpenForm(new Form1());
            btnLogout.Font = new Font("Arial", 8, FontStyle.Regular);

            // Butonları panele ekleme
            panel.Controls.Add(btnEmployeeSatisfaction);
            panel.Controls.Add(btnLeaveManagement);
            panel.Controls.Add(btnLogout);
        }

        private Button CreateButton(string text, Point location, int width, int height, Color backColor)
        {
            return new Button()
            {
                Text = text,
                Location = location,
                Size = new Size(width, height),
                BackColor = backColor,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Regular),
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private void OpenForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosed += (sender, e) => { this.Show(); }; // Ana formu tekrar göstermek için
            this.Hide();
            form.Show();
        }
    }
}
