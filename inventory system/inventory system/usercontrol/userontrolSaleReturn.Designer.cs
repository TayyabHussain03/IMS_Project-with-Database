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
            label1 = new Label();
            txtBoxSubTotal = new TextBox();
            label6 = new Label();
            txtBoxSellingPrice = new TextBox();
            label8 = new Label();
            Quantity = new Label();
            txtBoxCustomerName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtBoxInvNum = new TextBox();
            label4 = new Label();
            cmbBoxView = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            cmbBoxReason = new ComboBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            btnRefresh = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            txtBoxProductNum = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(301, 10);
            label1.Name = "label1";
            label1.Size = new Size(168, 42);
            label1.TabIndex = 21;
            label1.Text = "Sales Return";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.BackColor = SystemColors.InactiveBorder;
            txtBoxSubTotal.Enabled = false;
            txtBoxSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSubTotal.ForeColor = Color.SteelBlue;
            txtBoxSubTotal.Location = new Point(555, 375);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(141, 25);
            txtBoxSubTotal.TabIndex = 17;
            txtBoxSubTotal.Text = ".00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(538, 348);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 16;
            label6.Text = "Total Amount:";
            // 
            // txtBoxSellingPrice
            // 
            txtBoxSellingPrice.BackColor = SystemColors.InactiveBorder;
            txtBoxSellingPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSellingPrice.ForeColor = Color.SteelBlue;
            txtBoxSellingPrice.Location = new Point(391, 375);
            txtBoxSellingPrice.Name = "txtBoxSellingPrice";
            txtBoxSellingPrice.Size = new Size(118, 25);
            txtBoxSellingPrice.TabIndex = 13;
            txtBoxSellingPrice.TextChanged += txtBoxSellingPrice_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(365, 348);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 12;
            label8.Text = "Unit Price :";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.ForeColor = Color.SteelBlue;
            Quantity.Location = new Point(220, 348);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(74, 20);
            Quantity.TabIndex = 8;
            Quantity.Text = "Quantity:";
            // 
            // txtBoxCustomerName
            // 
            txtBoxCustomerName.BackColor = SystemColors.InactiveBorder;
            txtBoxCustomerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCustomerName.ForeColor = Color.SteelBlue;
            txtBoxCustomerName.Location = new Point(24, 166);
            txtBoxCustomerName.Name = "txtBoxCustomerName";
            txtBoxCustomerName.Size = new Size(163, 25);
            txtBoxCustomerName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(7, 353);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 5;
            label5.Text = "Product Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(5, 67);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Current Date:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBoxInvNum);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbBoxView);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(cmbBoxReason);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtBoxSubTotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtBoxSellingPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBoxProductNum);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(txtBoxCustomerName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(9, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 502);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sale Return";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(5, 209);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 37;
            label7.Text = "Invoice Number:";
            // 
            // txtBoxInvNum
            // 
            txtBoxInvNum.BackColor = SystemColors.InactiveBorder;
            txtBoxInvNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInvNum.ForeColor = Color.SteelBlue;
            txtBoxInvNum.Location = new Point(24, 232);
            txtBoxInvNum.Name = "txtBoxInvNum";
            txtBoxInvNum.Size = new Size(163, 25);
            txtBoxInvNum.TabIndex = 36;
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(497, 33);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 35;
            label4.Text = "View Sales:";
            // 
            // cmbBoxView
            // 
            cmbBoxView.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxView.FormattingEnabled = true;
            cmbBoxView.Location = new Point(599, 32);
            cmbBoxView.Name = "cmbBoxView";
            cmbBoxView.Size = new Size(140, 29);
            cmbBoxView.TabIndex = 34;
            cmbBoxView.SelectedIndexChanged += cmbBoxView_SelectedIndexChanged;
            cmbBoxView.KeyPress += cmbBoxView_KeyPress;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(244, 376);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(98, 25);
            numericUpDown1.TabIndex = 33;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cmbBoxReason
            // 
            cmbBoxReason.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxReason.ForeColor = Color.SteelBlue;
            cmbBoxReason.FormattingEnabled = true;
            cmbBoxReason.Items.AddRange(new object[] { "Please Select", "Damaged/Defected", "Expired", "Faulty", "Duplicate", "Unusable", "Unsatisfactory", "Mismatched", "Other..." });
            cmbBoxReason.Location = new Point(23, 302);
            cmbBoxReason.Name = "cmbBoxReason";
            cmbBoxReason.Size = new Size(163, 25);
            cmbBoxReason.TabIndex = 32;
            cmbBoxReason.KeyPress += cmbBoxReason_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(208, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(531, 256);
            dataGridView1.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(5, 143);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 31;
            label10.Text = "Customer Name:";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(208, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(91, 33);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker1.CalendarTitleForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarTrailingForeColor = Color.SteelBlue;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(24, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 29);
            dateTimePicker1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(6, 279);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 29;
            label3.Text = "Reason :";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkRed;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(400, 435);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 44);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.ForestGreen;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(220, 435);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 44);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update Inventory";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBoxProductNum
            // 
            txtBoxProductNum.BackColor = SystemColors.InactiveBorder;
            txtBoxProductNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductNum.ForeColor = Color.SteelBlue;
            txtBoxProductNum.Location = new Point(24, 376);
            txtBoxProductNum.Name = "txtBoxProductNum";
            txtBoxProductNum.Size = new Size(163, 25);
            txtBoxProductNum.TabIndex = 11;
           
            // 
            // userontrolSaleReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "userontrolSaleReturn";
            Size = new Size(775, 664);
            Load += userontrolSaleReturn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBoxSubTotal;
        private Label label6;
        private TextBox txtBoxSellingPrice;
        private Label label8;
        private Label Quantity;
        private TextBox txtBoxCustomerName;
        private Label label5;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtBoxProductNum;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRefresh;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbBoxReason;
        private Label label4;
        private ComboBox cmbBoxView;
        private Label label7;
        private TextBox txtBoxInvNum;
    }
}
