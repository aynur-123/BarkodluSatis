namespace BarkodluSatis
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.tSifre = new BarkodluSatis.tStandart();
            this.bGiris = new BarkodluSatis.bStandart();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.tKullaniciAdi = new BarkodluSatis.tStandart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluSatis.Properties.Resources.scan_barcode_with_scanner_tool;
            this.pictureBox1.Location = new System.Drawing.Point(358, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSandart3.ForeColor = System.Drawing.Color.White;
            this.lSandart3.Location = new System.Drawing.Point(45, 23);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(435, 32);
            this.lSandart3.TabIndex = 5;
            this.lSandart3.Text = "NurSoft Barkodlu Satış Programı";
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart2.ForeColor = System.Drawing.Color.White;
            this.lSandart2.Location = new System.Drawing.Point(26, 114);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(52, 25);
            this.lSandart2.TabIndex = 3;
            this.lSandart2.Text = "Şifre";
            // 
            // tSifre
            // 
            this.tSifre.BackColor = System.Drawing.Color.White;
            this.tSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tSifre.Location = new System.Drawing.Point(151, 114);
            this.tSifre.Name = "tSifre";
            this.tSifre.PasswordChar = '*';
            this.tSifre.Size = new System.Drawing.Size(184, 30);
            this.tSifre.TabIndex = 2;
            // 
            // bGiris
            // 
            this.bGiris.BackColor = System.Drawing.SystemColors.Highlight;
            this.bGiris.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGiris.Image = global::BarkodluSatis.Properties.Resources.login;
            this.bGiris.Location = new System.Drawing.Point(229, 150);
            this.bGiris.Margin = new System.Windows.Forms.Padding(1);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(106, 71);
            this.bGiris.TabIndex = 3;
            this.bGiris.Text = "Giriş";
            this.bGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bGiris.UseVisualStyleBackColor = false;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart1.ForeColor = System.Drawing.Color.White;
            this.lSandart1.Location = new System.Drawing.Point(26, 78);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(119, 25);
            this.lSandart1.TabIndex = 1;
            this.lSandart1.Text = "Kullanıcı Adı";
            // 
            // tKullaniciAdi
            // 
            this.tKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.tKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKullaniciAdi.Location = new System.Drawing.Point(151, 78);
            this.tKullaniciAdi.Name = "tKullaniciAdi";
            this.tKullaniciAdi.Size = new System.Drawing.Size(184, 30);
            this.tKullaniciAdi.TabIndex = 0;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(622, 231);
            this.Controls.Add(this.lSandart3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lSandart2);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.lSandart1);
            this.Controls.Add(this.tKullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(640, 278);
            this.MinimumSize = new System.Drawing.Size(640, 278);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tStandart tKullaniciAdi;
        private lSandart lSandart1;
        private bStandart bGiris;
        private lSandart lSandart2;
        private tStandart tSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private lSandart lSandart3;
    }
}