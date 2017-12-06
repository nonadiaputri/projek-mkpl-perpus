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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=perpus");
        MySqlCommand cmd;
        MySqlDataAdapter dta;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM admin WHERE USERNAME='" + tbUsername.Text + "' AND PASSWORD='" + textBox2.Text + "';";
            MySqlDataReader read;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("login gagal");
            }
            conn.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string ValueToSearch = tbSearch.Text;
            SearchData(ValueToSearch); 
        }

       
        

        public void SearchData(String ValueToSearch)
        {
            String query="SELECT * FROM buku WHERE JUDUL like '%"+ValueToSearch+"%'";
            cmd = new MySqlCommand(query, conn);
            dta = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            SearchData("");
        }
    }
}
