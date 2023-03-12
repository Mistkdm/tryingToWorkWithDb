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
    public partial class login : Form
    {
        db db = new db();
        public login()
        {
            InitializeComponent();
        }

        private void bd_connection_Click(object sender, EventArgs e)
        {
            db db = new db();
            try
            {
                db.openConnect();
                MessageBox.Show("Сервер доступен");
                db.closeConnect();
            }
            catch (Exception mfj)
            {
                MessageBox.Show(mfj.Message);
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            db.openConnect();
            var query = "SELECT id_employee FROM employee WHERE log='" + log.Text + "' AND password = '" + password.Text + "' ";
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
                    order form2 = new order(log.Text, password.Text);
                    form2.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    form2.Show();
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

        private void showpasssword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasssword.Checked)
            {
                password.PasswordChar = (char)0;
            }
            else
            {
                password.PasswordChar = '●';
            }
            
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Используйте только латинскую кириллицу и цифры!", "Внимание");
            }
        }

        private void clientAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginClient form4 = new loginClient();
            form4.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            form4.Show();
        }

    }
}
