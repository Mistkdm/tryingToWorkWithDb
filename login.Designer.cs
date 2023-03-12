
namespace prakt
{
    partial class login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.log = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showpasssword = new System.Windows.Forms.CheckBox();
            this.name_log = new System.Windows.Forms.Label();
            this.name_password = new System.Windows.Forms.Label();
            this.bd_connection = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.clientAuth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(303, 197);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(345, 38);
            this.log.TabIndex = 0;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Peru;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(363, 411);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(230, 44);
            this.enter.TabIndex = 2;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(356, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизация";
            // 
            // showpasssword
            // 
            this.showpasssword.AutoSize = true;
            this.showpasssword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpasssword.Location = new System.Drawing.Point(303, 351);
            this.showpasssword.Name = "showpasssword";
            this.showpasssword.Size = new System.Drawing.Size(214, 28);
            this.showpasssword.TabIndex = 4;
            this.showpasssword.Text = "Отображать пароль";
            this.showpasssword.UseVisualStyleBackColor = true;
            this.showpasssword.CheckedChanged += new System.EventHandler(this.showpasssword_CheckedChanged);
            // 
            // name_log
            // 
            this.name_log.AutoSize = true;
            this.name_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_log.Location = new System.Drawing.Point(158, 203);
            this.name_log.Name = "name_log";
            this.name_log.Size = new System.Drawing.Size(86, 32);
            this.name_log.TabIndex = 5;
            this.name_log.Text = "Login";
            // 
            // name_password
            // 
            this.name_password.AutoSize = true;
            this.name_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_password.Location = new System.Drawing.Point(158, 289);
            this.name_password.Name = "name_password";
            this.name_password.Size = new System.Drawing.Size(139, 32);
            this.name_password.TabIndex = 6;
            this.name_password.Text = "Password";
            // 
            // bd_connection
            // 
            this.bd_connection.BackColor = System.Drawing.Color.Peru;
            this.bd_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bd_connection.Location = new System.Drawing.Point(768, 467);
            this.bd_connection.Name = "bd_connection";
            this.bd_connection.Size = new System.Drawing.Size(164, 65);
            this.bd_connection.TabIndex = 7;
            this.bd_connection.Text = "Проверить подключение";
            this.bd_connection.UseVisualStyleBackColor = false;
            this.bd_connection.Click += new System.EventHandler(this.bd_connection_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(303, 283);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(345, 38);
            this.password.TabIndex = 8;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // clientAuth
            // 
            this.clientAuth.BackColor = System.Drawing.Color.Peru;
            this.clientAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientAuth.Location = new System.Drawing.Point(767, 390);
            this.clientAuth.Name = "clientAuth";
            this.clientAuth.Size = new System.Drawing.Size(164, 65);
            this.clientAuth.TabIndex = 9;
            this.clientAuth.Text = "Вход для клиентов";
            this.clientAuth.UseVisualStyleBackColor = false;
            this.clientAuth.Click += new System.EventHandler(this.clientAuth_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(943, 542);
            this.Controls.Add(this.clientAuth);
            this.Controls.Add(this.password);
            this.Controls.Add(this.bd_connection);
            this.Controls.Add(this.name_password);
            this.Controls.Add(this.name_log);
            this.Controls.Add(this.showpasssword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.log);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showpasssword;
        private System.Windows.Forms.Label name_log;
        private System.Windows.Forms.Label name_password;
        private System.Windows.Forms.Button bd_connection;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button clientAuth;
    }
}

