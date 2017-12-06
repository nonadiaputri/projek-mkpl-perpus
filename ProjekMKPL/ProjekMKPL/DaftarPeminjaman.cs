using MySql.Data.MySqlClient;
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
    public partial class DaftarPeminjaman : Form
    {
        public DaftarPeminjaman()
        {
            InitializeComponent();
            this.refresh_data_peminjaman();
        }

        public MySqlConnection makeDatabaseConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            String connString =
                "Server=127.0.0.1;" +
                "uid=root;" +
                "pwd=;" +
                "database=perpus";

            connection.ConnectionString = connString;

            return connection;
        }

        public void refresh_data_peminjaman()
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql =
                    "SELECT peminjaman.ID_PEMINJAMAN, anggota.NAMA, buku.JUDUL, peminjaman.status "+
                    "FROM anggota "+
                        "INNER JOIN peminjaman ON anggota.ID_ANGGOTA = peminjaman.PID_ANGGOTA "+
                        "INNER JOIN buku ON peminjaman.PID_BUKU = buku.ID_BUKU "+
                    "ORDER BY peminjaman.ID_PEMINJAMAN;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                this.dgvPeminjaman.DataSource = dt;

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home d = new Home();
            d.Show();
            this.Hide();
        }
    }
}
