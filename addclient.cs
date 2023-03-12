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

namespace prakt
{
    public partial class addclient : Form
    {
        db db = new db();
        public addclient()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            db.openConnect();
            string query = "INSERT INTO client(name, adress, phone, log, password) VALUES('" + name.Text + "', '" + adress.Text + "', '" + phone.Text + "', '" + log.Text + "', '" + password.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnect());
            cmd.ExecuteNonQuery();
            db.closeConnect();
            name.Clear(); adress.Clear(); phone.Clear(); log.Clear(); password.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addclient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
