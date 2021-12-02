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
    public partial class FrmPersonelDuzenle : Form
    {
        sqlBaglantim bgl = new sqlBaglantim();

        public FrmPersonelDuzenle()
        {
            InitializeComponent();
        }

        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet10.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet10.Personel);
            dataGridView1.Columns[0].Width = 60;
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
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet10.Personel);
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
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet10.Personel);
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
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet10.Personel);
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Kayıt Silinemedi !!!" + ex.Message);
            }
        }
    }
}
