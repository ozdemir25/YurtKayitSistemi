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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        sqlBaglantim bgl = new sqlBaglantim();

        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam tutarı gsterir.
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) From Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaParası.Text = oku[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //Tekrarsız olarak ayları getirir.
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) From Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAySecim.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


            //Grafik oluşturma (Veritabından çekme işlemi)
            SqlCommand komut3 = new SqlCommand("Select OdemeAy,sum(OdemeMiktar) From kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();


        }

        private void cmbAySecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("select sum(OdemeMiktar) From Kasa Where OdemeAy=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbAySecim.Text);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblSecilenAyParası.Text = oku3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
