using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjekMKPL
{
    public partial class DaftarAnggota : Form
    {
        public DaftarAnggota()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void buttonTambahAnggota_Click(object sender, EventArgs e)
        {
            tambahAnggota tang = new tambahAnggota(this);
            tang.Show();
            this.Hide();
        }
    }
}
