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

        TambahPeminjaman formTambahPeminjaman;

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
                    "SELECT peminjaman.ID_PEMINJAMAN, anggota.NAMA, buku.JUDUL, peminjaman.status " +
                    "FROM anggota " +
                        "INNER JOIN peminjaman ON anggota.ID_ANGGOTA = peminjaman.PID_ANGGOTA " +
                        "INNER JOIN buku ON peminjaman.PID_BUKU = buku.ID_BUKU " +
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

        private void lbTambahPeminjaman_Click(object sender, EventArgs e)
        {
            if (this.formTambahPeminjaman == null)
            {
                this.formTambahPeminjaman = new TambahPeminjaman(this);
            }

            this.formTambahPeminjaman.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.formTambahPeminjaman == null)
            {
                this.formTambahPeminjaman = new TambahPeminjaman(this);
            }

            this.formTambahPeminjaman.Show();
            this.Hide();
        }

        private void lbPengembalian_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home d = new Home();
            d.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        public void change_status()
        {

            if (dgvPeminjaman.CurrentRow != null)
            {
                String id = this.dgvPeminjaman.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("kembalikan buku dengan id peminjaman " + id, "Info", MessageBoxButtons.YesNo);


                if (dr == DialogResult.Yes)
                {
                    MySqlConnection conn = this.makeDatabaseConnection();

                    try
                    {
                        conn.Open();

                        String sql = "UPDATE peminjaman " +
                            "SET status = @status " +
                            "WHERE ID_PEMINJAMAN = @id";

                        MySqlCommand command = new MySqlCommand(sql, conn);

                        command.Parameters.AddWithValue("@status", false);

                        int affectedRows = command.ExecuteNonQuery();//nonquery karena tidak mengambil data tapi mengirimkan data

                        conn.Close();

                        this.refresh_data_peminjaman();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                MessageBox.Show("pilih buku yang akan dihapus");
            }
        }
    }
}