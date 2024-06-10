namespace WinUI1
{
    partial class izinOnay
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(12, 352);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(123, 35);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(193, 352);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(98, 35);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(359, 352);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(92, 35);
            this.btnReddet.TabIndex = 3;
            this.btnReddet.Text = "REDDET";
            this.btnReddet.UseVisualStyleBackColor = true;
            // 
            // izinOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 558);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.dataGridView1);
            this.Name = "izinOnay";
            this.Text = "izinOnay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
    }
}