namespace BarkodluSatis
{
    partial class fUrunGrubuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGrubuEkle));
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.tUrunGrupAd = new BarkodluSatis.tStandart();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.bSil = new BarkodluSatis.bStandart();
            this.bEkle = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(21, 26);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(147, 25);
            this.lSandart1.TabIndex = 0;
            this.lSandart1.Text = "Ürün Grubu Adı";
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(26, 54);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(250, 30);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 25;
            this.listUrunGrup.Location = new System.Drawing.Point(26, 90);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(250, 254);
            this.listUrunGrup.TabIndex = 2;
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.DarkRed;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSil.Image = global::BarkodluSatis.Properties.Resources.clear4848;
            this.bSil.Location = new System.Drawing.Point(26, 348);
            this.bSil.Margin = new System.Windows.Forms.Padding(1);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(124, 68);
            this.bSil.TabIndex = 3;
            this.bSil.Text = "Sil";
            this.bSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle20;
            this.bEkle.Location = new System.Drawing.Point(152, 348);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(124, 68);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 433);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lSandart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lSandart lSandart1;
        private tStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private bStandart bEkle;
        private bStandart bSil;
    }
}