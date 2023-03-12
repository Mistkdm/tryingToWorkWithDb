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
    public partial class loginClient : Form
    {
        db db = new db();
        public loginClient()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            db.openConnect();
            var query = "SELECT phone FROM client WHERE phone='" + phone.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnect());
            string result = string.Empty;
            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    result = dataReader.GetString(0);
                }

                dataReader.Close();

                if (!string.IsNullOrEmpty(result))
                {
                    this.Hide();
                    clientOrderCheck form5 = new clientOrderCheck(phone.Text);
                    form5.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    form5.Show();
                }
                else
                {
                    MessageBox.Show("Неправильно введен логин или пароль.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            db.closeConnect();
        }
    }
}
