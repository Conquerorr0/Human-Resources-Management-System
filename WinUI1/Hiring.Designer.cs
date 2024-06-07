namespace WinUI1
{
    partial class Hiring
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.cbEnglishLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmDepartmants = new System.Windows.Forms.ComboBox();
            this.btnMoreWage = new System.Windows.Forms.Button();
            this.btnLessWage = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblWage = new System.Windows.Forms.Label();
            this.ageCount = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            this.lblDepartmant = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.Panel();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.candidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddInterview = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblInterviewTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteInterview = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 712);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PanelInfo);
            this.tabPage1.Controls.Add(this.TablePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1268, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Başvurular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.label5);
            this.PanelInfo.Controls.Add(this.cv);
            this.PanelInfo.Controls.Add(this.lblMessage);
            this.PanelInfo.Controls.Add(this.btnReject);
            this.PanelInfo.Controls.Add(this.btnAccept);
            this.PanelInfo.Controls.Add(this.lblLanguage);
            this.PanelInfo.Controls.Add(this.lblAge);
            this.PanelInfo.Controls.Add(this.lblMail);
            this.PanelInfo.Controls.Add(this.lblPhoneNumber);
            this.PanelInfo.Controls.Add(this.Label11);
            this.PanelInfo.Controls.Add(this.Label10);
            this.PanelInfo.Controls.Add(this.Label9);
            this.PanelInfo.Controls.Add(this.Label8);
            this.PanelInfo.Controls.Add(this.splitter1);
            this.PanelInfo.Controls.Add(this.lblPersonName);
            this.PanelInfo.Location = new System.Drawing.Point(905, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(508, 694);
            this.PanelInfo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "CV:";
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cv.Location = new System.Drawing.Point(120, 343);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(110, 25);
            this.cv.TabIndex = 14;
            this.cv.TabStop = true;
            this.cv.Text = "linkLabel1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(54, 413);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(300, 184);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "label5";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReject.Location = new System.Drawing.Point(205, 614);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(113, 41);
            this.btnReject.TabIndex = 12;
            this.btnReject.Text = "REDDET";
            this.btnReject.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Lime;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAccept.Location = new System.Drawing.Point(52, 614);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(113, 41);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "KABUL ET";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLanguage.Location = new System.Drawing.Point(241, 301);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(59, 20);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "label5";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(121, 255);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(59, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "label5";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(121, 211);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(59, 20);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "label5";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(241, 170);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(59, 20);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "label5";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label11.Location = new System.Drawing.Point(48, 301);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(187, 20);
            this.Label11.TabIndex = 6;
            this.Label11.Text = "Yabancı Dil Seviyesi:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label10.Location = new System.Drawing.Point(48, 255);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(46, 20);
            this.Label10.TabIndex = 5;
            this.Label10.Text = "Yaş:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label9.Location = new System.Drawing.Point(48, 211);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(62, 20);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Email:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label8.Location = new System.Drawing.Point(48, 170);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(163, 20);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Telefon Numarası:";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.MinExtra = 5;
            this.splitter1.MinSize = 5;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 694);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lblPersonName
            // 
            this.lblPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonName.Location = new System.Drawing.Point(52, 37);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(266, 28);
            this.lblPersonName.TabIndex = 0;
            this.lblPersonName.Text = "label2";
            this.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablePanel
            // 
            this.TablePanel.Controls.Add(this.cbEnglishLevel);
            this.TablePanel.Controls.Add(this.label1);
            this.TablePanel.Controls.Add(this.cmDepartmants);
            this.TablePanel.Controls.Add(this.btnMoreWage);
            this.TablePanel.Controls.Add(this.btnLessWage);
            this.TablePanel.Controls.Add(this.numericUpDown1);
            this.TablePanel.Controls.Add(this.lblWage);
            this.TablePanel.Controls.Add(this.ageCount);
            this.TablePanel.Controls.Add(this.Label);
            this.TablePanel.Controls.Add(this.lblDepartmant);
            this.TablePanel.Controls.Add(this.dataGridView1);
            this.TablePanel.Location = new System.Drawing.Point(-3, -12);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(918, 706);
            this.TablePanel.TabIndex = 4;
            // 
            // cbEnglishLevel
            // 
            this.cbEnglishLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnglishLevel.FormattingEnabled = true;
            this.cbEnglishLevel.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.cbEnglishLevel.Location = new System.Drawing.Point(796, 33);
            this.cbEnglishLevel.Name = "cbEnglishLevel";
            this.cbEnglishLevel.Size = new System.Drawing.Size(80, 24);
            this.cbEnglishLevel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "İngilizce Seviyesi:";
            // 
            // cmDepartmants
            // 
            this.cmDepartmants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDepartmants.FormattingEnabled = true;
            this.cmDepartmants.Items.AddRange(new object[] {
            "Departman 1",
            "Departman 2",
            "Departman 3"});
            this.cmDepartmants.Location = new System.Drawing.Point(112, 32);
            this.cmDepartmants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmDepartmants.Name = "cmDepartmants";
            this.cmDepartmants.Size = new System.Drawing.Size(106, 24);
            this.cmDepartmants.TabIndex = 7;
            // 
            // btnMoreWage
            // 
            this.btnMoreWage.Location = new System.Drawing.Point(606, 32);
            this.btnMoreWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoreWage.Name = "btnMoreWage";
            this.btnMoreWage.Size = new System.Drawing.Size(55, 23);
            this.btnMoreWage.TabIndex = 18;
            this.btnMoreWage.Text = "Çok";
            this.btnMoreWage.UseVisualStyleBackColor = true;
            // 
            // btnLessWage
            // 
            this.btnLessWage.Location = new System.Drawing.Point(549, 32);
            this.btnLessWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLessWage.Name = "btnLessWage";
            this.btnLessWage.Size = new System.Drawing.Size(51, 23);
            this.btnLessWage.TabIndex = 17;
            this.btnLessWage.Text = "Az";
            this.btnLessWage.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(423, 33);
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
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            17002,
            0,
            0,
            0});
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(373, 35);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(44, 16);
            this.lblWage.TabIndex = 15;
            this.lblWage.Text = "Maaş:";
            // 
            // ageCount
            // 
            this.ageCount.Location = new System.Drawing.Point(293, 32);
            this.ageCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ageCount.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageCount.Name = "ageCount";
            this.ageCount.Size = new System.Drawing.Size(53, 22);
            this.ageCount.TabIndex = 10;
            this.ageCount.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(249, 35);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(37, 16);
            this.Label.TabIndex = 9;
            this.Label.Text = "Yaş: ";
            // 
            // lblDepartmant
            // 
            this.lblDepartmant.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmant.Location = new System.Drawing.Point(28, 36);
            this.lblDepartmant.Name = "lblDepartmant";
            this.lblDepartmant.Size = new System.Drawing.Size(120, 18);
            this.lblDepartmant.TabIndex = 8;
            this.lblDepartmant.Text = "Departman: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personName,
            this.phone,
            this.mail,
            this.age,
            this.language});
            this.dataGridView1.Location = new System.Drawing.Point(9, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 628);
            this.dataGridView1.TabIndex = 0;
            // 
            // personName
            // 
            this.personName.HeaderText = "İsim Soyisim";
            this.personName.MinimumWidth = 6;
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            this.personName.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Telefon Numarası";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.MinimumWidth = 6;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Yaş";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 125;
            // 
            // language
            // 
            this.language.HeaderText = "Yabancı Dil Seviyesi";
            this.language.MinimumWidth = 6;
            this.language.Name = "language";
            this.language.ReadOnly = true;
            this.language.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Info);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.calendar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1268, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mülakat Takvimi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.lblCandidateName);
            this.Info.Location = new System.Drawing.Point(642, 213);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(620, 464);
            this.Info.TabIndex = 3;
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCandidateName.Location = new System.Drawing.Point(204, 36);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(188, 38);
            this.lblCandidateName.TabIndex = 0;
            this.lblCandidateName.Text = "label5";
            this.lblCandidateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateName,
            this.departmant,
            this.time,
            this.status});
            this.dataGridView2.Location = new System.Drawing.Point(-4, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(640, 470);
            this.dataGridView2.TabIndex = 2;
            // 
            // candidateName
            // 
            this.candidateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.candidateName.HeaderText = "İsim ";
            this.candidateName.MinimumWidth = 6;
            this.candidateName.Name = "candidateName";
            this.candidateName.ReadOnly = true;
            this.candidateName.Width = 63;
            // 
            // departmant
            // 
            this.departmant.HeaderText = "Başvurulan Departman";
            this.departmant.MinimumWidth = 6;
            this.departmant.Name = "departmant";
            this.departmant.ReadOnly = true;
            this.departmant.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "Mülakat Tarihi";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Mülakat Durumu";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(637, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(631, 204);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddInterview);
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cbMinute);
            this.tabPage3.Controls.Add(this.cbHour);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(623, 175);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Mülakat Ekle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddInterview
            // 
            this.btnAddInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddInterview.Location = new System.Drawing.Point(243, 111);
            this.btnAddInterview.Name = "btnAddInterview";
            this.btnAddInterview.Size = new System.Drawing.Size(169, 47);
            this.btnAddInterview.TabIndex = 6;
            this.btnAddInterview.Text = "EKLE";
            this.btnAddInterview.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(316, 22);
            this.txtName.MaximumSize = new System.Drawing.Size(150, 30);
            this.txtName.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(324, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbMinute.Location = new System.Drawing.Point(341, 68);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(52, 24);
            this.cbMinute.TabIndex = 3;
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHour.Location = new System.Drawing.Point(269, 67);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(52, 24);
            this.cbHour.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(225, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim Soyisim:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblInterviewTime);
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.txtDeleteInterview);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(623, 175);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mülakat Sil";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblInterviewTime
            // 
            this.lblInterviewTime.Location = new System.Drawing.Point(273, 68);
            this.lblInterviewTime.Name = "lblInterviewTime";
            this.lblInterviewTime.Size = new System.Drawing.Size(135, 23);
            this.lblInterviewTime.TabIndex = 14;
            this.lblInterviewTime.Text = "label8";
            this.lblInterviewTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(247, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 47);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtDeleteInterview
            // 
            this.txtDeleteInterview.Location = new System.Drawing.Point(320, 23);
            this.txtDeleteInterview.MaximumSize = new System.Drawing.Size(150, 30);
            this.txtDeleteInterview.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtDeleteInterview.Name = "txtDeleteInterview";
            this.txtDeleteInterview.ReadOnly = true;
            this.txtDeleteInterview.Size = new System.Drawing.Size(150, 22);
            this.txtDeleteInterview.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(229, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "İsim Soyisim:";
            // 
            // calendar
            // 
            this.calendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            // 
            // Hiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 708);
            this.Controls.Add(this.tabControl1);
            this.Name = "Hiring";
            this.Text = "İşe Alım Ekranı";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.ComboBox cbEnglishLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoreWage;
        private System.Windows.Forms.Button btnLessWage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.NumericUpDown ageCount;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lblDepartmant;
        private System.Windows.Forms.ComboBox cmDepartmants;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddInterview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteInterview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInterviewTime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmant;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel cv;
        private System.Windows.Forms.Label lblMessage;
    }
}