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
    public partial class EditBuku : Form
    {

        public DaftarBuku formParent;
        private int id;
        public EditBuku()
        {
            InitializeComponent();
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

        private void btBatal_Click(object sender, EventArgs e)
        {
            DaftarBuku DB = new DaftarBuku();
            DB.Show();
            this.Hide();
        }
    }

}
