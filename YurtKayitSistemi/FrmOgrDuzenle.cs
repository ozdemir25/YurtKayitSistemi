﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id;
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            label2.Text = id;
        }
    }
}
