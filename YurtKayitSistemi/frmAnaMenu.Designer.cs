
namespace YurtKayitSistemi
{
    partial class FrmAnaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öĞRENCİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciÖdemesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİDERLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİDEREKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSTATİSTİKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yÖNETİCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaAktifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet1 = new YurtKayitSistemi.YurtOtomasyonuDataSet1();
            this.odalarTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet1TableAdapters.OdalarTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİLERToolStripMenuItem,
            this.bÖLÜMLERToolStripMenuItem,
            this.ödemeToolStripMenuItem,
            this.gİDERLERToolStripMenuItem,
            this.iSTATİSTİKLERToolStripMenuItem,
            this.yÖNETİCİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öĞRENCİLERToolStripMenuItem
            // 
            this.öĞRENCİLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem,
            this.öğrenciDüzenleToolStripMenuItem});
            this.öĞRENCİLERToolStripMenuItem.Name = "öĞRENCİLERToolStripMenuItem";
            this.öĞRENCİLERToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.öĞRENCİLERToolStripMenuItem.Text = "ÖĞRENCİLER";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci Düzenle";
            // 
            // bÖLÜMLERToolStripMenuItem
            // 
            this.bÖLÜMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenleToolStripMenuItem});
            this.bÖLÜMLERToolStripMenuItem.Name = "bÖLÜMLERToolStripMenuItem";
            this.bÖLÜMLERToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.bÖLÜMLERToolStripMenuItem.Text = "BÖLÜMLER";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            this.bölümEkleToolStripMenuItem.Click += new System.EventHandler(this.bölümEkleToolStripMenuItem_Click);
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciÖdemesiToolStripMenuItem});
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.ödemeToolStripMenuItem.Text = "ÖDEMELER";
            this.ödemeToolStripMenuItem.Click += new System.EventHandler(this.ödemeToolStripMenuItem_Click);
            // 
            // öğrenciÖdemesiToolStripMenuItem
            // 
            this.öğrenciÖdemesiToolStripMenuItem.Name = "öğrenciÖdemesiToolStripMenuItem";
            this.öğrenciÖdemesiToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.öğrenciÖdemesiToolStripMenuItem.Text = "Öğrenci Ödemesi";
            this.öğrenciÖdemesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciÖdemesiToolStripMenuItem_Click);
            // 
            // gİDERLERToolStripMenuItem
            // 
            this.gİDERLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gİDEREKLEToolStripMenuItem,
            this.giderListeleToolStripMenuItem});
            this.gİDERLERToolStripMenuItem.Name = "gİDERLERToolStripMenuItem";
            this.gİDERLERToolStripMenuItem.Size = new System.Drawing.Size(125, 28);
            this.gİDERLERToolStripMenuItem.Text = "GİDERLER";
            // 
            // gİDEREKLEToolStripMenuItem
            // 
            this.gİDEREKLEToolStripMenuItem.Name = "gİDEREKLEToolStripMenuItem";
            this.gİDEREKLEToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.gİDEREKLEToolStripMenuItem.Text = "Gider Ekle";
            // 
            // giderListeleToolStripMenuItem
            // 
            this.giderListeleToolStripMenuItem.Name = "giderListeleToolStripMenuItem";
            this.giderListeleToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.giderListeleToolStripMenuItem.Text = "Gider Listele";
            // 
            // iSTATİSTİKLERToolStripMenuItem
            // 
            this.iSTATİSTİKLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem,
            this.giderİstatistikleriToolStripMenuItem});
            this.iSTATİSTİKLERToolStripMenuItem.Name = "iSTATİSTİKLERToolStripMenuItem";
            this.iSTATİSTİKLERToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.iSTATİSTİKLERToolStripMenuItem.Text = "İSTATİSTİKLER";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            // 
            // giderİstatistikleriToolStripMenuItem
            // 
            this.giderİstatistikleriToolStripMenuItem.Name = "giderİstatistikleriToolStripMenuItem";
            this.giderİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.giderİstatistikleriToolStripMenuItem.Text = "Gider İstatistikleri";
            // 
            // yÖNETİCİToolStripMenuItem
            // 
            this.yÖNETİCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.personelDüzenlemeToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.yÖNETİCİToolStripMenuItem.Name = "yÖNETİCİToolStripMenuItem";
            this.yÖNETİCİToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.yÖNETİCİToolStripMenuItem.Text = "YÖNETİCİ";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            // 
            // personelDüzenlemeToolStripMenuItem
            // 
            this.personelDüzenlemeToolStripMenuItem.Name = "personelDüzenlemeToolStripMenuItem";
            this.personelDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.personelDüzenlemeToolStripMenuItem.Text = "Personel Düzenleme";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1172, 142);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaIdDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn,
            this.odaKapasiteDataGridViewTextBoxColumn,
            this.odaAktifDataGridViewTextBoxColumn,
            this.odaDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.odalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 395);
            this.dataGridView1.TabIndex = 28;
            // 
            // odaIdDataGridViewTextBoxColumn
            // 
            this.odaIdDataGridViewTextBoxColumn.DataPropertyName = "OdaId";
            this.odaIdDataGridViewTextBoxColumn.HeaderText = "OdaId";
            this.odaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaIdDataGridViewTextBoxColumn.Name = "odaIdDataGridViewTextBoxColumn";
            this.odaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaKapasiteDataGridViewTextBoxColumn
            // 
            this.odaKapasiteDataGridViewTextBoxColumn.DataPropertyName = "OdaKapasite";
            this.odaKapasiteDataGridViewTextBoxColumn.HeaderText = "OdaKapasite";
            this.odaKapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaKapasiteDataGridViewTextBoxColumn.Name = "odaKapasiteDataGridViewTextBoxColumn";
            this.odaKapasiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaAktifDataGridViewTextBoxColumn
            // 
            this.odaAktifDataGridViewTextBoxColumn.DataPropertyName = "OdaAktif";
            this.odaAktifDataGridViewTextBoxColumn.HeaderText = "OdaAktif";
            this.odaAktifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaAktifDataGridViewTextBoxColumn.Name = "odaAktifDataGridViewTextBoxColumn";
            this.odaAktifDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaDurumDataGridViewCheckBoxColumn
            // 
            this.odaDurumDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.odaDurumDataGridViewCheckBoxColumn.DataPropertyName = "OdaDurum";
            this.odaDurumDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.odaDurumDataGridViewCheckBoxColumn.HeaderText = "OdaDurum";
            this.odaDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odaDurumDataGridViewCheckBoxColumn.Name = "odaDurumDataGridViewCheckBoxColumn";
            this.odaDurumDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.yurtOtomasyonuDataSet1;
            // 
            // yurtOtomasyonuDataSet1
            // 
            this.yurtOtomasyonuDataSet1.DataSetName = "YurtOtomasyonuDataSet1";
            this.yurtOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblSaat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(872, 573);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(31, 33);
            this.lblSaat.TabIndex = 29;
            this.lblSaat.Text = "..";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTarih.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(785, 605);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 33);
            this.lblTarih.TabIndex = 30;
            this.lblTarih.Text = "...";
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1172, 678);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciÖdemesiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem gİDERLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİDEREKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSTATİSTİKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yÖNETİCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet1 yurtOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private YurtOtomasyonuDataSet1TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaAktifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odaDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
    }
}