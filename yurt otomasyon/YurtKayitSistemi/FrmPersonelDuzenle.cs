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
    public partial class FrmPersonelDuzenle : Form
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
        public FrmPersonelDuzenle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_CENTER);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet10.Personel' table. You can move, or remove it, as needed.
            PersonelKayıtGetir();   
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 146;
        }

        //dataGridViewe Personel Kayıt Getirir.
        private void PersonelKayıtGetir()
        {
            //Bölümler Tablosundaki verileri getirir.
            string kayit = "Select * From Personel";
            SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kayıt Ekleme.
            try
            {
                SqlCommand komut = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPersonelDepaetman.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Eklenemedi. !!!"+ ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Yönetici Güncelleme.
            try
            {
                SqlCommand komut2 = new SqlCommand("update Personel set PersonelAdSoyad=@g2,PersonelDepartman=@g3 where PersonelId=@g1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@g1", txtPersonelid.Text);
                komut2.Parameters.AddWithValue("@g2", txtPersonelAd.Text);
                komut2.Parameters.AddWithValue("@g3", txtPersonelDepaetman.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Güncellenemedi. !!!" + ex.Message);
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DatagridView'e tıklandığında değerleri textBox'a atar.
            string id, personelAdSoyad, PersonelDepartman;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            personelAdSoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            PersonelDepartman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersonelid.Text = id;
            txtPersonelAd.Text = personelAdSoyad;
            txtPersonelDepaetman.Text = PersonelDepartman;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //  Yönetici Silme
            try
            {
                SqlCommand komut2 = new SqlCommand("Delete From Personel where PersonelId=@s1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@s1", txtPersonelid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Silinemedi !!!" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //  Yönetici Silme
            try
            {
                SqlCommand komut2 = new SqlCommand("Delete From Personel where PersonelId=@s1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@s1", txtPersonelid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Silinemedi !!!" + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Yönetici Güncelleme.
            try
            {
                SqlCommand komut2 = new SqlCommand("update Personel set PersonelAdSoyad=@g2,PersonelDepartman=@g3 where PersonelId=@g1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@g1", txtPersonelid.Text);
                komut2.Parameters.AddWithValue("@g2", txtPersonelAd.Text);
                komut2.Parameters.AddWithValue("@g3", txtPersonelDepaetman.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Güncellenemedi. !!!" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Kayıt Ekleme.
            try
            {
                SqlCommand komut = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPersonelDepaetman.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Eklenemedi. !!!" + ex.Message);
            }
        }
    }
}
