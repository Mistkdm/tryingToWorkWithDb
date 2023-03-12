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
    public partial class clientOrderCheck : Form
    {
        db db = new db();
        private MySqlDataAdapter mySqlDataAdapter = null;
        private DataSet dataSet = null;
        private string phone;
        public clientOrderCheck(string phone)
        {
            InitializeComponent();
            this.phone = phone;
            FIO.Text = whoAmI(phone);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT data, id_service, statys, finally_price FROM `order` WHERE id_client= '" + whoAmIid(phone) + "' ", db.GetConnect());

                dataSet = new DataSet();

                mySqlDataAdapter.Fill(dataSet, "order");

                orderCheck.DataSource = dataSet.Tables["order"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string whoAmI(string phone)
        {
            db.openConnect();
            MySqlCommand command = new MySqlCommand("SELECT name FROM client WHERE phone='" + phone + "' ", db.GetConnect());
            return command.ExecuteScalar().ToString();
        }
        private string whoAmIid(string phone)
        {
            db.openConnect();
            MySqlCommand command = new MySqlCommand("SELECT id_client FROM client WHERE phone='" + phone + "' ", db.GetConnect());
            return command.ExecuteScalar().ToString();
        }

        private void clientOrderCheck_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
