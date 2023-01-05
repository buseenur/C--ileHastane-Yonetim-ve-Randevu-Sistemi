namespace Hastane_Yönetim_Randevu_Sistemi
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDoktorGiris = new System.Windows.Forms.Button();
            this.BtnSkreterGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHastaGris
            // 
            this.BtnHastaGris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGris.BackgroundImage")));
            this.BtnHastaGris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGris.Location = new System.Drawing.Point(59, 135);
            this.BtnHastaGris.Name = "BtnHastaGris";
            this.BtnHastaGris.Size = new System.Drawing.Size(115, 93);
            this.BtnHastaGris.TabIndex = 0;
            this.BtnHastaGris.UseVisualStyleBackColor = true;
            this.BtnHastaGris.Click += new System.EventHandler(this.BtnHastaGris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Giriş";
            // 
            // BtnDoktorGiris
            // 
            this.BtnDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGiris.BackgroundImage")));
            this.BtnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGiris.Location = new System.Drawing.Point(230, 135);
            this.BtnDoktorGiris.Name = "BtnDoktorGiris";
            this.BtnDoktorGiris.Size = new System.Drawing.Size(115, 93);
            this.BtnDoktorGiris.TabIndex = 2;
            this.BtnDoktorGiris.UseVisualStyleBackColor = true;
            this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
            // 
            // BtnSkreterGiris
            // 
            this.BtnSkreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSkreterGiris.BackgroundImage")));
            this.BtnSkreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSkreterGiris.Location = new System.Drawing.Point(395, 135);
            this.BtnSkreterGiris.Name = "BtnSkreterGiris";
            this.BtnSkreterGiris.Size = new System.Drawing.Size(115, 93);
            this.BtnSkreterGiris.TabIndex = 3;
            this.BtnSkreterGiris.UseVisualStyleBackColor = true;
            this.BtnSkreterGiris.Click += new System.EventHandler(this.BtnSkreterGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter Giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 47);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yaşam Hastanesi";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(598, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSkreterGiris);
            this.Controls.Add(this.BtnDoktorGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHastaGris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yaşam Hastanesi Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDoktorGiris;
        private System.Windows.Forms.Button BtnSkreterGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

