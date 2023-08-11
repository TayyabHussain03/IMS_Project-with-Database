namespace inventory_system.usercontrol
{
    partial class usercontrolSales
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
            btnProceed = new Button();
            txtQuantity = new TextBox();
            label6 = new Label();
            txtItemRate = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtSellingPrice = new TextBox();
            Quantity = new Label();
            groupBox1 = new GroupBox();
            txtBoxCostingPrice = new TextBox();
            label12 = new Label();
            txtBoxSubtotal = new TextBox();
            label5 = new Label();
            btnRefresh = new Button();
            btnClear = new Button();
            btnGenerate = new Button();
            btnRemove = new Button();
            txtBoxTotalPrice = new TextBox();
            label3 = new Label();
            btnAddtoBasket = new Button();
            txtProductName = new TextBox();
            txtBoxProductNumber = new TextBox();
            label11 = new Label();
            dgvCartItems = new DataGridView();
            txtBoxInvoiceNum = new TextBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBoxCustomerName = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label4 = new Label();
            label1 = new Label();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).BeginInit();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Black;
            btnProceed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(556, 435);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(182, 45);
            btnProceed.TabIndex = 23;
            btnProceed.Text = "Proceded to Check";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.InactiveBorder;
            txtQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.ForeColor = Color.SteelBlue;
            txtQuantity.Location = new Point(506, 294);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(95, 25);
            txtQuantity.TabIndex = 17;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(492, 271);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 16;
            label6.Text = "Quantity :";
            // 
            // txtItemRate
            // 
            txtItemRate.BackColor = SystemColors.InactiveBorder;
            txtItemRate.ForeColor = Color.SteelBlue;
            txtItemRate.Location = new Point(524, 664);
            txtItemRate.Name = "txtItemRate";
            txtItemRate.Size = new Size(111, 23);
            txtItemRate.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(400, 666);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 12;
            label8.Text = "Sub Total : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(171, 271);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 10;
            label7.Text = "Product Name :";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.BackColor = SystemColors.InactiveBorder;
            txtSellingPrice.Enabled = false;
            txtSellingPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSellingPrice.ForeColor = Color.SteelBlue;
            txtSellingPrice.Location = new Point(389, 294);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(95, 25);
            txtSellingPrice.TabIndex = 9;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.ForeColor = Color.SteelBlue;
            Quantity.Location = new Point(375, 271);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(89, 20);
            Quantity.TabIndex = 8;
            Quantity.Text = "Unit Price : ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(txtBoxCostingPrice);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtBoxSubtotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(btnProceed);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(txtBoxTotalPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAddtoBasket);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtBoxProductNumber);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dgvCartItems);
            groupBox1.Controls.Add(txtBoxInvoiceNum);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtBoxCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSellingPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(10, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 502);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtBoxCostingPrice
            // 
            txtBoxCostingPrice.BackColor = SystemColors.InactiveBorder;
            txtBoxCostingPrice.Enabled = false;
            txtBoxCostingPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtBoxCostingPrice.ForeColor = Color.SteelBlue;
            txtBoxCostingPrice.Location = new Point(576, 360);
            txtBoxCostingPrice.Multiline = true;
            txtBoxCostingPrice.Name = "txtBoxCostingPrice";
            txtBoxCostingPrice.Size = new Size(153, 41);
            txtBoxCostingPrice.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(553, 332);
            label12.Name = "label12";
            label12.Size = new Size(156, 21);
            label12.TabIndex = 43;
            label12.Text = "Total Costing Price:";
            // 
            // txtBoxSubtotal
            // 
            txtBoxSubtotal.BackColor = SystemColors.InactiveBorder;
            txtBoxSubtotal.Enabled = false;
            txtBoxSubtotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSubtotal.ForeColor = Color.SteelBlue;
            txtBoxSubtotal.Location = new Point(634, 294);
            txtBoxSubtotal.Name = "txtBoxSubtotal";
            txtBoxSubtotal.Size = new Size(95, 25);
            txtBoxSubtotal.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(620, 271);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 41;
            label5.Text = "Subtotal :";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(262, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(96, 33);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RoyalBlue;
            btnClear.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(444, 359);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 42);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear Basket";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.RoyalBlue;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(172, 156);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(80, 26);
            btnGenerate.TabIndex = 38;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(319, 357);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 44);
            btnRemove.TabIndex = 37;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtBoxTotalPrice
            // 
            txtBoxTotalPrice.BackColor = SystemColors.InactiveBorder;
            txtBoxTotalPrice.Enabled = false;
            txtBoxTotalPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtBoxTotalPrice.ForeColor = Color.SteelBlue;
            txtBoxTotalPrice.Location = new Point(13, 360);
            txtBoxTotalPrice.Multiline = true;
            txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            txtBoxTotalPrice.Size = new Size(153, 41);
            txtBoxTotalPrice.TabIndex = 35;
            txtBoxTotalPrice.TextChanged += txtBoxTotalPrice_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(13, 332);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 34;
            label3.Text = "Total Amount:";
            // 
            // btnAddtoBasket
            // 
            btnAddtoBasket.BackColor = Color.ForestGreen;
            btnAddtoBasket.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddtoBasket.ForeColor = Color.White;
            btnAddtoBasket.Location = new Point(192, 357);
            btnAddtoBasket.Name = "btnAddtoBasket";
            btnAddtoBasket.Size = new Size(115, 44);
            btnAddtoBasket.TabIndex = 36;
            btnAddtoBasket.Text = "Add to Basket";
            btnAddtoBasket.UseVisualStyleBackColor = false;
            btnAddtoBasket.Click += btnAddtoBasket_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.InactiveBorder;
            txtProductName.Enabled = false;
            txtProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.ForeColor = Color.SteelBlue;
            txtProductName.Location = new Point(180, 294);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(190, 25);
            txtProductName.TabIndex = 33;
            // 
            // txtBoxProductNumber
            // 
            txtBoxProductNumber.BackColor = SystemColors.InactiveBorder;
            txtBoxProductNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductNumber.ForeColor = Color.SteelBlue;
            txtBoxProductNumber.Location = new Point(16, 294);
            txtBoxProductNumber.Name = "txtBoxProductNumber";
            txtBoxProductNumber.Size = new Size(150, 25);
            txtBoxProductNumber.TabIndex = 32;
            txtBoxProductNumber.TextChanged += txtBoxProductNumber_TextChanged;
            txtBoxProductNumber.KeyPress += txtBoxProductNumber_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(5, 271);
            label11.Name = "label11";
            label11.Size = new Size(131, 20);
            label11.TabIndex = 31;
            label11.Text = "Product Number:";
            // 
            // dgvCartItems
            // 
            dgvCartItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItems.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCartItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartItems.Location = new Point(262, 64);
            dgvCartItems.Name = "dgvCartItems";
            dgvCartItems.RowTemplate.Height = 25;
            dgvCartItems.Size = new Size(476, 189);
            dgvCartItems.TabIndex = 27;
            // 
            // txtBoxInvoiceNum
            // 
            txtBoxInvoiceNum.BackColor = SystemColors.InactiveBorder;
            txtBoxInvoiceNum.Enabled = false;
            txtBoxInvoiceNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInvoiceNum.ForeColor = Color.SteelBlue;
            txtBoxInvoiceNum.Location = new Point(16, 158);
            txtBoxInvoiceNum.Name = "txtBoxInvoiceNum";
            txtBoxInvoiceNum.Size = new Size(150, 25);
            txtBoxInvoiceNum.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(6, 135);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 28;
            label10.Text = "Invoice Number : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker1.CalendarTitleForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarTrailingForeColor = Color.SteelBlue;
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(16, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 23);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtBoxCustomerName
            // 
            txtBoxCustomerName.BackColor = SystemColors.InactiveBorder;
            txtBoxCustomerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCustomerName.ForeColor = Color.SteelBlue;
            txtBoxCustomerName.Location = new Point(16, 228);
            txtBoxCustomerName.Multiline = true;
            txtBoxCustomerName.Name = "txtBoxCustomerName";
            txtBoxCustomerName.Size = new Size(240, 25);
            txtBoxCustomerName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(4, 58);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Invoice Date : ";
            label2.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(5, 205);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 24;
            label9.Text = "Cutomer Name :";
            label9.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 433);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(336, 7);
            label1.Name = "label1";
            label1.Size = new Size(95, 50);
            label1.TabIndex = 26;
            label1.Text = "Sales";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Name";
            Column1.Name = "Column1";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Quantity";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // usercontrolSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtItemRate);
            Controls.Add(label8);
            Name = "usercontrolSales";
            Size = new Size(775, 664);
            Load += usercontrolSales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProceed;
        private TextBox txtQuantity;
        private Label label6;
        private TextBox txtItemRate;
        private Label label8;
        private Label label7;
        private TextBox txtSellingPrice;
        private Label Quantity;
        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtBoxCustomerName;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvCartItems;
        private Button btnRemove;
        private Button btnAddtoBasket;
        private TextBox txtBoxTotalPrice;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtBoxProductNumber;
        private Label label11;
        private TextBox txtBoxInvoiceNum;
        private Label label10;
        private Button btnGenerate;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnClear;
        private Button btnRefresh;
        private TextBox txtBoxSubtotal;
        private Label label5;
        private TextBox txtBoxCostingPrice;
        private Label label12;
    }
}
