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
    public partial class DaftarBuku : Form
    {

        tambahBuku formTambahBuku;
        EditBuku formEditBuku;

        public DaftarBuku()
        {
            InitializeComponent();
            this.refresh_data_buku();
        }
        
        public void show_form()
        {
            this.Show();
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


        public void refresh_data_buku()
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql =
                    "SELECT * FROM buku ";

                MySqlCommand command = new MySqlCommand(sql, conn);

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
    }
}
