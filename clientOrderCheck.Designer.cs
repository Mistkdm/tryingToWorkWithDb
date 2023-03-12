
namespace prakt
{
    partial class clientOrderCheck
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
            this.orderCheck = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Peru;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(615, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 49);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // orderCheck
            // 
            this.orderCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderCheck.Location = new System.Drawing.Point(14, 91);
            this.orderCheck.Name = "orderCheck";
            this.orderCheck.RowHeadersWidth = 51;
            this.orderCheck.RowTemplate.Height = 24;
            this.orderCheck.Size = new System.Drawing.Size(773, 300);
            this.orderCheck.TabIndex = 5;
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(12, 21);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(55, 32);
            this.FIO.TabIndex = 6;
            this.FIO.Text = "Fio";
            // 
            // clientOrderCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.orderCheck);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "clientOrderCheck";
            this.Text = "clientOrderCheck";
            this.Load += new System.EventHandler(this.clientOrderCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView orderCheck;
        private System.Windows.Forms.Label FIO;
    }
}