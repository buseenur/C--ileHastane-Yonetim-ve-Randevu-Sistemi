namespace Hastane_Yönetim_Randevu_Sistemi
{
    partial class FrmBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBransPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBransId = new System.Windows.Forms.TextBox();
            this.TxtBransAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş id:";
            // 
            // TxtBransId
            // 
            this.TxtBransId.Location = new System.Drawing.Point(105, 39);
            this.TxtBransId.Name = "TxtBransId";
            this.TxtBransId.Size = new System.Drawing.Size(100, 20);
            this.TxtBransId.TabIndex = 1;
            // 
            // TxtBransAd
            // 
            this.TxtBransAd.Location = new System.Drawing.Point(105, 77);
            this.TxtBransAd.Name = "TxtBransAd";
            this.TxtBransAd.Size = new System.Drawing.Size(100, 20);
            this.TxtBransAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branş Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnGncelle
            // 
            this.BtnGncelle.Location = new System.Drawing.Point(99, 160);
            this.BtnGncelle.Name = "BtnGncelle";
            this.BtnGncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGncelle.TabIndex = 5;
            this.BtnGncelle.Text = "Güncelle";
            this.BtnGncelle.UseVisualStyleBackColor = true;
            this.BtnGncelle.Click += new System.EventHandler(this.BtnGncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(141, 122);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(50, 122);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(582, 206);
            this.Controls.Add(this.BtnGncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBransAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBransId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBransPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBransId;
        private System.Windows.Forms.TextBox TxtBransAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
    }
}