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
    public partial class TambahPeminjaman : Form
    {

        int id_anggota, id_buku;
        DaftarPeminjaman formParent;
        public TambahPeminjaman(DaftarPeminjaman parent)
        {
            InitializeComponent();
            this.formParent = parent;
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

        private void tbSearchNIM_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql =
                    "SELECT ID_ANGGOTA as ID, NIM as NIM , NAMA as NAMA FROM anggota WHERE NIM=@nim;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@nim", tbSearchNIM.Text);

                MySqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                this.dgvNIM.DataSource = dt;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearchBuku_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql =
                    "SELECT ID_BUKU as ID, JUDUL as JUDUL, PENGARANG as PENGARANG FROM buku WHERE JUDUL LIKE @judul;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@judul", tbSearchBuku.Text);

                MySqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                this.dgvBuku.DataSource = dt;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            formParent.Show();
            this.Hide();
        }

        private void btPilih_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow != null && dgvNIM.CurrentRow != null)
            {
                id_anggota = Convert.ToInt16(this.dgvNIM.SelectedRows[0].Cells[0].Value.ToString());
                String nim_anggota = this.dgvNIM.SelectedRows[0].Cells[1].Value.ToString();
                String nama_anggota = this.dgvNIM.SelectedRows[0].Cells[2].Value.ToString();

                id_buku = Convert.ToInt16(this.dgvBuku.SelectedRows[0].Cells[0].Value.ToString());
                String judul_buku = this.dgvBuku.SelectedRows[0].Cells[1].Value.ToString();
                String pengarang_buku = this.dgvBuku.SelectedRows[0].Cells[2].Value.ToString();

                lbNamaPeminjam.Text = nama_anggota;
                lbNIM.Text = nim_anggota;
                lbJudul.Text = judul_buku;
                lbPengarang.Text = pengarang_buku;
                
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (lbNamaPeminjam.Text != "" && lbNIM.Text != "" && lbJudul.Text != "" && lbPengarang.Text != "" )
            {
                MySqlConnection conn = this.makeDatabaseConnection();

                try
                {
                    conn.Open();

                    String sql = "INSERT INTO peminjaman " +
                        "(PID_ANGGOTA, PID_BUKU, STATUS) VALUES " +
                        "(@id_anggota, @id_buku, @status) ";

                    MySqlCommand command = new MySqlCommand(sql, conn);


                    command.Parameters.AddWithValue("@id_anggota", id_anggota);
                    command.Parameters.AddWithValue("@id_buku", id_buku);
                    command.Parameters.AddWithValue("@status", true);

                    int affectedRows = command.ExecuteNonQuery();//nonquery karena tidak mengambil data tapi mengirimkan data

                    conn.Close();

                    DialogResult d = MessageBox.Show("data berhasil disimpan", "", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        lbNamaPeminjam.Text = "";
                        lbNIM.Text = "";
                        lbJudul.Text = "";
                        lbPengarang.Text = "";

                        this.Hide();
                        formParent.refresh_data_peminjaman();
                        formParent.Show();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Semua field harus diisi");
            }
        }
    }
}