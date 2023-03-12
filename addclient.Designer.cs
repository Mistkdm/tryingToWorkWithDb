
namespace prakt
{
    partial class addclient
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
            this.name = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savedata = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.loglab = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.paslab = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(353, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(659, 38);
            this.name.TabIndex = 1;
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress.Location = new System.Drawing.Point(353, 101);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(659, 38);
            this.adress.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(353, 160);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(304, 38);
            this.phone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО частного лица:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон:";
            // 
            // savedata
            // 
            this.savedata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedata.Location = new System.Drawing.Point(657, 331);
            this.savedata.Name = "savedata";
            this.savedata.Size = new System.Drawing.Size(334, 44);
            this.savedata.TabIndex = 7;
            this.savedata.Text = "Сохранить данные";
            this.savedata.UseVisualStyleBackColor = true;
            this.savedata.Click += new System.EventHandler(this.savedata_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(38, 331);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(334, 44);
            this.exit.TabIndex = 8;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // loglab
            // 
            this.loglab.AutoSize = true;
            this.loglab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loglab.Location = new System.Drawing.Point(53, 222);
            this.loglab.Name = "loglab";
            this.loglab.Size = new System.Drawing.Size(94, 32);
            this.loglab.TabIndex = 10;
            this.loglab.Text = "Login:";
            this.loglab.Click += new System.EventHandler(this.label4_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(353, 216);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(304, 38);
            this.log.TabIndex = 9;
            this.log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // paslab
            // 
            this.paslab.AutoSize = true;
            this.paslab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paslab.Location = new System.Drawing.Point(53, 283);
            this.paslab.Name = "paslab";
            this.paslab.Size = new System.Drawing.Size(147, 32);
            this.paslab.TabIndex = 12;
            this.paslab.Text = "Password:";
            this.paslab.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(353, 277);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(304, 38);
            this.password.TabIndex = 11;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // addclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 396);
            this.Controls.Add(this.paslab);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loglab);
            this.Controls.Add(this.log);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.savedata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация клиента";
            this.Load += new System.EventHandler(this.addclient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label loglab;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label paslab;
        private System.Windows.Forms.TextBox password;
    }
}