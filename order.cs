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
    public partial class order : Form
    {
        db db = new db();
        private MySqlCommandBuilder mySqlBuilder = null;
        private MySqlDataAdapter mySqlDataAdapter = null;
        private DataSet dataSet = null;
        private int discount = 0;
        private string readyCheck = "Обработка";
        private string log;
        private string password;
        public order(string log, string password)
        {
            InitializeComponent();
            this.log = log;
            this.password = password;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addclient_Click(object sender, EventArgs e)
        {
            this.Hide();
            addclient form3 = new addclient();
            form3.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            form3.Show();
        }

        private void order_Load(object sender, EventArgs e)
        {
            LoadData();
            serviceComboBox();
            id_clientComboBox();
        }

        public void LoadData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT *, 'Delete' AS Command FROM `order`", db.GetConnect());

                mySqlBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                mySqlBuilder.GetInsertCommand();
                mySqlBuilder.GetUpdateCommand();
                mySqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                mySqlDataAdapter.Fill(dataSet, "order");

                orders.DataSource = dataSet.Tables["order"];

                for (int i = 0; i < orders.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    orders[8, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void id_clientComboBox()
        {
            db.openConnect();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client`", db.GetConnect());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            id_client.DisplayMember = "phone";
            id_client.ValueMember = "id_client";
            id_client.DataSource = table;
            id_client.SelectedIndex = -1;

            db.closeConnect();
        }
        private void serviceComboBox()
        {
            db.openConnect();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `service`", db.GetConnect());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            service.DisplayMember = "service_name";
            service.ValueMember = "id_service";
            service.DataSource = table;
            service.SelectedIndex = -1;

            db.closeConnect();
        }
        public void ReloadData() //обновление страницы
        {
            try
            {
                dataSet.Tables["order"].Clear();

                mySqlDataAdapter.Fill(dataSet, "order");

                orders.DataSource = dataSet.Tables["order"];

                for (int i = 0; i < orders.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    orders[8, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
        public int convertPhoneToId(string phone)
        {
            try
            {
                db.openConnect();
            MySqlCommand command = new MySqlCommand($"SELECT id_client FROM client WHERE phone='{phone}'", db.GetConnect());
            int id = Int32.Parse(command.ExecuteScalar().ToString());
            return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }
        public int convertNameToId(string name)
        {
            try
            {
                db.openConnect();
                MySqlCommand command = new MySqlCommand($"SELECT id_service FROM service WHERE service_name='{name}'", db.GetConnect());
                int id = Int32.Parse(command.ExecuteScalar().ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            
        ;
        }
        public void addData()
        {
            db.openConnect();
            var query = "INSERT INTO `order` (data, id_service, id_client, id_employee, prozent, statys, finally_price) VALUES ('" 
                + data.Text + "',  '" + convertNameToId(service.Text) + "','" 
                + convertPhoneToId(id_client.Text) + "', '" + whoAmI(log, password) + "',  '" + discount + "', 'обработка', '" + price_sale.Text + "') ";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnect());
            cmd.ExecuteNonQuery();
            db.closeConnect();
        }
        private void saveorder_Click(object sender, EventArgs e)
        {
            addData();
        }
        private int price_Show(string name)
        {
            if (String.IsNullOrEmpty(service.Text))
            {
                return 0;
            }
            else
            {
                db.openConnect();
                var query = $"SELECT price FROM service WHERE service_name='{name}' ";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnect());
                int price = Int32.Parse(cmd.ExecuteScalar().ToString());
                return price;
            }
        }
        private void service_SelectedIndexChanged(object sender, EventArgs e)
        {
            price.Text = price_Show(service.Text).ToString();
            price_sale.Text = price.Text;
        }

        private void sale_CheckedChanged(object sender, EventArgs e)
        {
            if (sale.Checked)
            {
                price_sale.Text = (Single.Parse(price.Text) * 0.85).ToString();
                discount = 15;
            }
            else
            {
                price_sale.Text = price.Text;
                discount = 0;
            }
        }
        private void orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;

                        orders.Rows.RemoveAt(rowIndex);

                        dataSet.Tables["order"].Rows[rowIndex].Delete();

                        mySqlDataAdapter.Update(dataSet, "order");
                    }
                    ReloadData();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void orders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            db.openConnect();
            id_order.Text = orders.CurrentRow.Cells[0].Value.ToString();
            data.Text = orders.CurrentRow.Cells[1].Value.ToString();


            id_client.Text = convertIdToPhone(orders.CurrentRow.Cells[2].Value.ToString());
            service.Text = convertIdToService(orders.CurrentRow.Cells[3].Value.ToString());

            if (orders.CurrentRow.Cells[5].Value.ToString() == "15")
            {
                sale.Checked = true;
                price.Text = (Single.Parse(orders.CurrentRow.Cells[7].Value.ToString())*100/85).ToString();
            }
            else
            {
                sale.Checked = false;
                price.Text = orders.CurrentRow.Cells[7].Value.ToString();
            }
            price_sale.Text = orders.CurrentRow.Cells[7].Value.ToString();

            change.Visible = true;
            db.closeConnect();
        }
        private string convertIdToPhone(string id)
        {
            db.openConnect();
            MySqlCommand command = new MySqlCommand($"SELECT phone FROM client WHERE id_client='{id}'", db.GetConnect());
            string phone = command.ExecuteScalar().ToString();
            return phone;
        }
        private string convertIdToService(string id)
        {
            try
            {
                db.openConnect();
            MySqlCommand command = new MySqlCommand($"SELECT service_name FROM service WHERE id_service='{id}'", db.GetConnect());
            string service = command.ExecuteScalar().ToString();
            return service;
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
}

        private void change_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `order` SET data='" + data.Text + "', id_service='" 
                + convertNameToId(service.Text) + "', id_client = '" + convertPhoneToId(id_client.Text) + "', prozent=" 
                + discount + ", finally_price = '" + price_sale.Text + "', statys='" + readyCheck + "' WHERE id_order='" + id_order.Text+"'", db.GetConnect());
            command.ExecuteNonQuery();
            id_order.Text = ""; data.Text = ""; id_client.Text = ""; service.Text = ""; price.Text = ""; price_sale.Text = "";
            change.Visible = false;
        }

        private void statys_CheckedChanged(object sender, EventArgs e)
        {
            if (statys.Checked)
            {
                readyCheck = "Выполнен";
            }
            else
            {
                readyCheck = "Обработка";
            }
        }
        private int whoAmI(string log, string password)
        {
            db.openConnect();
            MySqlCommand command = new MySqlCommand("SELECT id_employee FROM employee WHERE log='"+ log+ "' AND password='" + password + "' ", db.GetConnect());
            return Int32.Parse(command.ExecuteScalar().ToString());
            ;
        }
    }
}