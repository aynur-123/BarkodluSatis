namespace BarkodluSatis
{
    partial class fGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGelirGider));
            this.bEkle = new BarkodluSatis.bStandart();
            this.lGelirGider = new BarkodluSatis.lSandart();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.tNakit = new BarkodluSatis.tNumeric();
            this.tKart = new BarkodluSatis.tNumeric();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.lSandart4 = new BarkodluSatis.lSandart();
            this.tAciklama = new BarkodluSatis.tStandart();
            this.lSandart5 = new BarkodluSatis.lSandart();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.lSandart6 = new BarkodluSatis.lSandart();
            this.SuspendLayout();
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle32;
            this.bEkle.Location = new System.Drawing.Point(234, 478);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(125, 65);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // lGelirGider
            // 
            this.lGelirGider.AutoSize = true;
            this.lGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGelirGider.ForeColor = System.Drawing.Color.DarkCyan;
            this.lGelirGider.Location = new System.Drawing.Point(38, 24);
            this.lGelirGider.Name = "lGelirGider";
            this.lGelirGider.Size = new System.Drawing.Size(134, 25);
            this.lGelirGider.TabIndex = 1;
            this.lGelirGider.Text = "GELİR GİDER";
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart2.Location = new System.Drawing.Point(38, 74);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(123, 25);
            this.lSandart2.TabIndex = 2;
            this.lSandart2.Text = "Ödeme Türü";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "NAKİT-KART"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(43, 102);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(313, 33);
            this.cmbOdemeTuru.TabIndex = 3;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // tNakit
            // 
            this.tNakit.BackColor = System.Drawing.Color.White;
            this.tNakit.Enabled = false;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNakit.Location = new System.Drawing.Point(43, 198);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(139, 30);
            this.tNakit.TabIndex = 4;
            this.tNakit.Text = "0";
            this.tNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tKart
            // 
            this.tKart.BackColor = System.Drawing.Color.White;
            this.tKart.Enabled = false;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKart.Location = new System.Drawing.Point(217, 198);
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(139, 30);
            this.tKart.TabIndex = 5;
            this.tKart.Text = "0";
            this.tKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart3.Location = new System.Drawing.Point(42, 170);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(56, 25);
            this.lSandart3.TabIndex = 6;
            this.lSandart3.Text = "Nakit";
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart4.Location = new System.Drawing.Point(212, 170);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(48, 25);
            this.lSandart4.TabIndex = 7;
            this.lSandart4.Text = "Kart";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(43, 268);
            this.tAciklama.Multiline = true;
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(313, 113);
            this.tAciklama.TabIndex = 8;
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart5.Location = new System.Drawing.Point(38, 240);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(92, 25);
            this.lSandart5.TabIndex = 9;
            this.lSandart5.Text = "Açıklama";
            // 
            // dateTarih
            // 
            this.dateTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Location = new System.Drawing.Point(43, 429);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(316, 30);
            this.dateTarih.TabIndex = 10;
            // 
            // lSandart6
            // 
            this.lSandart6.AutoSize = true;
            this.lSandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart6.Location = new System.Drawing.Point(42, 401);
            this.lSandart6.Name = "lSandart6";
            this.lSandart6.Size = new System.Drawing.Size(57, 25);
            this.lSandart6.TabIndex = 11;
            this.lSandart6.Text = "Tarih";
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 574);
            this.Controls.Add(this.lSandart6);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.lSandart5);
            this.Controls.Add(this.tAciklama);
            this.Controls.Add(this.lSandart4);
            this.Controls.Add(this.lSandart3);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lSandart2);
            this.Controls.Add(this.lGelirGider);
            this.Controls.Add(this.bEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(417, 621);
            this.Name = "fGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider İşlemleri";
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bStandart bEkle;
        private lSandart lGelirGider;
        private lSandart lSandart2;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private tNumeric tNakit;
        private tNumeric tKart;
        private lSandart lSandart3;
        private lSandart lSandart4;
        private tStandart tAciklama;
        private lSandart lSandart5;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private lSandart lSandart6;
    }
}