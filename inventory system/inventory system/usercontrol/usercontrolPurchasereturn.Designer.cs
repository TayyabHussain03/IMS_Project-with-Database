namespace inventory_system.usercontrol
{
    partial class usercontrolPurchasereturn
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnRefresh = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtSubTotal = new TextBox();
            label6 = new Label();
            txtItemRate = new TextBox();
            label8 = new Label();
            txtItemName = new TextBox();
            Quantity = new Label();
            txtItemId = new TextBox();
            label5 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(284, 15);
            label10.Name = "label10";
            label10.Size = new Size(212, 42);
            label10.TabIndex = 46;
            label10.Text = "Purchase Return";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtSubTotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtItemRate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtItemName);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(txtItemId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(8, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 502);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchase Return";
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
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Please Select", "Last 7 Days", "Last 15 Days", "Last 1 Month", "Last 3 Month", "Last 6 Month", "Last 1 Year", "Last 2 Year", "Last 3 Year" });
            comboBox2.Location = new Point(599, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(130, 29);
            comboBox2.TabIndex = 34;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(244, 363);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(98, 25);
            numericUpDown1.TabIndex = 33;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.SteelBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Damaged", "Defected", "Not in Use", "Expired", "Inaccurate", "Broken", "Faulty", "Poor", "Duplicate", "Misfit", "Impaired", "Dissatisfied", "Inferior", "Unusable", "Unsatisfactory", "Mismatched", "Overstocked", "Unneeded", "Unwanted", "Incomplete", "Other..." });
            comboBox1.Location = new Point(25, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 25);
            comboBox1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(220, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(509, 245);
            dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(5, 155);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 31;
            label1.Text = "Supplier Name:";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(220, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(91, 33);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
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
            label3.Location = new Point(8, 236);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 29;
            label3.Text = "Reason :";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(400, 423);
            button1.Name = "button1";
            button1.Size = new Size(162, 44);
            button1.TabIndex = 23;
            button1.Text = "Clear Form";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(220, 423);
            button2.Name = "button2";
            button2.Size = new Size(162, 44);
            button2.TabIndex = 22;
            button2.Text = "Update Inventory";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.InactiveBorder;
            txtSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.ForeColor = Color.SteelBlue;
            txtSubTotal.Location = new Point(555, 362);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(141, 25);
            txtSubTotal.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(538, 335);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 16;
            label6.Text = "Total Amount:";
            // 
            // txtItemRate
            // 
            txtItemRate.BackColor = SystemColors.InactiveBorder;
            txtItemRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemRate.ForeColor = Color.SteelBlue;
            txtItemRate.Location = new Point(391, 362);
            txtItemRate.Name = "txtItemRate";
            txtItemRate.Size = new Size(118, 25);
            txtItemRate.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(365, 335);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 12;
            label8.Text = "Unit Price :";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.InactiveBorder;
            txtItemName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.ForeColor = Color.SteelBlue;
            txtItemName.Location = new Point(24, 363);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(163, 25);
            txtItemName.TabIndex = 11;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.ForeColor = Color.SteelBlue;
            Quantity.Location = new Point(220, 335);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(74, 20);
            Quantity.TabIndex = 8;
            Quantity.Text = "Quantity:";
            // 
            // txtItemId
            // 
            txtItemId.BackColor = SystemColors.InactiveBorder;
            txtItemId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemId.ForeColor = Color.SteelBlue;
            txtItemId.Location = new Point(24, 178);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(163, 25);
            txtItemId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(7, 340);
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
            // usercontrolPurchasereturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Name = "usercontrolPurchasereturn";
            Size = new Size(775, 664);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnRefresh;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox txtSubTotal;
        private Label label6;
        private TextBox txtItemRate;
        private Label label8;
        private TextBox txtItemName;
        private Label Quantity;
        private TextBox txtItemId;
        private Label label5;
        private Label label2;
    }
}
