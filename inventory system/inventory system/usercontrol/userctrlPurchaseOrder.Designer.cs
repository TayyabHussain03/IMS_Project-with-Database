namespace inventory_system.usercontrol
{
    partial class userctrlPurchaseOrder
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
            groupBox1 = new GroupBox();
            btnProceed = new Button();
            btnClear = new Button();
            txtBoxTotalAmount = new TextBox();
            btnRemove = new Button();
            btnAddinPurchase = new Button();
            label13 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label12 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            txtBoxSellingPrice = new TextBox();
            label9 = new Label();
            label1 = new Label();
            txtBoxProductName = new TextBox();
            cmbBoxPayment = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            txtBoxPONum = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            btnRefresh = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBoxSubTotal = new TextBox();
            label6 = new Label();
            txtBoxCostingPrice = new TextBox();
            label8 = new Label();
            txtBoxProductNum = new TextBox();
            Quantity = new Label();
            txtBoxSupplierName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            label16 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(btnProceed);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtBoxTotalAmount);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnAddinPurchase);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtBoxSellingPrice);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBoxProductName);
            groupBox1.Controls.Add(cmbBoxPayment);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBoxPONum);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtBoxSubTotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtBoxCostingPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBoxProductNum);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(txtBoxSupplierName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(841, 595);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchasing Transaction:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Black;
            btnProceed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(680, 534);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(140, 43);
            btnProceed.TabIndex = 70;
            btnProceed.Text = "Update Inventory";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RoyalBlue;
            btnClear.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(506, 449);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 42);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear Basket";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtBoxTotalAmount
            // 
            txtBoxTotalAmount.BackColor = SystemColors.InactiveBorder;
            txtBoxTotalAmount.Enabled = false;
            txtBoxTotalAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTotalAmount.ForeColor = Color.SteelBlue;
            txtBoxTotalAmount.Location = new Point(704, 457);
            txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            txtBoxTotalAmount.Size = new Size(116, 25);
            txtBoxTotalAmount.TabIndex = 69;
            txtBoxTotalAmount.Text = ".00";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(381, 447);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 44);
            btnRemove.TabIndex = 41;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // btnAddinPurchase
            // 
            btnAddinPurchase.BackColor = Color.ForestGreen;
            btnAddinPurchase.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddinPurchase.ForeColor = Color.White;
            btnAddinPurchase.Location = new Point(254, 447);
            btnAddinPurchase.Name = "btnAddinPurchase";
            btnAddinPurchase.Size = new Size(115, 44);
            btnAddinPurchase.TabIndex = 40;
            btnAddinPurchase.Text = "Add in Purchase";
            btnAddinPurchase.UseVisualStyleBackColor = false;
            btnAddinPurchase.Click += btnAddinPurchase_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(688, 436);
            label13.Name = "label13";
            label13.Size = new Size(101, 17);
            label13.TabIndex = 68;
            label13.Text = "Total Amount :";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.CalendarForeColor = Color.SteelBlue;
            dateTimePicker3.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker3.CalendarTitleForeColor = Color.SteelBlue;
            dateTimePicker3.CalendarTrailingForeColor = Color.SteelBlue;
            dateTimePicker3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(165, 390);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(111, 23);
            dateTimePicker3.TabIndex = 67;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(154, 372);
            label12.Name = "label12";
            label12.Size = new Size(84, 17);
            label12.TabIndex = 66;
            label12.Text = "Expiry Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.CalendarForeColor = Color.SteelBlue;
            dateTimePicker2.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker2.CalendarTitleForeColor = Color.SteelBlue;
            dateTimePicker2.CalendarTrailingForeColor = Color.SteelBlue;
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(23, 390);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(110, 23);
            dateTimePicker2.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(6, 373);
            label11.Name = "label11";
            label11.Size = new Size(73, 17);
            label11.TabIndex = 64;
            label11.Text = "MFG Date:";
            // 
            // txtBoxSellingPrice
            // 
            txtBoxSellingPrice.BackColor = SystemColors.InactiveBorder;
            txtBoxSellingPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSellingPrice.ForeColor = Color.SteelBlue;
            txtBoxSellingPrice.Location = new Point(442, 390);
            txtBoxSellingPrice.Name = "txtBoxSellingPrice";
            txtBoxSellingPrice.Size = new Size(110, 25);
            txtBoxSellingPrice.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(428, 372);
            label9.Name = "label9";
            label9.Size = new Size(92, 17);
            label9.TabIndex = 62;
            label9.Text = "Selling Price :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(4, 295);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 61;
            label1.Text = "Product Name:";
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.BackColor = SystemColors.InactiveBorder;
            txtBoxProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductName.ForeColor = Color.SteelBlue;
            txtBoxProductName.Location = new Point(23, 318);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.Size = new Size(163, 25);
            txtBoxProductName.TabIndex = 60;
            // 
            // cmbBoxPayment
            // 
            cmbBoxPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxPayment.ForeColor = Color.SteelBlue;
            cmbBoxPayment.FormattingEnabled = true;
            cmbBoxPayment.Items.AddRange(new object[] { "Please Select", "Cash", "Cheque" });
            cmbBoxPayment.Location = new Point(23, 457);
            cmbBoxPayment.Name = "cmbBoxPayment";
            cmbBoxPayment.Size = new Size(163, 25);
            cmbBoxPayment.TabIndex = 54;
            cmbBoxPayment.KeyPress += cmbBoxPayment_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(4, 174);
            label7.Name = "label7";
            label7.Size = new Size(85, 17);
            label7.TabIndex = 59;
            label7.Text = "PO Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(6, 436);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 51;
            label3.Text = "Payment Type :";
            // 
            // txtBoxPONum
            // 
            txtBoxPONum.BackColor = SystemColors.InactiveBorder;
            txtBoxPONum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPONum.ForeColor = Color.SteelBlue;
            txtBoxPONum.Location = new Point(23, 197);
            txtBoxPONum.Name = "txtBoxPONum";
            txtBoxPONum.Size = new Size(163, 25);
            txtBoxPONum.TabIndex = 58;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(577, 391);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(110, 25);
            numericUpDown1.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(606, 269);
            dataGridView1.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(4, 113);
            label10.Name = "label10";
            label10.Size = new Size(103, 17);
            label10.TabIndex = 53;
            label10.Text = "Supplier Name:";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(214, 38);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(91, 33);
            btnRefresh.TabIndex = 49;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker1.CalendarTitleForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarTrailingForeColor = Color.SteelBlue;
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(23, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 23);
            dateTimePicker1.TabIndex = 52;
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.BackColor = SystemColors.InactiveBorder;
            txtBoxSubTotal.Enabled = false;
            txtBoxSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSubTotal.ForeColor = Color.SteelBlue;
            txtBoxSubTotal.Location = new Point(710, 390);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(110, 25);
            txtBoxSubTotal.TabIndex = 46;
            txtBoxSubTotal.Text = ".00";
            txtBoxSubTotal.TextChanged += txtBoxSubTotal_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(699, 369);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 45;
            label6.Text = "Sub Total:";
            // 
            // txtBoxCostingPrice
            // 
            txtBoxCostingPrice.BackColor = SystemColors.InactiveBorder;
            txtBoxCostingPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCostingPrice.ForeColor = Color.SteelBlue;
            txtBoxCostingPrice.Location = new Point(309, 390);
            txtBoxCostingPrice.Name = "txtBoxCostingPrice";
            txtBoxCostingPrice.Size = new Size(110, 25);
            txtBoxCostingPrice.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(290, 372);
            label8.Name = "label8";
            label8.Size = new Size(97, 17);
            label8.TabIndex = 43;
            label8.Text = "Costing Price :";
            // 
            // txtBoxProductNum
            // 
            txtBoxProductNum.BackColor = SystemColors.InactiveBorder;
            txtBoxProductNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductNum.ForeColor = Color.SteelBlue;
            txtBoxProductNum.Location = new Point(23, 256);
            txtBoxProductNum.Name = "txtBoxProductNum";
            txtBoxProductNum.Size = new Size(163, 25);
            txtBoxProductNum.TabIndex = 42;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.ForeColor = Color.SteelBlue;
            Quantity.Location = new Point(563, 373);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(66, 17);
            Quantity.TabIndex = 41;
            Quantity.Text = "Quantity:";
            // 
            // txtBoxSupplierName
            // 
            txtBoxSupplierName.BackColor = SystemColors.InactiveBorder;
            txtBoxSupplierName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSupplierName.ForeColor = Color.SteelBlue;
            txtBoxSupplierName.Location = new Point(23, 136);
            txtBoxSupplierName.Name = "txtBoxSupplierName";
            txtBoxSupplierName.Size = new Size(163, 25);
            txtBoxSupplierName.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(4, 233);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 39;
            label5.Text = "Product Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(4, 51);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 38;
            label2.Text = "Current Date:";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkSlateGray;
            label16.Location = new Point(287, 40);
            label16.Name = "label16";
            label16.Size = new Size(287, 42);
            label16.TabIndex = 12;
            label16.Text = "Purchase Order Details";
            // 
            // userctrlPurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label16);
            Controls.Add(groupBox1);
            Name = "userctrlPurchaseOrder";
            Size = new Size(866, 686);
            Load += userctrlPurchaseOrder_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label16;
        private TextBox txtBoxSellingPrice;
        private Label label9;
        private Label label1;
        private TextBox txtBoxProductName;
        private ComboBox cmbBoxPayment;
        private Label label7;
        private Label label3;
        private TextBox txtBoxPONum;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private Label label10;
        private Button btnRefresh;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxSubTotal;
        private Label label6;
        private TextBox txtBoxCostingPrice;
        private Label label8;
        private TextBox txtBoxProductNum;
        private Label Quantity;
        private TextBox txtBoxSupplierName;
        private Label label5;
        private Label label2;
        private TextBox txtBoxTotalAmount;
        private Label label13;
        private DateTimePicker dateTimePicker3;
        private Label label12;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private Button btnClear;
        private Button btnRemove;
        private Button btnAddinPurchase;
        private Button btnProceed;
    }
}
