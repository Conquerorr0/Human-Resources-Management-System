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
            this.cmDepartmants = new System.Windows.Forms.ComboBox();
            this.lblDepartmant = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.lblMarriedStatus = new System.Windows.Forms.Label();
            this.cbMarried = new System.Windows.Forms.CheckBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblMarried = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(-1, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1719, 642);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmDepartmants
            // 
            this.cmDepartmants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDepartmants.FormattingEnabled = true;
            this.cmDepartmants.Items.AddRange(new object[] {
            "Muhasebe",
            "Pazarlama",
            "Satış",
            "Bilgi Teknolojileri",
            "Yazılım",
            "Arge"});
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
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(320, 27);
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
            this.cbAddress.Location = new System.Drawing.Point(375, 22);
            this.cbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(176, 24);
            this.cbAddress.TabIndex = 6;
            // 
            // lblMarriedStatus
            // 
            this.lblMarriedStatus.AutoSize = true;
            this.lblMarriedStatus.Location = new System.Drawing.Point(766, 29);
            this.lblMarriedStatus.Name = "lblMarriedStatus";
            this.lblMarriedStatus.Size = new System.Drawing.Size(32, 16);
            this.lblMarriedStatus.TabIndex = 9;
            this.lblMarriedStatus.Text = "Evli:";
            // 
            // cbMarried
            // 
            this.cbMarried.AutoSize = true;
            this.cbMarried.Location = new System.Drawing.Point(629, 28);
            this.cbMarried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarried.Name = "cbMarried";
            this.cbMarried.Size = new System.Drawing.Size(18, 17);
            this.cbMarried.TabIndex = 10;
            this.cbMarried.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbMarried.UseVisualStyleBackColor = true;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(692, 27);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(44, 16);
            this.lblWage.TabIndex = 11;
            this.lblWage.Text = "Maaş:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(742, 23);
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
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(889, 16);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(125, 38);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "FİLTRELE";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblMarried
            // 
            this.lblMarried.AutoSize = true;
            this.lblMarried.Location = new System.Drawing.Point(594, 27);
            this.lblMarried.Name = "lblMarried";
            this.lblMarried.Size = new System.Drawing.Size(32, 16);
            this.lblMarried.TabIndex = 14;
            this.lblMarried.Text = "Evli:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1062, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1723, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMarried);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.cbMarried);
            this.Controls.Add(this.lblMarriedStatus);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDepartmant);
            this.Controls.Add(this.cmDepartmants);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Kullanıcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmDepartmants;
        private System.Windows.Forms.Label lblDepartmant;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Label lblMarriedStatus;
        private System.Windows.Forms.CheckBox cbMarried;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblMarried;
        private System.Windows.Forms.Button button1;
    }
}