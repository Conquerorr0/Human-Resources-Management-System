namespace WinUI1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personnalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalDepartmant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marriedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnalWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDepartmants = new System.Windows.Forms.ComboBox();
            this.lblDepartmant = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.ageCount = new System.Windows.Forms.NumericUpDown();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.childCount = new System.Windows.Forms.NumericUpDown();
            this.lblMarriedStatus = new System.Windows.Forms.Label();
            this.cbMarried = new System.Windows.Forms.CheckBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnLessWage = new System.Windows.Forms.Button();
            this.btnMoreWage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnalName,
            this.personnalDepartmant,
            this.personnalAge,
            this.personnalPhone,
            this.personnalEmail,
            this.personnalAddress,
            this.childQuantity,
            this.marriedStatus,
            this.personnalGender,
            this.personnalWage});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1719, 642);
            this.dataGridView1.TabIndex = 0;
            // 
            // personnalName
            // 
            this.personnalName.HeaderText = "İsim";
            this.personnalName.MinimumWidth = 6;
            this.personnalName.Name = "personnalName";
            this.personnalName.ReadOnly = true;
            this.personnalName.Width = 125;
            // 
            // personnalDepartmant
            // 
            this.personnalDepartmant.HeaderText = "Departman";
            this.personnalDepartmant.MinimumWidth = 6;
            this.personnalDepartmant.Name = "personnalDepartmant";
            this.personnalDepartmant.ReadOnly = true;
            this.personnalDepartmant.Width = 125;
            // 
            // personnalAge
            // 
            this.personnalAge.HeaderText = "Yaş";
            this.personnalAge.MinimumWidth = 6;
            this.personnalAge.Name = "personnalAge";
            this.personnalAge.ReadOnly = true;
            this.personnalAge.Width = 125;
            // 
            // personnalPhone
            // 
            this.personnalPhone.HeaderText = "Telefon No";
            this.personnalPhone.MinimumWidth = 6;
            this.personnalPhone.Name = "personnalPhone";
            this.personnalPhone.ReadOnly = true;
            this.personnalPhone.Width = 125;
            // 
            // personnalEmail
            // 
            this.personnalEmail.HeaderText = "Eposta";
            this.personnalEmail.MinimumWidth = 6;
            this.personnalEmail.Name = "personnalEmail";
            this.personnalEmail.ReadOnly = true;
            this.personnalEmail.Width = 125;
            // 
            // personnalAddress
            // 
            this.personnalAddress.HeaderText = "Adres";
            this.personnalAddress.MinimumWidth = 6;
            this.personnalAddress.Name = "personnalAddress";
            this.personnalAddress.ReadOnly = true;
            this.personnalAddress.Width = 125;
            // 
            // childQuantity
            // 
            this.childQuantity.HeaderText = "Çocuk Sayısı";
            this.childQuantity.MinimumWidth = 6;
            this.childQuantity.Name = "childQuantity";
            this.childQuantity.ReadOnly = true;
            this.childQuantity.Width = 125;
            // 
            // marriedStatus
            // 
            this.marriedStatus.HeaderText = "Evlilik Durumu";
            this.marriedStatus.MinimumWidth = 6;
            this.marriedStatus.Name = "marriedStatus";
            this.marriedStatus.ReadOnly = true;
            this.marriedStatus.Width = 125;
            // 
            // personnalGender
            // 
            this.personnalGender.HeaderText = "Cinsiyet";
            this.personnalGender.MinimumWidth = 6;
            this.personnalGender.Name = "personnalGender";
            this.personnalGender.ReadOnly = true;
            this.personnalGender.Width = 125;
            // 
            // personnalWage
            // 
            this.personnalWage.HeaderText = "Maaş";
            this.personnalWage.MinimumWidth = 6;
            this.personnalWage.Name = "personnalWage";
            this.personnalWage.ReadOnly = true;
            this.personnalWage.Width = 125;
            // 
            // cmDepartmants
            // 
            this.cmDepartmants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDepartmants.FormattingEnabled = true;
            this.cmDepartmants.Items.AddRange(new object[] {
            "Departman 1",
            "Departman 2",
            "Departman 3"});
            this.cmDepartmants.Location = new System.Drawing.Point(147, 21);
            this.cmDepartmants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmDepartmants.Name = "cmDepartmants";
            this.cmDepartmants.Size = new System.Drawing.Size(135, 24);
            this.cmDepartmants.TabIndex = 1;
            // 
            // lblDepartmant
            // 
            this.lblDepartmant.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmant.Location = new System.Drawing.Point(61, 25);
            this.lblDepartmant.Name = "lblDepartmant";
            this.lblDepartmant.Size = new System.Drawing.Size(77, 18);
            this.lblDepartmant.TabIndex = 2;
            this.lblDepartmant.Text = "Departman: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(305, 25);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Yaş: ";
            // 
            // ageCount
            // 
            this.ageCount.Location = new System.Drawing.Point(349, 22);
            this.ageCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ageCount.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageCount.Name = "ageCount";
            this.ageCount.Size = new System.Drawing.Size(53, 22);
            this.ageCount.TabIndex = 4;
            this.ageCount.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(433, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 16);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Adres: ";
            // 
            // cbAddress
            // 
            this.cbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cbAddress.Location = new System.Drawing.Point(488, 20);
            this.cbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(176, 24);
            this.cbAddress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Çocuk Sayısı:";
            // 
            // childCount
            // 
            this.childCount.Location = new System.Drawing.Point(783, 23);
            this.childCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.childCount.Name = "childCount";
            this.childCount.Size = new System.Drawing.Size(43, 22);
            this.childCount.TabIndex = 8;
            // 
            // lblMarriedStatus
            // 
            this.lblMarriedStatus.AutoSize = true;
            this.lblMarriedStatus.Location = new System.Drawing.Point(849, 25);
            this.lblMarriedStatus.Name = "lblMarriedStatus";
            this.lblMarriedStatus.Size = new System.Drawing.Size(32, 16);
            this.lblMarriedStatus.TabIndex = 9;
            this.lblMarriedStatus.Text = "Evli:";
            // 
            // cbMarried
            // 
            this.cbMarried.AutoSize = true;
            this.cbMarried.Location = new System.Drawing.Point(887, 25);
            this.cbMarried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarried.Name = "cbMarried";
            this.cbMarried.Size = new System.Drawing.Size(18, 17);
            this.cbMarried.TabIndex = 10;
            this.cbMarried.UseVisualStyleBackColor = true;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(939, 25);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(44, 16);
            this.lblWage.TabIndex = 11;
            this.lblWage.Text = "Maaş:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(989, 21);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            17002,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            17002,
            0,
            0,
            0});
            // 
            // btnLessWage
            // 
            this.btnLessWage.Location = new System.Drawing.Point(1115, 20);
            this.btnLessWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLessWage.Name = "btnLessWage";
            this.btnLessWage.Size = new System.Drawing.Size(51, 23);
            this.btnLessWage.TabIndex = 13;
            this.btnLessWage.Text = "Az";
            this.btnLessWage.UseVisualStyleBackColor = true;
            this.btnLessWage.Click += new System.EventHandler(this.btnLessWage_Click);
            // 
            // btnMoreWage
            // 
            this.btnMoreWage.Location = new System.Drawing.Point(1172, 20);
            this.btnMoreWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoreWage.Name = "btnMoreWage";
            this.btnMoreWage.Size = new System.Drawing.Size(55, 23);
            this.btnMoreWage.TabIndex = 14;
            this.btnMoreWage.Text = "Çok";
            this.btnMoreWage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1723, 705);
            this.Controls.Add(this.btnMoreWage);
            this.Controls.Add(this.btnLessWage);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.cbMarried);
            this.Controls.Add(this.lblMarriedStatus);
            this.Controls.Add(this.childCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.ageCount);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDepartmant);
            this.Controls.Add(this.cmDepartmants);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Kullanıcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalDepartmant;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn childQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn marriedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnalWage;
        private System.Windows.Forms.ComboBox cmDepartmants;
        private System.Windows.Forms.Label lblDepartmant;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown ageCount;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown childCount;
        private System.Windows.Forms.Label lblMarriedStatus;
        private System.Windows.Forms.CheckBox cbMarried;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnLessWage;
        private System.Windows.Forms.Button btnMoreWage;
    }
}