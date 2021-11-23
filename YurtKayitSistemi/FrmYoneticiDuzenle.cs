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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        sqlBaglantim bgl = new sqlBaglantim();
        private void button1_Click(object sender, EventArgs e)
        {
            // Yönetici Ekleme
            try
            {
                SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtKullaniciSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet9.Admin);
                MessageBox.Show("Kayıt Eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Eklenemedi. !!!" + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  Yönetici Silme
            try
            {
                SqlCommand komut2 = new SqlCommand("Delete From Admin where Yoneticiid=@d1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@d1", txtYoneticiid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet9.Admin);
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Silinemedi !!!" + hata.Message);
            }
        }

        private void FrmYoneticiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet9.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet9.Admin);
            dataGridView1.Columns[0].Width = 65;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Yönetici Güncelleme.
            try
            {
                SqlCommand komut3 = new SqlCommand("update Admin set YoneticiAd=@u2,YoneticiSifre=@u3 where Yoneticiid=@u1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@u1", txtYoneticiid.Text);
                komut3.Parameters.AddWithValue("@u2", txtKullaniciAd.Text);
                komut3.Parameters.AddWithValue("@u3", txtKullaniciSifre.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet9.Admin);
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA Kayıt Güncellenemedi. !!!" + hata.Message);
            }
        }
        
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DatagridWiev e basılınca değerler textbox lara aktarılıyor.
            string id, KullaniciAd, KullaniciSifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            KullaniciAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            KullaniciSifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYoneticiid.Text = id;
            txtKullaniciAd.Text = KullaniciAd;
            txtKullaniciSifre.Text = KullaniciSifre;
        }
    }
}