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
    public partial class FrmAdminGirisi : Form
    {
        public FrmAdminGirisi()
        {
            InitializeComponent();
        }
        sqlBaglantim bgl = new sqlBaglantim();

        private void FrmAdminGirisi_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Admin Where YoneticiAd=@p1 AND YoneticiSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
                frmAnaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!'");
            }
        }
    }
}
