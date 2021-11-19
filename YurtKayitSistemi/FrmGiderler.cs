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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlBaglantim bgl = new sqlBaglantim();

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler(Elektrik,Su,Dogalgaz,Internet,Gıda,Maaslar,Diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtInternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGıda.Text);
                komut.Parameters.AddWithValue("@p6", txtMaaslar.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Eklenemedi. ", hata.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmGiderDuzenle frmGiderDuzenle = new FrmGiderDuzenle();
            frmGiderDuzenle.Show();
        }
    }
}
