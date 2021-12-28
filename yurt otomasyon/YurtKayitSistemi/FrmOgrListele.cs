using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace YurtKayitSistemi
{
    public partial class FrmOgrListele : Form
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
        public FrmOgrListele()
        {
            InitializeComponent();
          
        }
        sqlBaglantim bgl = new sqlBaglantim();

        //dataGridView verileri getirir.
        public void OgrenciKayıtGetir()
        {
            //Bölümler Tablosundaki verileri getirir.
            string kayit = "Select * From Ogrenci";
            SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmOgrListele_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_CENTER);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Ogrenci' table. You can move, or remove it, as needed.
            OgrenciKayıtGetir();

            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[9].Width = 90;
            dataGridView1.Columns[10].Width = 130;
            dataGridView1.Columns[11].Width = 222;
            MessageBox.Show("Öğrenciyi GÜNCELLEMEK veya SİLMEK için Öğrencinin üzerine tek tıklamanız yeterlidir.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //----------------
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
            //----------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
