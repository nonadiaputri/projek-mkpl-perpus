﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjekMKPL
{
    public partial class DaftarBuku : Form
    {

        tambahBuku formTambahBuku;
        EditBuku formEditBuku;

        public DaftarBuku()
        {
            InitializeComponent();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btTambahBuku_Click(object sender, EventArgs e)
        {
            tambahBuku tbk = new tambahBuku(this);
            tbk.Show();
            this.Hide();
        }

        private void btEditBuku_Click(object sender, EventArgs e)
        {
            EditBuku eb = new EditBuku();
            eb.Show();
            this.Hide();
        }
    }
}
