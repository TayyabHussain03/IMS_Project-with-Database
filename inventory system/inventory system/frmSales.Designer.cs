namespace inventory_system
{
    partial class frmSales
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
            label1 = new Label();
            label2 = new Label();
            txtCurrentDate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtItemId = new TextBox();
            Quantity = new Label();
            txtQuantity = new TextBox();
            label7 = new Label();
            txtItemName = new TextBox();
            label8 = new Label();
            txtItemRate = new TextBox();
            label3 = new Label();
            cmbPaymentType = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnClearForm = new Button();
            btnUpdateInventory = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(365, 18);
            label1.Name = "label1";
            label1.Size = new Size(100, 46);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Current Date:";
            // 
            // txtCurrentDate
            // 
            txtCurrentDate.BackColor = SystemColors.InactiveBorder;
            txtCurrentDate.ForeColor = Color.SteelBlue;
            txtCurrentDate.Location = new Point(115, 22);
            txtCurrentDate.Name = "txtCurrentDate";
            txtCurrentDate.Size = new Size(192, 27);
            txtCurrentDate.TabIndex = 2;
            txtCurrentDate.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 105);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(6, 108);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 5;
            label5.Text = "Item Name:";
            // 
            // txtItemId
            // 
            txtItemId.BackColor = SystemColors.InactiveBorder;
            txtItemId.ForeColor = Color.SteelBlue;
            txtItemId.Location = new Point(115, 62);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(192, 27);
            txtItemId.TabIndex = 7;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.ForeColor = Color.SteelBlue;
            Quantity.Location = new Point(18, 159);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(74, 20);
            Quantity.TabIndex = 8;
            Quantity.Text = "Quantity:";
            Quantity.Click += Quantity_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.InactiveBorder;
            txtQuantity.ForeColor = Color.SteelBlue;
            txtQuantity.Location = new Point(115, 155);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(45, 27);
            txtQuantity.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(30, 65);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 10;
            label7.Text = "Item ID";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.InactiveBorder;
            txtItemName.ForeColor = Color.SteelBlue;
            txtItemName.Location = new Point(115, 105);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(192, 27);
            txtItemName.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(193, 158);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 12;
            label8.Text = "Item Rate :";
            label8.Click += label8_Click;
            // 
            // txtItemRate
            // 
            txtItemRate.BackColor = SystemColors.InactiveBorder;
            txtItemRate.ForeColor = Color.SteelBlue;
            txtItemRate.Location = new Point(275, 156);
            txtItemRate.Name = "txtItemRate";
            txtItemRate.Size = new Size(107, 27);
            txtItemRate.TabIndex = 13;
            txtItemRate.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(406, 25);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 14;
            label3.Text = "Payment Type:";
            label3.Click += label3_Click;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.BackColor = SystemColors.InactiveBorder;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(524, 22);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(188, 28);
            cmbPaymentType.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(426, 69);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 16;
            label6.Text = "Sub Total:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(524, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 27);
            textBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(btnClearForm);
            groupBox1.Controls.Add(btnUpdateInventory);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbPaymentType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtItemRate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtItemName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(txtItemId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCurrentDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 329);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales";
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.Red;
            btnClearForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearForm.ForeColor = Color.White;
            btnClearForm.Location = new Point(415, 265);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(157, 44);
            btnClearForm.TabIndex = 21;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdateInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInventory.ForeColor = Color.White;
            btnUpdateInventory.Location = new Point(211, 265);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(157, 44);
            btnUpdateInventory.TabIndex = 20;
            btnUpdateInventory.Text = "Update Inventory";
            btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmSales";
            Text = "frmSales";
            Load += frmSales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCurrentDate;
        private Label label4;
        private Label label5;
        private TextBox txtItemId;
        private Label Quantity;
        private TextBox txtQuantity;
        private Label label7;
        private TextBox txtItemName;
        private Label label8;
        private TextBox txtItemRate;
        private Label label3;
        private ComboBox cmbPaymentType;
        private Label label6;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnClearForm;
        private Button btnUpdateInventory;
    }
}