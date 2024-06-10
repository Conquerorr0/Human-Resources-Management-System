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
            this.Text = "İnsan Kaynakları Ana Sayfa";
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
            int buttonCount = 4; // Buton sayısı
            int spacing = 10;
            Color buttonColor = Color.LightGray;

            // Butonların oluşturulması
            Button btnPersonnelInfo = CreateButton("Personel Bilgileri", new Point(0, 0), buttonWidth, buttonHeight, buttonColor);
            btnPersonnelInfo.Click += (sender, e) => OpenForm(new Form2());

            Button btnJobApplication = CreateButton("İş Başvuru Formu", new Point(0, 0), buttonWidth, buttonHeight, buttonColor);
            btnJobApplication.Click += (sender, e) => OpenForm(new Hiring());

            Button btnRecruitment = CreateButton("Personel Kaydı", new Point(0, 0), buttonWidth, buttonHeight, buttonColor);
            btnRecruitment.Click += (sender, e) => OpenForm(new PersonelBligiGirisi());

            Button btnLeaveManagement = CreateButton("İzin ve İşgücü Yönetimi", new Point(0, 0), buttonWidth, buttonHeight, buttonColor);
            btnLeaveManagement.Click += (sender, e) => OpenForm(new izinOnay());

            // Çıkış Yap butonu
            int logoutButtonWidth = 100;
            Button btnLogout = CreateButton("Çıkış Yap", new Point(0, 0), logoutButtonWidth, buttonHeight, Color.Red);
            btnLogout.Click += (sender, e) => OpenForm(new Form1());
            btnLogout.Font = new Font("Arial", 8, FontStyle.Regular);

            // Butonları panele ekleme
            panel.Controls.Add(btnPersonnelInfo);
            panel.Controls.Add(btnJobApplication);
            panel.Controls.Add(btnRecruitment);
            panel.Controls.Add(btnLeaveManagement);
            panel.Controls.Add(btnLogout);

            // Formun yeniden boyutlandırılması durumunda butonların yeniden düzenlenmesi için Resize olayına abonelik
            this.Resize += (sender, e) => LayoutButtons(panel, buttonWidth, buttonHeight, spacing);

            // İlk düzenleme
            LayoutButtons(panel, buttonWidth, buttonHeight, spacing);
        }

        private void LayoutButtons(Panel panel, int buttonWidth, int buttonHeight, int spacing)
        {
            // Butonların listesi
            var buttons = new Button[]
            {
                (Button)panel.Controls[0], // btnPersonnelInfo
                (Button)panel.Controls[1], // btnJobApplication
                (Button)panel.Controls[2], // btnRecruitment
                (Button)panel.Controls[3], // btnLeaveManagement
                (Button)panel.Controls[4]  // btnLogout
            };

            // Panel genişliği ve yüksekliği
            int panelWidth = panel.ClientSize.Width;
            int panelHeight = panel.ClientSize.Height;

            // Toplam kullanılabilir yükseklik
            int totalButtonHeight = buttonHeight * buttons.Length + spacing * (buttons.Length - 1);
            int startY = (panelHeight - totalButtonHeight) / 2; // Butonları dikeyde ortalamak için Y konumu

            for (int i = 0; i < buttons.Length - 1; i++)
            {
                buttons[i].Location = new Point((panelWidth - buttonWidth) / 2, startY + i * (buttonHeight + spacing));
                buttons[i].Size = new Size(buttonWidth, buttonHeight);
            }

            // Çıkış butonunun konumu
            Button btnLogout = buttons[buttons.Length - 1];
            btnLogout.Location = new Point(panelWidth - btnLogout.Width - 20, panelHeight - btnLogout.Height - 20);
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
