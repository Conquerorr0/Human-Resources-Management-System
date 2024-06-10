using System;
using System.Windows.Forms;

namespace WinUI1
{
    public partial class cvPanel : Form
    {
        private WebBrowser webBrowser;

        public string PdfUrl { get; set; }

        public cvPanel()
        {
            InitializeComponent();
        }

        private void cvPanel_Load(object sender, EventArgs e)
        {
            webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(webBrowser);

            if (!string.IsNullOrEmpty(PdfUrl))
            {
                webBrowser.Url = new Uri(PdfUrl);
            }
        }
    }
}
