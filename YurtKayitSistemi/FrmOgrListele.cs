using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrListele : Form
    {
        public FrmOgrListele()
        {
            InitializeComponent();
        }

        private void FrmOgrListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Ogrenci);

            MessageBox.Show("Öğrenciyi Güncellemek için Öğrencinin üzerine tek tıklamanız yeterlidir.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ----------------------------------------------------------------------------------------------------------------------------
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.Tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.ogrTelefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.ogrDogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.ogrBolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.ogrMail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.ogrOdaNo = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.ogrVeliAdSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.ogrVeliTelefonNo = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.Adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();

            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
