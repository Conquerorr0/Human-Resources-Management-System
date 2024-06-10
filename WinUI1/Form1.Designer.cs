namespace WinUI1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SignIn = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.TabPage();
            this.btnShowHide1 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SignIn.SuspendLayout();
            this.Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SignIn);
            this.tabControl1.Controls.Add(this.Register);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignIn.Controls.Add(this.linkLabel1);
            this.SignIn.Controls.Add(this.btnShowHide);
            this.SignIn.Controls.Add(this.btnSignIn);
            this.SignIn.Controls.Add(this.lblMessage);
            this.SignIn.Controls.Add(this.txtPassword);
            this.SignIn.Controls.Add(this.txtUsername);
            this.SignIn.Controls.Add(this.label2);
            this.SignIn.Controls.Add(this.label1);
            this.SignIn.Location = new System.Drawing.Point(4, 34);
            this.SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignIn.Name = "SignIn";
            this.SignIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignIn.Size = new System.Drawing.Size(793, 412);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Giriş Ekranı";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "İş Başvurusu Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnShowHide
            // 
            this.btnShowHide.ImageKey = "hide.png";
            this.btnShowHide.ImageList = this.imageList1;
            this.btnShowHide.Location = new System.Drawing.Point(547, 162);
            this.btnShowHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(40, 39);
            this.btnShowHide.TabIndex = 7;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hide.png");
            this.imageList1.Images.SetKeyName(1, "show.png");
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(304, 242);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(180, 38);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Giriş Yap";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(123, 47);
            this.lblMessage.MaximumSize = new System.Drawing.Size(1000, 100);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(500, 25);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleDescription = "";
            this.txtUsername.Location = new System.Drawing.Point(319, 117);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Register.Controls.Add(this.btnShowHide1);
            this.Register.Controls.Add(this.btnRegister);
            this.Register.Controls.Add(this.txtRegisterPassword);
            this.Register.Controls.Add(this.txtRegisterUsername);
            this.Register.Controls.Add(this.lblRegisterPassword);
            this.Register.Controls.Add(this.lblRegisterUsername);
            this.Register.Location = new System.Drawing.Point(4, 34);
            this.Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register.Size = new System.Drawing.Size(793, 412);
            this.Register.TabIndex = 1;
            this.Register.Text = "Kayıt Ekranı";
            // 
            // btnShowHide1
            // 
            this.btnShowHide1.Location = new System.Drawing.Point(565, 174);
            this.btnShowHide1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowHide1.Name = "btnShowHide1";
            this.btnShowHide1.Size = new System.Drawing.Size(40, 39);
            this.btnShowHide1.TabIndex = 12;
            this.btnShowHide1.UseVisualStyleBackColor = true;
            this.btnShowHide1.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(323, 254);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 38);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(339, 178);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(223, 30);
            this.txtRegisterPassword.TabIndex = 10;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(339, 128);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(223, 30);
            this.txtRegisterUsername.TabIndex = 9;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(248, 182);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(70, 25);
            this.lblRegisterPassword.TabIndex = 8;
            this.lblRegisterPassword.Text = "Şifre: ";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(173, 130);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(145, 25);
            this.lblRegisterUsername.TabIndex = 7;
            this.lblRegisterUsername.Text = "Kullanıcı Adı: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.SignIn.ResumeLayout(false);
            this.SignIn.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SignIn;
        private System.Windows.Forms.TabPage Register;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnShowHide1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

