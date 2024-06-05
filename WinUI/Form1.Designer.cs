namespace WinUI
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserSıgnIn = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelHR = new System.Windows.Forms.Panel();
            this.btnHMShowHide = new System.Windows.Forms.Button();
            this.btnHMEnter = new System.Windows.Forms.Button();
            this.txtHMPassword = new System.Windows.Forms.TextBox();
            this.txtHMUsername = new System.Windows.Forms.TextBox();
            this.lblHMPassword = new System.Windows.Forms.Label();
            this.lblHMUsername = new System.Windows.Forms.Label();
            this.lblHMMessage = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.UserSıgnIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelHR.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserSıgnIn);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // UserSıgnIn
            // 
            this.UserSıgnIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserSıgnIn.Controls.Add(this.panel1);
            this.UserSıgnIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserSıgnIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserSıgnIn.Location = new System.Drawing.Point(4, 28);
            this.UserSıgnIn.Name = "UserSıgnIn";
            this.UserSıgnIn.Padding = new System.Windows.Forms.Padding(3);
            this.UserSıgnIn.Size = new System.Drawing.Size(794, 419);
            this.UserSıgnIn.TabIndex = 0;
            this.UserSıgnIn.Text = "Personel Girişi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnShowHide);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(94, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 327);
            this.panel1.TabIndex = 2;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHide.Image")));
            this.btnShowHide.Location = new System.Drawing.Point(481, 171);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(34, 34);
            this.btnShowHide.TabIndex = 5;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide1_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnter.Location = new System.Drawing.Point(198, 221);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(212, 50);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "GİRİŞ YAP";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(291, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(291, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(129, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(147, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Kullanıcı Şifre:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(129, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.panelHR);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İK Girişi";
            // 
            // panelHR
            // 
            this.panelHR.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelHR.Controls.Add(this.lblHMMessage);
            this.panelHR.Controls.Add(this.btnHMShowHide);
            this.panelHR.Controls.Add(this.btnHMEnter);
            this.panelHR.Controls.Add(this.txtHMPassword);
            this.panelHR.Controls.Add(this.txtHMUsername);
            this.panelHR.Controls.Add(this.lblHMPassword);
            this.panelHR.Controls.Add(this.lblHMUsername);
            this.panelHR.Location = new System.Drawing.Point(94, 46);
            this.panelHR.Name = "panelHR";
            this.panelHR.Size = new System.Drawing.Size(606, 327);
            this.panelHR.TabIndex = 1;
            // 
            // btnHMShowHide
            // 
            this.btnHMShowHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHMShowHide.Image")));
            this.btnHMShowHide.Location = new System.Drawing.Point(481, 171);
            this.btnHMShowHide.Name = "btnHMShowHide";
            this.btnHMShowHide.Size = new System.Drawing.Size(34, 34);
            this.btnHMShowHide.TabIndex = 5;
            this.btnHMShowHide.UseVisualStyleBackColor = true;
            this.btnHMShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnHMEnter
            // 
            this.btnHMEnter.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHMEnter.Location = new System.Drawing.Point(198, 221);
            this.btnHMEnter.Name = "btnHMEnter";
            this.btnHMEnter.Size = new System.Drawing.Size(212, 50);
            this.btnHMEnter.TabIndex = 4;
            this.btnHMEnter.Text = "GİRİŞ YAP";
            this.btnHMEnter.UseVisualStyleBackColor = true;
            this.btnHMEnter.Click += new System.EventHandler(this.btnHMEnter_Click);
            // 
            // txtHMPassword
            // 
            this.txtHMPassword.Location = new System.Drawing.Point(291, 175);
            this.txtHMPassword.Name = "txtHMPassword";
            this.txtHMPassword.PasswordChar = '*';
            this.txtHMPassword.Size = new System.Drawing.Size(184, 27);
            this.txtHMPassword.TabIndex = 3;
            // 
            // txtHMUsername
            // 
            this.txtHMUsername.Location = new System.Drawing.Point(291, 122);
            this.txtHMUsername.Name = "txtHMUsername";
            this.txtHMUsername.Size = new System.Drawing.Size(187, 27);
            this.txtHMUsername.TabIndex = 2;
            // 
            // lblHMPassword
            // 
            this.lblHMPassword.AutoSize = true;
            this.lblHMPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHMPassword.Location = new System.Drawing.Point(129, 175);
            this.lblHMPassword.Name = "lblHMPassword";
            this.lblHMPassword.Size = new System.Drawing.Size(147, 24);
            this.lblHMPassword.TabIndex = 1;
            this.lblHMPassword.Text = "Kullanıcı Şifre:";
            // 
            // lblHMUsername
            // 
            this.lblHMUsername.AutoSize = true;
            this.lblHMUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHMUsername.Location = new System.Drawing.Point(129, 121);
            this.lblHMUsername.Name = "lblHMUsername";
            this.lblHMUsername.Size = new System.Drawing.Size(132, 24);
            this.lblHMUsername.TabIndex = 0;
            this.lblHMUsername.Text = "Kullanıcı Adı:";
            // 
            // lblHMMessage
            // 
            this.lblHMMessage.AutoSize = true;
            this.lblHMMessage.Location = new System.Drawing.Point(269, 69);
            this.lblHMMessage.Name = "lblHMMessage";
            this.lblHMMessage.Size = new System.Drawing.Size(0, 19);
            this.lblHMMessage.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(244, 67);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 19);
            this.lblMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.UserSıgnIn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelHR.ResumeLayout(false);
            this.panelHR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserSıgnIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelHR;
        private System.Windows.Forms.Label lblHMUsername;
        private System.Windows.Forms.Label lblHMPassword;
        private System.Windows.Forms.Button btnHMEnter;
        private System.Windows.Forms.TextBox txtHMPassword;
        private System.Windows.Forms.TextBox txtHMUsername;
        private System.Windows.Forms.Button btnHMShowHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblHMMessage;
>>>>>>> ff41e3278c9c9f71e90c307ddcdc613b5a4cff3b
    }
}

