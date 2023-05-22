namespace inventory_system.usercontrol
{
    partial class useryearlysale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            item_caetgory = new DataGridViewTextBoxColumn();
            item_price = new DataGridViewTextBoxColumn();
            item_quantity = new DataGridViewTextBoxColumn();
            total_sales = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnlogin = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            txtpassword = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            txtemail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGray;
            label8.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(209, 448);
            label8.Name = "label8";
            label8.Size = new Size(44, 31);
            label8.TabIndex = 17;
            label8.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGray;
            label10.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(301, 448);
            label10.Name = "label10";
            label10.Size = new Size(251, 31);
            label10.TabIndex = 16;
            label10.Text = "Total Revnue Genrate:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(9, 448);
            label9.Name = "label9";
            label9.Size = new Size(184, 31);
            label9.TabIndex = 15;
            label9.Text = "Total Item Sold:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(252, 13);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 14;
            label1.Text = "Yearly Sales Report";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { date, item_name, item_caetgory, item_price, item_quantity, total_sales });
            dataGridView1.Location = new Point(3, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(640, 283);
            dataGridView1.TabIndex = 13;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // item_name
            // 
            item_name.HeaderText = "Name";
            item_name.Name = "item_name";
            // 
            // item_caetgory
            // 
            item_caetgory.HeaderText = "Category";
            item_caetgory.Name = "item_caetgory";
            // 
            // item_price
            // 
            item_price.HeaderText = "Unit Price";
            item_price.Name = "item_price";
            // 
            // item_quantity
            // 
            item_quantity.HeaderText = "Quantity";
            item_quantity.Name = "item_quantity";
            // 
            // total_sales
            // 
            total_sales.HeaderText = "Total Sales";
            total_sales.Name = "total_sales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(25, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 142);
            panel1.TabIndex = 12;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.CadetBlue;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(212, 88);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(171, 40);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Add";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(85, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveBorder;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(479, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(402, 10);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 12;
            label4.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(212, 46);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 14;
            label6.Text = "Quantity";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveBorder;
            txtpassword.Location = new Point(276, 49);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(107, 23);
            txtpassword.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(85, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(107, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 10);
            label5.Name = "label5";
            label5.Size = new Size(39, 23);
            label5.TabIndex = 13;
            label5.Text = "Date";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveBorder;
            txtemail.Location = new Point(276, 10);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(107, 23);
            txtemail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(212, 10);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 8;
            label2.Text = "Net Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGray;
            label11.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(567, 448);
            label11.Name = "label11";
            label11.Size = new Size(44, 31);
            label11.TabIndex = 18;
            label11.Text = "00";
            // 
            // useryearlysale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "useryearlysale";
            Size = new Size(646, 524);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label10;
        private Label label9;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn item_caetgory;
        private DataGridViewTextBoxColumn item_price;
        private DataGridViewTextBoxColumn item_quantity;
        private DataGridViewTextBoxColumn total_sales;
        private Panel panel1;
        private Button btnlogin;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label6;
        private TextBox txtpassword;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox txtemail;
        private Label label3;
        private Label label2;
        private Label label11;
    }
}
