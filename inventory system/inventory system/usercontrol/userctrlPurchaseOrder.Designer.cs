﻿namespace inventory_system.usercontrol
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
            label15 = new Label();
            textBox3 = new TextBox();
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
            dateTimePickerDateReceived = new DateTimePicker();
            cmbBoxPaymentType = new ComboBox();
            txtBoxVendorName = new TextBox();
            dateTimePickerExpectedDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBoxCreatedBy = new TextBox();
            txtBoxPurchaseOrderNumber = new TextBox();
            dateTimePickerCreationDate = new DateTimePicker();
            dateTimePickerCurrentDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            label16 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(textBox3);
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
            groupBox1.Controls.Add(dateTimePickerDateReceived);
            groupBox1.Controls.Add(cmbBoxPaymentType);
            groupBox1.Controls.Add(txtBoxVendorName);
            groupBox1.Controls.Add(dateTimePickerExpectedDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBoxCreatedBy);
            groupBox1.Controls.Add(txtBoxPurchaseOrderNumber);
            groupBox1.Controls.Add(dateTimePickerCreationDate);
            groupBox1.Controls.Add(dateTimePickerCurrentDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(70, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 325);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 34);
            label15.Name = "label15";
            label15.Size = new Size(88, 15);
            label15.TabIndex = 29;
            label15.Text = "Expected Date :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(542, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 23);
            textBox3.TabIndex = 28;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.DarkRed;
            btnClearForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearForm.ForeColor = Color.White;
            btnClearForm.Location = new Point(318, 266);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(152, 44);
            btnClearForm.TabIndex = 19;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.Location = new Point(422, 224);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(160, 23);
            txtBoxSubTotal.TabIndex = 27;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.BackColor = Color.ForestGreen;
            btnUpdateInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInventory.ForeColor = Color.White;
            btnUpdateInventory.Location = new Point(134, 266);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(152, 44);
            btnUpdateInventory.TabIndex = 18;
            btnUpdateInventory.Text = "Update Inventory";
            btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(318, 224);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 26;
            label14.Text = "Sub Total :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(656, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 23);
            textBox1.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 190);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 24;
            label12.Text = "Product Rate :";
            label12.Click += label12_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(477, 190);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 22;
            label13.Text = "Quantity :";
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.Location = new Point(123, 225);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.Size = new Size(160, 23);
            txtBoxProductName.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 228);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 20;
            label11.Text = "Product Name :";
            // 
            // txtBoxProductID
            // 
            txtBoxProductID.Location = new Point(123, 186);
            txtBoxProductID.Name = "txtBoxProductID";
            txtBoxProductID.Size = new Size(160, 23);
            txtBoxProductID.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 189);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 18;
            label10.Text = "Product ID :";
            // 
            // dateTimePickerDateReceived
            // 
            dateTimePickerDateReceived.Format = DateTimePickerFormat.Short;
            dateTimePickerDateReceived.Location = new Point(422, 107);
            dateTimePickerDateReceived.Name = "dateTimePickerDateReceived";
            dateTimePickerDateReceived.Size = new Size(160, 23);
            dateTimePickerDateReceived.TabIndex = 17;
            // 
            // cmbBoxPaymentType
            // 
            cmbBoxPaymentType.FormattingEnabled = true;
            cmbBoxPaymentType.Items.AddRange(new object[] { "Cash", "Check" });
            cmbBoxPaymentType.Location = new Point(422, 146);
            cmbBoxPaymentType.Name = "cmbBoxPaymentType";
            cmbBoxPaymentType.Size = new Size(160, 23);
            cmbBoxPaymentType.TabIndex = 16;
            // 
            // txtBoxVendorName
            // 
            txtBoxVendorName.Location = new Point(422, 69);
            txtBoxVendorName.Name = "txtBoxVendorName";
            txtBoxVendorName.Size = new Size(160, 23);
            txtBoxVendorName.TabIndex = 14;
            // 
            // dateTimePickerExpectedDate
            // 
            dateTimePickerExpectedDate.Format = DateTimePickerFormat.Short;
            dateTimePickerExpectedDate.Location = new Point(422, 30);
            dateTimePickerExpectedDate.Name = "dateTimePickerExpectedDate";
            dateTimePickerExpectedDate.Size = new Size(160, 23);
            dateTimePickerExpectedDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 146);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 11;
            label6.Text = "Payment Type :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(318, 110);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 10;
            label7.Text = "Date Received :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 72);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 9;
            label8.Text = "Vendor Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 31);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 8;
            label9.Text = "Expected Date :";
            // 
            // txtBoxCreatedBy
            // 
            txtBoxCreatedBy.Location = new Point(123, 110);
            txtBoxCreatedBy.Name = "txtBoxCreatedBy";
            txtBoxCreatedBy.Size = new Size(160, 23);
            txtBoxCreatedBy.TabIndex = 7;
            // 
            // txtBoxPurchaseOrderNumber
            // 
            txtBoxPurchaseOrderNumber.Location = new Point(123, 72);
            txtBoxPurchaseOrderNumber.Name = "txtBoxPurchaseOrderNumber";
            txtBoxPurchaseOrderNumber.Size = new Size(160, 23);
            txtBoxPurchaseOrderNumber.TabIndex = 6;
            // 
            // dateTimePickerCreationDate
            // 
            dateTimePickerCreationDate.Format = DateTimePickerFormat.Short;
            dateTimePickerCreationDate.Location = new Point(123, 143);
            dateTimePickerCreationDate.Name = "dateTimePickerCreationDate";
            dateTimePickerCreationDate.Size = new Size(160, 23);
            dateTimePickerCreationDate.TabIndex = 5;
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerCurrentDate.Location = new Point(123, 33);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.Size = new Size(160, 23);
            dateTimePickerCurrentDate.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 149);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 3;
            label5.Text = "Creation Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 113);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 2;
            label4.Text = "Created By :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 75);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "PO Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 34);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Current Date :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(70, 473);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(612, 139);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Purchase Order Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(606, 111);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            label16.Location = new Point(245, 33);
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
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "userctrlPurchaseOrder";
            Size = new Size(762, 660);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DateTimePicker dateTimePickerDateReceived;
        private ComboBox cmbBoxPaymentType;
        private TextBox txtBoxVendorName;
        private DateTimePicker dateTimePickerExpectedDate;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBoxCreatedBy;
        private TextBox txtBoxPurchaseOrderNumber;
        private DateTimePicker dateTimePickerCreationDate;
        private DateTimePicker dateTimePickerCurrentDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox textBox3;
        private Label label15;
        private Label label16;
    }
}
