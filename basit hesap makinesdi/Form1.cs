﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basit_hesap_makinesdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayı1, sayi2;
            double sonuc;

            sayı1 = Convert.ToInt32(txtSayı1.Text);
            sayi2 = Convert.ToInt32(txtSayı2.Text);

            sonuc = sayı1 * sayi2;

            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {

        }

        private void btnToplam_Click(object sender, EventArgs e)
        {

        }
    } 
}