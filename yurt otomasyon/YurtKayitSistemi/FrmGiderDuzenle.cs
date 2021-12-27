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
    public partial class FrmGiderDuzenle : Form
    {
        public FrmGiderDuzenle()
        {
            InitializeComponent();
        }
        sqlBaglantim bgl =new sqlBaglantim();

        //DatagridViev verileri getrme işlemi.
        private void bolumlerGetir()
        {
            String kayit = "Select * From Giderler";
            SqlCommand kmtGetir = new SqlCommand(kayit, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(kmtGetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }      

        private void FrmGiderDuzenle_Load(object sender, EventArgs e)
        {
       
            bolumlerGetir();
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[7].Width = 158;
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Güncelleme İşlemi Gerçekleştirir.
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p2,Su=@p3,Dogalgaz=@p4,Internet=@p5,Gıda=@p6,Maaslar=@p7,Diger=@p8 where Odemeid=@p1 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOdemeid.Text);
                komut.Parameters.AddWithValue("@p2", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p3", txtSu.Text);
                komut.Parameters.AddWithValue("@p4", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p5", txtInternet.Text);
                komut.Parameters.AddWithValue("@p6", txtGıda.Text);
                komut.Parameters.AddWithValue("@p7", txtMaaslar.Text);
                komut.Parameters.AddWithValue("@p8", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi. ");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Güncellenemedi. ",hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            //DataGridView'e tıklandığında değerler textBoox'lara aktarılır.

            string id, elektrik, su, dogalgaz, ınternet, gıda, maaslar, diger;

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ınternet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            gıda = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            maaslar = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            txtOdemeid.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtInternet.Text = ınternet;
            txtGıda.Text = gıda;
            txtMaaslar.Text = maaslar;
            txtDiger.Text = diger;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Silme İşlemi Gerçekleştirir.
                SqlCommand komut2 = new SqlCommand("delete from Giderler where Odemeid=@b1",bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", txtOdemeid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi !!!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt silinemedi.", hata.Message);
            }
        }

        /*Yazdırma İlemi Yapar.................................................................................................................................*/
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i, j, x, y;
            y = 30;
            for (j = 0; j <=dataGridView1.Rows.Count-2 ; j++)
            {
                x = 30;
                for (i = 0; i <= 7; i++) 
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /*......................................................................................................................................................*/

    }
}
