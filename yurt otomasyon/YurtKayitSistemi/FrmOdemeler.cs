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
using System.Runtime.InteropServices;

namespace YurtKayitSistemi
{
    public partial class FrmOdemeler : Form
    {
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }
        sqlBaglantim bgl = new sqlBaglantim();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public FrmOdemeler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_CENTER);
            btnYazdır.Visible = false;
            odemelerKayıtGetir();
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
        }

        //dataGridViewe verileri getirir.
        private void odemelerKayıtGetir()
        {
            //Bölümler Tablosundaki verileri getirir.
            string kayit = "Select * From Borclar";
            SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

            //Kasa tablosuna ekleme işlemi.
            SqlCommand komut2 = new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar) values(@A1,@A2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@A1", cmbOdemeAy.Text);
            komut2.Parameters.AddWithValue("@A2", txtOdenenTutar.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        /*......................................................................................................................................................*/
    }
}
