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
    public partial class FrmOgrListele : Form
    {
        public FrmOgrListele()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public void gridDoldur()
        {
            con = new SqlConnection("Data Source=DESKTOP-0UK1IES;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            da = new SqlDataAdapter("Select * From Ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ogrenci");
            dataGridView1.DataSource = ds.Tables["Ogrenci"];
            con.Close();
        }

        private void FrmOgrListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Ogrenci);

            gridDoldur();

            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[9].Width = 110;
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
    }
}
