using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinUI1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            InitializeMainScreen();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void InitializeMainScreen()
        {
            // Pencere ayarları
            this.Text = "Ana Sayfa";
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

            Button btnPersonnelInfo = CreateButton("Personel Bilgileri", new Point(startX, startY), buttonWidth, buttonHeight, buttonColor);
            btnPersonnelInfo.Click += (sender, e) => OpenForm(new Form2());

            Button btnJobApplication = CreateButton("İş Başvuru Formu", new Point(startX, startY + (buttonHeight + spacing) * 1), buttonWidth, buttonHeight, buttonColor);
            btnJobApplication.Click += (sender, e) => OpenForm(new Hiring());

            Button btnRecruitment = CreateButton("Personel Kaydı", new Point(startX, startY + (buttonHeight + spacing) * 2), buttonWidth, buttonHeight, buttonColor);
            btnRecruitment.Click += (sender, e) => OpenForm(new PersonelBligiGirisi());

            Button btnEmployeeSatisfaction = CreateButton("Çalışan Memnuniyeti Anketi", new Point(startX, startY + (buttonHeight + spacing) * 3), buttonWidth, buttonHeight, buttonColor);
            btnEmployeeSatisfaction.Click += (sender, e) => OpenForm(new Anket());

            Button btnLeaveManagement = CreateButton("İzin ve İşgücü Yönetimi", new Point(startX, startY + (buttonHeight + spacing) * 4), buttonWidth, buttonHeight, buttonColor);
            btnLeaveManagement.Click += (sender, e) => OpenForm(new izinIslemleri());

            Button btnJobListings = CreateButton("İş İlanları", new Point(startX, startY + (buttonHeight + spacing) * 5), buttonWidth, buttonHeight, buttonColor);
            //btnJobListings.Click += (sender, e) => OpenForm(new JobListings());

            // Çıkış Yap butonu
            int logoutButtonWidth = 100;
            Button btnLogout = CreateButton("Çıkış Yap", new Point(panel.Width - logoutButtonWidth - 20, panel.Height - buttonHeight - 20), logoutButtonWidth, buttonHeight, Color.Red);
            btnLogout.Click += (sender, e) => OpenForm(new Form1());
            btnLogout.Font = new Font("Arial", 8, FontStyle.Regular);

            // Butonları panele ekleme
            panel.Controls.Add(btnPersonnelInfo);
            panel.Controls.Add(btnJobApplication);
            panel.Controls.Add(btnRecruitment);
            panel.Controls.Add(btnEmployeeSatisfaction);
            panel.Controls.Add(btnLeaveManagement);
            panel.Controls.Add(btnJobListings);
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
