
namespace YurtKayitSistemi
{
    partial class FrmGiderDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderDuzenle));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınternetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maaslarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet4 = new YurtKayitSistemi.YurtOtomasyonuDataSet4();
            this.giderlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet4TableAdapters.GiderlerTableAdapter();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGıda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDogalgaz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaaslar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOdemeid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 538);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1229, 142);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeidDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.ınternetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.maaslarDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 302);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odemeidDataGridViewTextBoxColumn
            // 
            this.odemeidDataGridViewTextBoxColumn.DataPropertyName = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.HeaderText = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeidDataGridViewTextBoxColumn.Name = "odemeidDataGridViewTextBoxColumn";
            this.odemeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            this.elektrikDataGridViewTextBoxColumn.Width = 125;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            this.dogalgazDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınternetDataGridViewTextBoxColumn
            // 
            this.ınternetDataGridViewTextBoxColumn.DataPropertyName = "Internet";
            this.ınternetDataGridViewTextBoxColumn.HeaderText = "Internet";
            this.ınternetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınternetDataGridViewTextBoxColumn.Name = "ınternetDataGridViewTextBoxColumn";
            this.ınternetDataGridViewTextBoxColumn.Width = 125;
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            this.gıdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // maaslarDataGridViewTextBoxColumn
            // 
            this.maaslarDataGridViewTextBoxColumn.DataPropertyName = "Maaslar";
            this.maaslarDataGridViewTextBoxColumn.HeaderText = "Maaslar";
            this.maaslarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maaslarDataGridViewTextBoxColumn.Name = "maaslarDataGridViewTextBoxColumn";
            this.maaslarDataGridViewTextBoxColumn.Width = 125;
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            this.giderlerBindingSource.DataSource = this.yurtOtomasyonuDataSet4;
            // 
            // yurtOtomasyonuDataSet4
            // 
            this.yurtOtomasyonuDataSet4.DataSetName = "YurtOtomasyonuDataSet4";
            this.yurtOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtElektrik.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElektrik.Location = new System.Drawing.Point(132, 392);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(282, 30);
            this.txtElektrik.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Elektrik :";
            // 
            // txtGıda
            // 
            this.txtGıda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGıda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGıda.Location = new System.Drawing.Point(546, 386);
            this.txtGıda.Name = "txtGıda";
            this.txtGıda.Size = new System.Drawing.Size(282, 30);
            this.txtGıda.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(463, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Gıda :";
            // 
            // txtDogalgaz
            // 
            this.txtDogalgaz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDogalgaz.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogalgaz.Location = new System.Drawing.Point(132, 483);
            this.txtDogalgaz.Name = "txtDogalgaz";
            this.txtDogalgaz.Size = new System.Drawing.Size(282, 30);
            this.txtDogalgaz.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Doğalgaz :";
            // 
            // txtMaaslar
            // 
            this.txtMaaslar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaaslar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaaslar.Location = new System.Drawing.Point(546, 433);
            this.txtMaaslar.Name = "txtMaaslar";
            this.txtMaaslar.Size = new System.Drawing.Size(282, 30);
            this.txtMaaslar.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(442, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Maaşlar :";
            // 
            // txtInternet
            // 
            this.txtInternet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInternet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInternet.Location = new System.Drawing.Point(546, 339);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(282, 30);
            this.txtInternet.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(442, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "İnternet :";
            // 
            // txtSu
            // 
            this.txtSu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSu.Location = new System.Drawing.Point(132, 436);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(282, 30);
            this.txtSu.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Su :";
            // 
            // txtDiger
            // 
            this.txtDiger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiger.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDiger.Location = new System.Drawing.Point(546, 485);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(282, 30);
            this.txtDiger.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(458, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Diğer :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(946, 351);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 50);
            this.btnKaydet.TabIndex = 51;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(946, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 50);
            this.button1.TabIndex = 52;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOdemeid
            // 
            this.txtOdemeid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOdemeid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeid.Location = new System.Drawing.Point(132, 345);
            this.txtOdemeid.Name = "txtOdemeid";
            this.txtOdemeid.Size = new System.Drawing.Size(282, 30);
            this.txtOdemeid.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ödeme id :";
            // 
            // FrmGiderDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1229, 680);
            this.Controls.Add(this.txtOdemeid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtDiger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaaslar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInternet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGıda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDogalgaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtElektrik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiderDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Düzenleme";
            this.Load += new System.EventHandler(this.FrmGiderDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet4 yurtOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private YurtOtomasyonuDataSet4TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınternetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maaslarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGıda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDogalgaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaaslar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOdemeid;
        private System.Windows.Forms.Label label8;
    }
}