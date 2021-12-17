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
    public partial class FrmOdemeler : Form
    {
        sqlBaglantim bgl = new sqlBaglantim();

        public FrmOdemeler()
        {
            InitializeComponent();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);
            dataGridView1.Columns[0].Width = 80;
            btnYazdır.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtOgrenciid.Text = id;
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalanBorc.Text = kalan;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Ödenen miktarı kalan miktardan düşürme.
            int odenen, kalan, yeniBorc;
            odenen = Convert.ToInt32(txtOdenenTutar.Text);
            kalan = Convert.ToInt32(txtKalanBorc.Text);
            yeniBorc = kalan - odenen;
            txtKalanBorc.Text = yeniBorc.ToString();

            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrenciid.Text);
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(odenen + " TL Ödendi.");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

            //Kasa tablosuna ekleme işlemi.
            SqlCommand komut2 = new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar) values(@A1,@A2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@A1", cmbOdemeAy.Text);
            komut2.Parameters.AddWithValue("@A2", txtOdenenTutar.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            /*-----------------------------*/
        }
        /*Yazdırma İlemi Yapar.................................................................................................................................*/
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i, j, x, y;
            y = 30;
            for (j = 0; j <=dataGridView1.Rows.Count-2; j++)
            {
                x = 30;
                for (i = 0; i <= 3; i++) 
                {
                    e.Graphics.DrawString(dataGridView1.Rows[j].Cells[i].Value.ToString(), new Font("Times New Roman", 10), Brushes.Black, x, y);
                    x = x + 80;
                }
                y = y + 30;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        /*......................................................................................................................................................*/
    }
}
