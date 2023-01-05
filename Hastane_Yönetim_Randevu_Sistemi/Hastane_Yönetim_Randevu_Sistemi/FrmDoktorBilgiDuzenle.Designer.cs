namespace Hastane_Yönetim_Randevu_Sistemi
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBranş = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBilgiGnclle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TC No:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(73, 82);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtSoyad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(73, 113);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(100, 20);
            this.MskTc.TabIndex = 10;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(73, 47);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(73, 177);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtSifre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre:";
            // 
            // CmbBranş
            // 
            this.CmbBranş.FormattingEnabled = true;
            this.CmbBranş.Location = new System.Drawing.Point(73, 147);
            this.CmbBranş.Name = "CmbBranş";
            this.CmbBranş.Size = new System.Drawing.Size(100, 21);
            this.CmbBranş.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Branş:";
            // 
            // BtnBilgiGnclle
            // 
            this.BtnBilgiGnclle.Location = new System.Drawing.Point(84, 217);
            this.BtnBilgiGnclle.Name = "BtnBilgiGnclle";
            this.BtnBilgiGnclle.Size = new System.Drawing.Size(75, 24);
            this.BtnBilgiGnclle.TabIndex = 26;
            this.BtnBilgiGnclle.Text = "Güncelle";
            this.BtnBilgiGnclle.UseVisualStyleBackColor = true;
            this.BtnBilgiGnclle.Click += new System.EventHandler(this.BtnBilgiGnclle_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(226, 271);
            this.Controls.Add(this.BtnBilgiGnclle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbBranş);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktorBilgiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBranş;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBilgiGnclle;
    }
}