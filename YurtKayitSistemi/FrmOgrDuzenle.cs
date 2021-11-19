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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, Tc, ogrTelefon, ogrDogum, ogrBolum, ogrMail;
        public string ogrOdaNo, ogrVeliAdSoyad, ogrVeliTelefonNo, Adres;

        sqlBaglantim bgl = new sqlBaglantim();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5, OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAdi.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyadi.Text);
                komut.Parameters.AddWithValue("@p4", mskOgrTC.Text);
                komut.Parameters.AddWithValue("@p5", mskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskOgrDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p7", cmbOgrBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtOgrVeliAdiSoyadi.Text);
                komut.Parameters.AddWithValue("@p11", mskOgrVeliTelefonNo.Text);
                komut.Parameters.AddWithValue("@p12", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncelledi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Sırasında Hata Oluştu. ", hata.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            // Verileri  Düzenleme Formuna atma.
            label2.Text = id;
            txtOgrid.Text = id;
            txtOgrAdi.Text = ad;
            txtOgrSoyadi.Text = soyad;
            mskOgrTC.Text = Tc;
            mskOgrTelefon.Text = ogrTelefon;
            mskOgrDogumTarihi.Text = ogrDogum;
            cmbOgrBolum.Text = ogrBolum;
            txtOgrMail.Text = ogrMail;
            cmbOdaNo.Text = ogrOdaNo;
            txtOgrVeliAdiSoyadi.Text = ogrVeliAdSoyad;
            mskOgrVeliTelefonNo.Text = ogrVeliTelefonNo;
            richTextBox1.Text = Adres;

            //----------------------------------------------
            label2.Visible = false;

            //Bölümleri listeleme  komutları.
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            // Boş odaların listelenmesi komutu.
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void txtOgrid_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
