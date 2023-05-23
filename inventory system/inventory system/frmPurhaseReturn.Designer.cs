namespace inventory_system
{
    partial class frmPurhaseReturn
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
            Quantity = new Label();
            cmbItemName = new ComboBox();
            txtQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnClearForm = new Button();
            txtBoxSubTotal = new TextBox();
            btnUpdateInventory = new Button();
            label14 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            txtBoxProductName = new TextBox();
            label11 = new Label();
            txtBoxProductID = new TextBox();
            label10 = new Label();
            cmbBoxPaymentType = new ComboBox();
            label6 = new Label();
            dateTimePickerCurrentDate = new DateTimePicker();
            label15 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.Location = new Point(304, 239);
            Quantity.Margin = new Padding(4, 0, 4, 0);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(88, 28);
            Quantity.TabIndex = 9;
            Quantity.Text = "Quantity";
            // 
            // cmbItemName
            // 
            cmbItemName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbItemName.FormattingEnabled = true;
            cmbItemName.Location = new Point(439, 184);
            cmbItemName.Margin = new Padding(4);
            cmbItemName.Name = "cmbItemName";
            cmbItemName.Size = new Size(285, 23);
            cmbItemName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(439, 244);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(127, 23);
            txtQuantity.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 401);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 5;
            label1.Text = "Item Name:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(btnClearForm);
            groupBox1.Controls.Add(txtBoxSubTotal);
            groupBox1.Controls.Add(btnUpdateInventory);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtBoxProductName);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtBoxProductID);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbBoxPaymentType);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePickerCurrentDate);
            groupBox1.Controls.Add(label15);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(62, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(886, 325);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchase Return";
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.Red;
            btnClearForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearForm.ForeColor = Color.White;
            btnClearForm.Location = new Point(496, 220);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(177, 44);
            btnClearForm.TabIndex = 19;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.Location = new Point(604, 123);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(114, 29);
            txtBoxSubTotal.TabIndex = 27;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdateInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInventory.ForeColor = Color.White;
            btnUpdateInventory.Location = new Point(233, 220);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(177, 44);
            btnUpdateInventory.TabIndex = 18;
            btnUpdateInventory.Text = "Update Inventory";
            btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(496, 130);
            label14.Name = "label14";
            label14.Size = new Size(80, 21);
            label14.TabIndex = 26;
            label14.Text = "Sub Total :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(788, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 29);
            textBox1.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(670, 76);
            label12.Name = "label12";
            label12.Size = new Size(106, 21);
            label12.TabIndex = 24;
            label12.Text = "Product Rate :";
            label12.Click += label12_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(616, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 29);
            textBox2.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(496, 76);
            label13.Name = "label13";
            label13.Size = new Size(100, 21);
            label13.TabIndex = 22;
            label13.Text = "Product Qty :";
            label13.Click += label13_Click;
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.Location = new Point(153, 123);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.Size = new Size(242, 29);
            txtBoxProductName.TabIndex = 21;
            txtBoxProductName.TextChanged += txtBoxProductName_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 130);
            label11.Name = "label11";
            label11.Size = new Size(117, 21);
            label11.TabIndex = 20;
            label11.Text = "Product Name :";
            // 
            // txtBoxProductID
            // 
            txtBoxProductID.Location = new Point(153, 76);
            txtBoxProductID.Name = "txtBoxProductID";
            txtBoxProductID.Size = new Size(242, 29);
            txtBoxProductID.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 83);
            label10.Name = "label10";
            label10.Size = new Size(90, 21);
            label10.TabIndex = 18;
            label10.Text = "Product ID :";
            label10.Click += label10_Click;
            // 
            // cmbBoxPaymentType
            // 
            cmbBoxPaymentType.FormattingEnabled = true;
            cmbBoxPaymentType.Items.AddRange(new object[] { "Cash", "Check" });
            cmbBoxPaymentType.Location = new Point(633, 30);
            cmbBoxPaymentType.Name = "cmbBoxPaymentType";
            cmbBoxPaymentType.Size = new Size(114, 29);
            cmbBoxPaymentType.TabIndex = 16;
            cmbBoxPaymentType.SelectedIndexChanged += cmbBoxPaymentType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 30);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 11;
            label6.Text = "Payment Type :";
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Location = new Point(153, 29);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.Size = new Size(242, 29);
            dateTimePickerCurrentDate.TabIndex = 4;
            dateTimePickerCurrentDate.ValueChanged += dateTimePickerCurrentDate_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(39, 30);
            label15.Name = "label15";
            label15.Size = new Size(106, 21);
            label15.TabIndex = 0;
            label15.Text = "Current Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(433, 66);
            label3.Name = "label3";
            label3.Size = new Size(225, 37);
            label3.TabIndex = 12;
            label3.Text = "Purchase Return";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // frmPurhaseReturn
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 600);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(Quantity);
            Controls.Add(cmbItemName);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPurhaseReturn";
            Text = "frmPurhaseReturn";
            Load += frmPurhaseReturn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Quantity;
        private ComboBox cmbItemName;
        private TextBox txtQuantity;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnClearForm;
        private TextBox txtBoxSubTotal;
        private Button btnUpdateInventory;
        private Label label14;
        private TextBox textBox1;
        private Label label12;
        private TextBox textBox2;
        private Label label13;
        private TextBox txtBoxProductName;
        private Label label11;
        private TextBox txtBoxProductID;
        private Label label10;
        private ComboBox cmbBoxPaymentType;
        private Label label6;
        private DateTimePicker dateTimePickerCurrentDate;
        private Label label15;
        private Label label3;
    }
}