using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------
        }

        // Odalar tablosunu DataGridView'e Çekiyoruz.
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public void AnaMenuGridDoldur()
        {
            con = new SqlConnection("Data Source=DESKTOP-0UK1IES;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("Select * From Odalar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Odalar");
            dataGridView1.DataSource = ds.Tables["Odalar"];
            con.Close();
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet1.Odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Odalar);
            timer1.Start();

            AnaMenuGridDoldur();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[4].Width = 427;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit frmKayit = new FrmOgrKayit();
            frmKayit.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frmBolum = new FrmBolumler();
            frmBolum.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListele frmListele = new FrmOgrListele();
            frmListele.Show();
        }

        private void öğrenciÖdemesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frmOdeme = new FrmOdemeler();
            frmOdeme.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------
        }

        private void gİDEREKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderler frmGider = new FrmGiderler();
            frmGider.Show();
        }

        private void giderListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderDuzenle frmGiderDuzenle = new FrmGiderDuzenle();
            frmGiderDuzenle.Show();
        }

        private void yöneticiEkleSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle frmYoneticiDuzenle = new FrmYoneticiDuzenle();
            frmYoneticiDuzenle.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik frmGelirIstatistik = new FrmGelirIstatistik();
            frmGelirIstatistik.Show();
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelDuzenle frmPersonelDuzenle = new FrmPersonelDuzenle();
            frmPersonelDuzenle.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Şafak Yılmaz ve Muhammet Özdemir tarafından hazırlanmıştır.");
        }
    }
}
