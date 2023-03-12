
namespace prakt
{
    partial class order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.DataGridView();
            this.id_order = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.id_client = new System.Windows.Forms.ComboBox();
            this.service = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.sale = new System.Windows.Forms.CheckBox();
            this.price_sale = new System.Windows.Forms.TextBox();
            this.statys = new System.Windows.Forms.CheckBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.saveorder = new System.Windows.Forms.Button();
            this.neworder = new System.Windows.Forms.GroupBox();
            this.addclient = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            this.neworder.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Peru;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(899, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 49);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // orders
            // 
            this.orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders.Location = new System.Drawing.Point(12, 67);
            this.orders.Name = "orders";
            this.orders.RowHeadersWidth = 51;
            this.orders.RowTemplate.Height = 24;
            this.orders.Size = new System.Drawing.Size(1060, 335);
            this.orders.TabIndex = 4;
            this.orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_CellContentClick);
            this.orders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orders_RowHeaderMouseDoubleClick);
            // 
            // id_order
            // 
            this.id_order.Enabled = false;
            this.id_order.Location = new System.Drawing.Point(209, 29);
            this.id_order.Name = "id_order";
            this.id_order.Size = new System.Drawing.Size(110, 27);
            this.id_order.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 27);
            this.textBox2.TabIndex = 1;
            // 
            // id_client
            // 
            this.id_client.FormattingEnabled = true;
            this.id_client.Location = new System.Drawing.Point(209, 117);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(567, 28);
            this.id_client.TabIndex = 3;
            // 
            // service
            // 
            this.service.FormattingEnabled = true;
            this.service.Location = new System.Drawing.Point(209, 166);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(567, 28);
            this.service.TabIndex = 4;
            this.service.SelectedIndexChanged += new System.EventHandler(this.service_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата оформления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Клиент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Услуга:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Стоимость, руб:";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Window;
            this.price.Enabled = false;
            this.price.Location = new System.Drawing.Point(209, 213);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(110, 27);
            this.price.TabIndex = 10;
            // 
            // sale
            // 
            this.sale.AutoSize = true;
            this.sale.Location = new System.Drawing.Point(567, 216);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(93, 24);
            this.sale.TabIndex = 11;
            this.sale.Text = "Скидка";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.CheckedChanged += new System.EventHandler(this.sale_CheckedChanged);
            // 
            // price_sale
            // 
            this.price_sale.BackColor = System.Drawing.SystemColors.Window;
            this.price_sale.Enabled = false;
            this.price_sale.Location = new System.Drawing.Point(666, 213);
            this.price_sale.Name = "price_sale";
            this.price_sale.ReadOnly = true;
            this.price_sale.Size = new System.Drawing.Size(110, 27);
            this.price_sale.TabIndex = 12;
            // 
            // statys
            // 
            this.statys.AutoSize = true;
            this.statys.Location = new System.Drawing.Point(835, 72);
            this.statys.Name = "statys";
            this.statys.Size = new System.Drawing.Size(115, 24);
            this.statys.TabIndex = 13;
            this.statys.Text = "Выполнен";
            this.statys.UseVisualStyleBackColor = true;
            this.statys.CheckedChanged += new System.EventHandler(this.statys_CheckedChanged);
            // 
            // data
            // 
            this.data.CustomFormat = "yyyy-MM-dd";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(209, 75);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(233, 27);
            this.data.TabIndex = 6;
            this.data.Value = new System.DateTime(2023, 3, 11, 0, 0, 0, 0);
            // 
            // saveorder
            // 
            this.saveorder.Location = new System.Drawing.Point(835, 23);
            this.saveorder.Name = "saveorder";
            this.saveorder.Size = new System.Drawing.Size(213, 43);
            this.saveorder.TabIndex = 14;
            this.saveorder.Text = "Сохранить заказ";
            this.saveorder.UseVisualStyleBackColor = true;
            this.saveorder.Click += new System.EventHandler(this.saveorder_Click);
            // 
            // neworder
            // 
            this.neworder.Controls.Add(this.change);
            this.neworder.Controls.Add(this.saveorder);
            this.neworder.Controls.Add(this.data);
            this.neworder.Controls.Add(this.statys);
            this.neworder.Controls.Add(this.price_sale);
            this.neworder.Controls.Add(this.sale);
            this.neworder.Controls.Add(this.price);
            this.neworder.Controls.Add(this.label5);
            this.neworder.Controls.Add(this.label4);
            this.neworder.Controls.Add(this.label3);
            this.neworder.Controls.Add(this.label2);
            this.neworder.Controls.Add(this.label1);
            this.neworder.Controls.Add(this.service);
            this.neworder.Controls.Add(this.id_client);
            this.neworder.Controls.Add(this.textBox2);
            this.neworder.Controls.Add(this.id_order);
            this.neworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.neworder.Location = new System.Drawing.Point(12, 408);
            this.neworder.Name = "neworder";
            this.neworder.Size = new System.Drawing.Size(1058, 260);
            this.neworder.TabIndex = 5;
            this.neworder.TabStop = false;
            this.neworder.Text = "Новый заказ";
            // 
            // addclient
            // 
            this.addclient.BackColor = System.Drawing.SystemColors.Control;
            this.addclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addclient.Location = new System.Drawing.Point(12, 674);
            this.addclient.Name = "addclient";
            this.addclient.Size = new System.Drawing.Size(304, 49);
            this.addclient.TabIndex = 6;
            this.addclient.Text = "Добавить клиента";
            this.addclient.UseVisualStyleBackColor = false;
            this.addclient.Click += new System.EventHandler(this.addclient_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.SystemColors.Control;
            this.reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.Location = new System.Drawing.Point(12, 12);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(173, 49);
            this.reload.TabIndex = 7;
            this.reload.Text = "Обновить";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(835, 197);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(213, 43);
            this.change.TabIndex = 15;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Visible = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 732);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.addclient);
            this.Controls.Add(this.neworder);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал заказов";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            this.neworder.ResumeLayout(false);
            this.neworder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView orders;
        private System.Windows.Forms.TextBox id_order;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox id_client;
        private System.Windows.Forms.ComboBox service;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.CheckBox sale;
        private System.Windows.Forms.TextBox price_sale;
        private System.Windows.Forms.CheckBox statys;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button saveorder;
        private System.Windows.Forms.GroupBox neworder;
        private System.Windows.Forms.Button addclient;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button change;
    }
}