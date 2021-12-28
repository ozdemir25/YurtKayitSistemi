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
    public partial class FrmBolumler : Form
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
        public FrmBolumler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        sqlBaglantim bgl = new sqlBaglantim();
        //static string conString = @"Data Source=DESKTOP-0UK1IES;Initial Catalog=YurtOtomasyonu;Integrated Security=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        //SqlConnection baglanti = new SqlConnection(conString);


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Güncelleme İşlemi Yapılan Alan
            try
            {
                SqlCommand komut2 = new SqlCommand("update Bolumler Set BolumAd=@BolumAd where BolumId=@BolumId", bgl.baglanti());
                komut2.Parameters.AddWithValue("BolumId", txtBolumId.Text);
                komut2.Parameters.AddWithValue("BolumAd", txtBolumAdi.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Göncellendi.");
                BolumlerKayitGetir();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Güncelleme İptal Edildi." + Hata.Message);
            }
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_CENTER);
            BolumlerKayitGetir();
            dataGridView1.Columns[1].Width = 340;
        }
        private void BolumlerKayitGetir()
        {
            //Bölümler Tablosundaki verileri getirir.
            string kayit = "Select * From Bolumler";
            SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Bölüm Ekleme İşlemi
            try
            {
                if (bgl.baglanti().State == ConnectionState.Closed)
                    bgl.baglanti().Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into Bolumler(BolumAd) values (@BolumAdi)";
                // Ogrenci tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut3 = new SqlCommand(kayit, bgl.baglanti());
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut3.Parameters.AddWithValue("@BolumAdi", txtBolumAdi.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut3.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Tamamlandı.");
                BolumlerKayitGetir();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Sırasında Bir Hata Oldu" + hata.Message);
            }
        }
        int secilen_deger;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Bölüm Silme İşlemi
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumId=@BolumId", bgl.baglanti());
                komut2.Parameters.AddWithValue("BolumId", txtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt  Silindi.");
                //Bölüm Silindikten sonra verilerin güncellenmesi için yeniden verileri çağırıyoruz.
                BolumlerKayitGetir();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Kayıt Sırasında Hata oluştu." + Hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1 deki alana tıkladığın zaman id ve bölüm adı textbox larda gözükür.

            string id, bolumAd;
            secilen_deger = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen_deger].Cells[0].Value.ToString();
            bolumAd = dataGridView1.Rows[secilen_deger].Cells[1].Value.ToString();

            txtBolumId.Text = id;
            txtBolumAdi.Text = bolumAd;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
