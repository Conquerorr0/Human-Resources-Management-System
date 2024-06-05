namespace WinUI1
{
    partial class Form3
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ageCount = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.comboBoxEnnglishLevel = new System.Windows.Forms.ComboBox();
            this.labelEnglishLavel = new System.Windows.Forms.Label();
            this.labelCv = new System.Windows.Forms.Label();
            this.buttonCv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFullName.Location = new System.Drawing.Point(93, 50);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(114, 29);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Ad Soyad:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(287, 47);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(301, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(91, 99);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Telefon Numarası:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(91, 153);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(93, 358);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(88, 20);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Mesajınız:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(287, 100);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(299, 26);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(285, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.Location = new System.Drawing.Point(92, 402);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(495, 189);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Location = new System.Drawing.Point(253, 625);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 44);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "GÖNDER";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ageCount
            // 
            this.ageCount.Location = new System.Drawing.Point(285, 212);
            this.ageCount.Margin = new System.Windows.Forms.Padding(2);
            this.ageCount.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageCount.Name = "ageCount";
            this.ageCount.Size = new System.Drawing.Size(40, 23);
            this.ageCount.TabIndex = 10;
            this.ageCount.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(94, 212);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 17);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Yaş: ";
            // 
            // comboBoxEnnglishLevel
            // 
            this.comboBoxEnnglishLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnnglishLevel.FormattingEnabled = true;
            this.comboBoxEnnglishLevel.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.comboBoxEnnglishLevel.Location = new System.Drawing.Point(285, 259);
            this.comboBoxEnnglishLevel.Name = "comboBoxEnnglishLevel";
            this.comboBoxEnnglishLevel.Size = new System.Drawing.Size(121, 25);
            this.comboBoxEnnglishLevel.TabIndex = 11;
            // 
            // labelEnglishLavel
            // 
            this.labelEnglishLavel.AutoSize = true;
            this.labelEnglishLavel.Location = new System.Drawing.Point(92, 259);
            this.labelEnglishLavel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnglishLavel.Name = "labelEnglishLavel";
            this.labelEnglishLavel.Size = new System.Drawing.Size(142, 17);
            this.labelEnglishLavel.TabIndex = 12;
            this.labelEnglishLavel.Text = "İngilizce Seviyesi: ";
            // 
            // labelCv
            // 
            this.labelCv.AutoSize = true;
            this.labelCv.Location = new System.Drawing.Point(94, 309);
            this.labelCv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCv.Name = "labelCv";
            this.labelCv.Size = new System.Drawing.Size(33, 17);
            this.labelCv.TabIndex = 13;
            this.labelCv.Text = "CV:";
            // 
            // buttonCv
            // 
            this.buttonCv.Location = new System.Drawing.Point(285, 309);
            this.buttonCv.Name = "buttonCv";
            this.buttonCv.Size = new System.Drawing.Size(121, 23);
            this.buttonCv.TabIndex = 14;
            this.buttonCv.Text = "Pdf Ekle";
            this.buttonCv.UseVisualStyleBackColor = true;
            this.buttonCv.Click += new System.EventHandler(this.buttonCv_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 717);
            this.Controls.Add(this.buttonCv);
            this.Controls.Add(this.labelCv);
            this.Controls.Add(this.labelEnglishLavel);
            this.Controls.Add(this.comboBoxEnnglishLevel);
            this.Controls.Add(this.ageCount);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblFullName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.ageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.NumericUpDown ageCount;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox comboBoxEnnglishLevel;
        private System.Windows.Forms.Label labelEnglishLavel;
        private System.Windows.Forms.Label labelCv;
        private System.Windows.Forms.Button buttonCv;
    }
}