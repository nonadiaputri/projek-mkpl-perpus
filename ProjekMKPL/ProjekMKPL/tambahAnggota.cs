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
    public partial class tambahAnggota : Form
    {
        DaftarAnggota formParent;
        public tambahAnggota(DaftarAnggota parent)
        {
            InitializeComponent();
            this.formParent = parent;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            DaftarAnggota da = new DaftarAnggota();
            da.Show();
            this.Hide();
        }

        private void tambahAnggota_Load(object sender, EventArgs e)
        {

        }
    }

}