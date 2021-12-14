﻿using System;
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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        sqlBaglantim bgl = new sqlBaglantim();

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            //Hataları engellemeye yönelik olarak, tüm veritabanı işlemlerini try-catch blokları arasında Kullandık.
            try
            {
                if (bgl.baglanti().State==ConnectionState.Closed)
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    bgl.baglanti().Open();
                string kayit = "insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@OgrAd,@OgrSoyad,@OgrTC,@OgrTelefon,@OgrDogum,@OgrBolum,@OgrMail,@OgrOdaNo,@OgrVeliAdSoyad,@OgrVeliTelefon,@OgrVeliAdres)";
                // Ogrenci tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut3 = new SqlCommand(kayit, bgl.baglanti());
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut3.Parameters.AddWithValue("@OgrAd", txtOgrAdi.Text);
                komut3.Parameters.AddWithValue("@OgrSoyad", txtOgrSoyadi.Text);
                komut3.Parameters.AddWithValue("@OgrTC", mskOgrTC.Text);
                komut3.Parameters.AddWithValue("@OgrTelefon", mskOgrTelefon.Text);
                komut3.Parameters.AddWithValue("@OgrDogum", mskOgrDogumTarihi.Text);
                komut3.Parameters.AddWithValue("@OgrBolum", cmbOgrBolum.Text);
                komut3.Parameters.AddWithValue("@OgrMail", txtOgrMail.Text);
                komut3.Parameters.AddWithValue("@OgrOdaNo", cmbOdaNo.Text);
                komut3.Parameters.AddWithValue("@OgrVeliAdSoyad", txtOgrVeliAdiSoyadi.Text);
                komut3.Parameters.AddWithValue("@OgrVeliTelefon", mskOgrVeliTelefonNo.Text);
                komut3.Parameters.AddWithValue("@OgrVeliAdres", richTextBox1.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut3.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Tamamlandı.");

                // Öğrenci İd yi labele e çekiyoruz.
                SqlCommand commant = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = commant.ExecuteReader();
                while (oku.Read())
                {
                    label13.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //Öğrenci kaydı yapıldığında aynı anda borçlar tablosuna da ekleme yapılsın...
                SqlCommand komut4 = new SqlCommand("insert into Borclar(Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komut4.Parameters.AddWithValue("@b1", label13.Text);
                komut4.Parameters.AddWithValue("@b2", txtOgrAdi.Text);
                komut4.Parameters.AddWithValue("@b3", txtOgrSoyadi.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Kayıt Sırasında Bir Hata Oldu" + Hata.Message);
            }

            // Öğrenci Oda girişinde oda dolu gözüksün.
            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutOda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutOda.ExecuteNonQuery();
            FrmAnaMenu frmAnaMenu = (FrmAnaMenu)Application.OpenForms["FrmAnaMenu"];
            frmAnaMenu.AnaMenuGridDoldur();
            bgl.baglanti().Close();
        }

        private void FrmOgrKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            //-----------------
        }
    }
}
// Data Source=DESKTOP-0UK1IES;Initial Catalog=YurtOtomasyonu;Integrated Security=True