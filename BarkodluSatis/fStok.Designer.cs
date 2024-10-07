namespace BarkodluSatis
{
    partial class fStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStok));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lKullanici = new BarkodluSatis.lSandart();
            this.bRaporAl = new BarkodluSatis.bStandart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.bAra = new BarkodluSatis.bStandart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.lSandart5 = new BarkodluSatis.lSandart();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lSandart4 = new BarkodluSatis.lSandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tUrunAra = new BarkodluSatis.tStandart();
            this.lSandart6 = new BarkodluSatis.lSandart();
            this.gridListe = new BarkodluSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1426, 694);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 0;
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(12, 9);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(85, 25);
            this.lKullanici.TabIndex = 4;
            this.lKullanici.Text = "Kullanıcı";
            // 
            // bRaporAl
            // 
            this.bRaporAl.BackColor = System.Drawing.Color.DodgerBlue;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRaporAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRaporAl.Image = global::BarkodluSatis.Properties.Resources.Excel321;
            this.bRaporAl.Location = new System.Drawing.Point(17, 603);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(117, 81);
            this.bRaporAl.TabIndex = 15;
            this.bRaporAl.Text = "Rapor Al";
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            this.bRaporAl.Click += new System.EventHandler(this.bRaporAl_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbIslemTuru);
            this.panel4.Controls.Add(this.lSandart1);
            this.panel4.Location = new System.Drawing.Point(12, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 100);
            this.panel4.TabIndex = 7;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(15, 46);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(313, 33);
            this.cmbIslemTuru.TabIndex = 0;
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(10, 18);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(104, 25);
            this.lSandart1.TabIndex = 1;
            this.lSandart1.Text = "İşlem Türü";
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.Tomato;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAra.Image = global::BarkodluSatis.Properties.Resources.ara2424;
            this.bAra.Location = new System.Drawing.Point(251, 548);
            this.bAra.Margin = new System.Windows.Forms.Padding(1);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(105, 73);
            this.bAra.TabIndex = 0;
            this.bAra.Text = "Ara";
            this.bAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateBitis);
            this.panel3.Controls.Add(this.lSandart5);
            this.panel3.Controls.Add(this.dateBaslangic);
            this.panel3.Controls.Add(this.lSandart4);
            this.panel3.Location = new System.Drawing.Point(12, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 182);
            this.panel3.TabIndex = 6;
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Location = new System.Drawing.Point(12, 141);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(316, 30);
            this.dateBitis.TabIndex = 9;
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart5.Location = new System.Drawing.Point(15, 101);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(102, 25);
            this.lSandart5.TabIndex = 8;
            this.lSandart5.Text = "Bitiş Tarihi";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(12, 49);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(316, 30);
            this.dateBaslangic.TabIndex = 7;
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart4.Location = new System.Drawing.Point(15, 21);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(151, 25);
            this.lSandart4.TabIndex = 7;
            this.lSandart4.Text = "Başlangıç Tarihi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lSandart3);
            this.panel2.Controls.Add(this.cmbUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(12, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 96);
            this.panel2.TabIndex = 5;
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart3.Location = new System.Drawing.Point(15, 6);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(113, 25);
            this.lSandart3.TabIndex = 3;
            this.lSandart3.Text = "Ürün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(20, 46);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(308, 33);
            this.cmbUrunGrubu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdUrunGrubunaGore);
            this.panel1.Controls.Add(this.lSandart2);
            this.panel1.Controls.Add(this.rdTumu);
            this.panel1.Location = new System.Drawing.Point(12, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 100);
            this.panel1.TabIndex = 3;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(34, 68);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(204, 29);
            this.rdUrunGrubunaGore.TabIndex = 1;
            this.rdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart2.Location = new System.Drawing.Point(7, 8);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(142, 25);
            this.lSandart2.TabIndex = 2;
            this.lSandart2.Text = "Filtreleme Türü";
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumu.Location = new System.Drawing.Point(34, 42);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(84, 29);
            this.rdTumu.TabIndex = 0;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lSandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(1051, 694);
            this.splitContainer2.SplitterDistance = 77;
            this.splitContainer2.TabIndex = 0;
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(111, 27);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(250, 30);
            this.tUrunAra.TabIndex = 3;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lSandart6
            // 
            this.lSandart6.AutoSize = true;
            this.lSandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart6.Location = new System.Drawing.Point(15, 30);
            this.lSandart6.Name = "lSandart6";
            this.lSandart6.Size = new System.Drawing.Size(90, 25);
            this.lSandart6.TabIndex = 2;
            this.lSandart6.Text = "Ürün Ara";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.gridListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridListe.RowTemplate.Height = 32;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(1051, 613);
            this.gridListe.TabIndex = 16;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1426, 694);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStok";
            this.Text = "Stok İzleme";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdUrunGrubunaGore;
        private lSandart lSandart2;
        private System.Windows.Forms.RadioButton rdTumu;
        private lSandart lSandart1;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private lSandart lSandart5;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private lSandart lSandart4;
        private System.Windows.Forms.Panel panel2;
        private lSandart lSandart3;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private bStandart bAra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private tStandart tUrunAra;
        private lSandart lSandart6;
        private gridOzel gridListe;
        private bStandart bRaporAl;
        internal lSandart lKullanici;
    }
}