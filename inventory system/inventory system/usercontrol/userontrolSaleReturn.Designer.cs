namespace inventory_system.usercontrol
{
    partial class userontrolSaleReturn
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
            label10 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            prdqty = new NumericUpDown();
            prdprice = new NumericUpDown();
            date = new DateTimePicker();
            prdtotal = new TextBox();
            prdnumb = new TextBox();
            btninsert = new Button();
            reason = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            Quantity = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            custname = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prdqty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prdprice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(297, 0);
            label10.Name = "label10";
            label10.Size = new Size(202, 50);
            label10.TabIndex = 52;
            label10.Text = "Sales Return";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 265);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(custname);
            groupBox1.Controls.Add(prdqty);
            groupBox1.Controls.Add(prdprice);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(prdtotal);
            groupBox1.Controls.Add(prdnumb);
            groupBox1.Controls.Add(btninsert);
            groupBox1.Controls.Add(reason);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(44, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 262);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales Return";
            // 
            // prdqty
            // 
            prdqty.BackColor = SystemColors.InactiveBorder;
            prdqty.Location = new Point(152, 115);
            prdqty.Name = "prdqty";
            prdqty.Size = new Size(165, 27);
            prdqty.TabIndex = 46;
            // 
            // prdprice
            // 
            prdprice.BackColor = SystemColors.InactiveBorder;
            prdprice.Location = new Point(490, 73);
            prdprice.Name = "prdprice";
            prdprice.Size = new Size(165, 27);
            prdprice.TabIndex = 45;
            // 
            // date
            // 
            date.CalendarMonthBackground = SystemColors.InactiveBorder;
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(152, 30);
            date.Name = "date";
            date.Size = new Size(165, 27);
            date.TabIndex = 0;
            // 
            // prdtotal
            // 
            prdtotal.BackColor = SystemColors.InactiveBorder;
            prdtotal.ForeColor = Color.SteelBlue;
            prdtotal.Location = new Point(490, 113);
            prdtotal.Name = "prdtotal";
            prdtotal.ReadOnly = true;
            prdtotal.Size = new Size(165, 27);
            prdtotal.TabIndex = 36;
            // 
            // prdnumb
            // 
            prdnumb.BackColor = SystemColors.InactiveBorder;
            prdnumb.ForeColor = Color.SteelBlue;
            prdnumb.Location = new Point(152, 72);
            prdnumb.Name = "prdnumb";
            prdnumb.Size = new Size(165, 27);
            prdnumb.TabIndex = 30;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.ForestGreen;
            btninsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btninsert.ForeColor = Color.White;
            btninsert.Location = new Point(271, 210);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(152, 36);
            btninsert.TabIndex = 41;
            btninsert.Text = "Update Inventory";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // reason
            // 
            reason.BackColor = SystemColors.InactiveBorder;
            reason.ForeColor = Color.SteelBlue;
            reason.Location = new Point(152, 155);
            reason.Multiline = true;
            reason.Name = "reason";
            reason.Size = new Size(503, 37);
            reason.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(351, 115);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 43;
            label9.Text = "Total Amount :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(10, 30);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 26;
            label2.Text = "Current Date : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(351, 30);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 37;
            label3.Text = "Customer Name : ";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(10, 155);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 33;
            label7.Text = "Reason : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(351, 72);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 35;
            label8.Text = "Unit Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(10, 72);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 29;
            label5.Text = "Product Number : ";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.ForeColor = Color.SteelBlue;
            Quantity.Location = new Point(10, 113);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(85, 21);
            Quantity.TabIndex = 31;
            Quantity.Text = "Quantity :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(9, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 311);
            dataGridView1.TabIndex = 53;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Number";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Unit Price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Returning Reason";
            Column6.Name = "Column6";
            // 
            // custname
            // 
            custname.BackColor = SystemColors.InactiveBorder;
            custname.ForeColor = Color.SteelBlue;
            custname.Location = new Point(490, 28);
            custname.Name = "custname";
            custname.Size = new Size(165, 27);
            custname.TabIndex = 47;
            // 
            // userontrolSaleReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "userontrolSaleReturn";
            Size = new Size(762, 660);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prdqty).EndInit();
            ((System.ComponentModel.ISupportInitialize)prdprice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label4;
        private GroupBox groupBox1;
        private NumericUpDown prdqty;
        private NumericUpDown prdprice;
        private DateTimePicker date;
        private TextBox prdtotal;
        private TextBox prdnumb;
        private Button btninsert;
        private TextBox reason;
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label Quantity;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox custname;
    }
}
