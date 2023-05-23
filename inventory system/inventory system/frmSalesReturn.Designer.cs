namespace inventory_system
{
    partial class frmSalesReturn
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
            btnUpdateInventory = new Button();
            groupBox1 = new GroupBox();
            btnClearForm = new Button();
            txtSubTotal = new TextBox();
            label6 = new Label();
            cmbPaymentType = new ComboBox();
            label3 = new Label();
            txtItemRate = new TextBox();
            label8 = new Label();
            txtItemName = new TextBox();
            label7 = new Label();
            txtQuantity = new TextBox();
            Quantity = new Label();
            txtItemId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCurrentDate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(btnClearForm);
            groupBox1.Controls.Add(btnUpdateInventory);
            groupBox1.Controls.Add(txtSubTotal);
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
            groupBox1.Location = new Point(14, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 329);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales Return";
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
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.InactiveBorder;
            txtSubTotal.ForeColor = Color.SteelBlue;
            txtSubTotal.Location = new Point(524, 66);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(113, 27);
            txtSubTotal.TabIndex = 17;
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
            // 
            // txtItemRate
            // 
            txtItemRate.BackColor = SystemColors.InactiveBorder;
            txtItemRate.ForeColor = Color.SteelBlue;
            txtItemRate.Location = new Point(275, 156);
            txtItemRate.Name = "txtItemRate";
            txtItemRate.Size = new Size(107, 27);
            txtItemRate.TabIndex = 13;
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
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.InactiveBorder;
            txtQuantity.ForeColor = Color.SteelBlue;
            txtQuantity.Location = new Point(115, 155);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(45, 27);
            txtQuantity.TabIndex = 9;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 105);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // txtCurrentDate
            // 
            txtCurrentDate.BackColor = SystemColors.InactiveBorder;
            txtCurrentDate.ForeColor = Color.SteelBlue;
            txtCurrentDate.Location = new Point(115, 22);
            txtCurrentDate.Name = "txtCurrentDate";
            txtCurrentDate.Size = new Size(192, 27);
            txtCurrentDate.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(335, 36);
            label1.Name = "label1";
            label1.Size = new Size(217, 46);
            label1.TabIndex = 19;
            label1.Text = "Sales Return";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmSalesReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmSalesReturn";
            Text = "frmSalesReturn";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateInventory;
        private GroupBox groupBox1;
        private Button btnClearForm;
        private TextBox txtSubTotal;
        private Label label6;
        private ComboBox cmbPaymentType;
        private Label label3;
        private TextBox txtItemRate;
        private Label label8;
        private TextBox txtItemName;
        private Label label7;
        private TextBox txtQuantity;
        private Label Quantity;
        private TextBox txtItemId;
        private Label label5;
        private Label label4;
        private TextBox txtCurrentDate;
        private Label label2;
        private Label label1;
    }
}