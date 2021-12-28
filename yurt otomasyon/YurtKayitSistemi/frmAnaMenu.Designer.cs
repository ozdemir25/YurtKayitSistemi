
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
            this.bÖLÜMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciÖdemesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİDERLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİDEREKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSTATİSTİKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yÖNETİCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiEkleSilGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
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
            this.raporOluşturmaToolStripMenuItem,
            this.yÖNETİCİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öĞRENCİLERToolStripMenuItem
            // 
            this.öĞRENCİLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem});
            this.öĞRENCİLERToolStripMenuItem.Name = "öĞRENCİLERToolStripMenuItem";
            this.öĞRENCİLERToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.öĞRENCİLERToolStripMenuItem.Text = "ÖĞRENCİLER";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(346, 28);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(346, 28);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi ve Düzenle";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // bÖLÜMLERToolStripMenuItem
            // 
            this.bÖLÜMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem});
            this.bÖLÜMLERToolStripMenuItem.Name = "bÖLÜMLERToolStripMenuItem";
            this.bÖLÜMLERToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.bÖLÜMLERToolStripMenuItem.Text = "BÖLÜMLER";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(330, 28);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle, Sil, Güncelle";
            this.bölümEkleToolStripMenuItem.Click += new System.EventHandler(this.bölümEkleToolStripMenuItem_Click);
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
            this.gİDEREKLEToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.gİDEREKLEToolStripMenuItem.Text = "Gider Ekle";
            this.gİDEREKLEToolStripMenuItem.Click += new System.EventHandler(this.gİDEREKLEToolStripMenuItem_Click);
            // 
            // giderListeleToolStripMenuItem
            // 
            this.giderListeleToolStripMenuItem.Name = "giderListeleToolStripMenuItem";
            this.giderListeleToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.giderListeleToolStripMenuItem.Text = "Gider Düzenleme";
            this.giderListeleToolStripMenuItem.Click += new System.EventHandler(this.giderListeleToolStripMenuItem_Click);
            // 
            // iSTATİSTİKLERToolStripMenuItem
            // 
            this.iSTATİSTİKLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem});
            this.iSTATİSTİKLERToolStripMenuItem.Name = "iSTATİSTİKLERToolStripMenuItem";
            this.iSTATİSTİKLERToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.iSTATİSTİKLERToolStripMenuItem.Text = "İSTATİSTİKLER";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            this.gelirİstatistikleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİstatistikleriToolStripMenuItem_Click);
            // 
            // raporOluşturmaToolStripMenuItem
            // 
            this.raporOluşturmaToolStripMenuItem.Name = "raporOluşturmaToolStripMenuItem";
            this.raporOluşturmaToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.raporOluşturmaToolStripMenuItem.Text = "RAPOR OLUŞTURMA";
            this.raporOluşturmaToolStripMenuItem.Click += new System.EventHandler(this.raporOluşturmaToolStripMenuItem_Click);
            // 
            // yÖNETİCİToolStripMenuItem
            // 
            this.yÖNETİCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiEkleSilGüncelleToolStripMenuItem,
            this.personelDüzenlemeToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.yÖNETİCİToolStripMenuItem.Name = "yÖNETİCİToolStripMenuItem";
            this.yÖNETİCİToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.yÖNETİCİToolStripMenuItem.Text = "YÖNETİCİ";
            // 
            // yöneticiEkleSilGüncelleToolStripMenuItem
            // 
            this.yöneticiEkleSilGüncelleToolStripMenuItem.Name = "yöneticiEkleSilGüncelleToolStripMenuItem";
            this.yöneticiEkleSilGüncelleToolStripMenuItem.Size = new System.Drawing.Size(346, 28);
            this.yöneticiEkleSilGüncelleToolStripMenuItem.Text = "Yönetici Ekle, Sil, Güncelle";
            this.yöneticiEkleSilGüncelleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleSilGüncelleToolStripMenuItem_Click);
            // 
            // personelDüzenlemeToolStripMenuItem
            // 
            this.personelDüzenlemeToolStripMenuItem.Name = "personelDüzenlemeToolStripMenuItem";
            this.personelDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(346, 28);
            this.personelDüzenlemeToolStripMenuItem.Text = "Personel Düzenleme";
            this.personelDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenlemeToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(346, 28);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(346, 28);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1250, 142);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 395);
            this.dataGridView1.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.lblSaat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(945, 572);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(31, 33);
            this.lblSaat.TabIndex = 29;
            this.lblSaat.Text = "..";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.lblTarih.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(858, 604);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 33);
            this.lblTarih.TabIndex = 30;
            this.lblTarih.Text = "...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1194, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1250, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciÖdemesiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem gİDERLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİDEREKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSTATİSTİKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yÖNETİCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleSilGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporOluşturmaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}