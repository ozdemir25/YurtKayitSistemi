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
    public partial class FrmYoneticiDuzenle : Form
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
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        sqlBaglantim bgl = new sqlBaglantim();

        // Yönetici Ekleme
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtKullaniciSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Eklenemedi. !!!" + hata.Message);
            }
        }

        //  Yönetici Silme
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("Delete From Admin where Yoneticiid=@d1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@d1", txtYoneticiid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Silinemedi !!!" + hata.Message);
            }
        }

        //dataGridViewe Verileri Getirir.
        private void YoneticiKayitGetir()
        {
            string kayit = "Select * From Admin";
            SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmYoneticiDuzenle_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_CENTER);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet9.Admin' table. You can move, or remove it, as needed.
            YoneticiKayitGetir();

            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 131;
            dataGridView1.Columns[2].Width = 131;
        }

        //Yönetici Güncelleme.
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut3 = new SqlCommand("update Admin set YoneticiAd=@u2,YoneticiSifre=@u3 where Yoneticiid=@u1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@u1", txtYoneticiid.Text);
                komut3.Parameters.AddWithValue("@u2", txtKullaniciAd.Text);
                komut3.Parameters.AddWithValue("@u3", txtKullaniciSifre.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Güncellenemedi. !!!" + hata.Message);
            }
        }

        //DatagridWiev e basılınca değerler textbox lara aktarılıyor.
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, KullaniciAd, KullaniciSifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            KullaniciAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            KullaniciSifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYoneticiid.Text = id;
            txtKullaniciAd.Text = KullaniciAd;
            txtKullaniciSifre.Text = KullaniciSifre;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //------------
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtKullaniciSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Eklenemedi. !!!" + hata.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("Delete From Admin where Yoneticiid=@d1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@d1", txtYoneticiid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Silinemedi !!!" + hata.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut3 = new SqlCommand("update Admin set YoneticiAd=@u2,YoneticiSifre=@u3 where Yoneticiid=@u1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@u1", txtYoneticiid.Text);
                komut3.Parameters.AddWithValue("@u2", txtKullaniciAd.Text);
                komut3.Parameters.AddWithValue("@u3", txtKullaniciSifre.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Güncellenemedi. !!!" + hata.Message);
            }
        }
    }
}
