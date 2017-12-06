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
    public partial class LihatDetail : Form
    {
        public DaftarBuku formParent;
        private int id;
        public LihatDetail()
        {
            InitializeComponent();
        }

        public LihatDetail(DaftarBuku parent, String id)
        {
            InitializeComponent();
            this.formParent = parent;
            this.id = Convert.ToInt16(id);
            this.get_selected_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DaftarBuku db = new DaftarBuku();
            db.Show();
            this.Hide();
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

        public void get_selected_data()
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql = "SELECT * FROM buku WHERE ID_BUKU=@id";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                String judul = "", penerbit = "", pengarang = "", tahun_terbit = "", nomor_seri = "", halaman = "", deskripsi = "";
                while (reader.Read())
                {
                    judul = reader[1].ToString();
                    penerbit = reader[2].ToString();
                    pengarang = reader[3].ToString();
                    tahun_terbit = reader[4].ToString();
                    nomor_seri = reader[5].ToString();
                    halaman = reader[6].ToString();
                    deskripsi = reader[7].ToString();
                }

                this.lbJudul.Text = judul;
                this.lbPenerbit.Text = penerbit;
                this.lbPengarang.Text = pengarang;
                this.lbtt.Text = tahun_terbit;
                this.lbns.Text = nomor_seri;
                this.lbhal.Text = halaman;
                this.lbdes.Text = deskripsi;

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
