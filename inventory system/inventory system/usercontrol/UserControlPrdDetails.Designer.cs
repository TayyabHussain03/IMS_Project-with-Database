namespace inventory_system.usercontrol
{
    partial class UserControlPrdDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPrdDetails));
            btnAddtoCart = new Button();
            label3 = new Label();
            label2 = new Label();
            txtProductName = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            txtBoxCostingPrice = new TextBox();
            txtBoxSellingPrice = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            lblCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.Red;
            btnAddtoCart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddtoCart.ForeColor = Color.White;
            btnAddtoCart.Location = new Point(611, 388);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(132, 44);
            btnAddtoCart.TabIndex = 29;
            btnAddtoCart.Text = "Add to Basket";
            btnAddtoCart.UseVisualStyleBackColor = false;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(411, 397);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 25;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(409, 312);
            label2.Margin = new Padding(3, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 24;
            label2.Text = "Selling Price";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FloralWhite;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.ForeColor = Color.DarkSlateGray;
            txtProductName.Location = new Point(409, 48);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(355, 71);
            txtProductName.TabIndex = 22;
            txtProductName.Text = "Sunsilk Shampoo 200ml | Hair Conditioner Shampoo";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(20, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAddtoCart);
            groupBox1.Controls.Add(txtBoxCostingPrice);
            groupBox1.Controls.Add(txtBoxSellingPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 446);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Myriad Pro", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(531, 148);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 33;
            label8.Text = "12345678";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(407, 147);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 32;
            label4.Text = "Product Number:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(460, 395);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(55, 29);
            numericUpDown1.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Myriad Pro", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(602, 342);
            label7.Name = "label7";
            label7.Size = new Size(32, 23);
            label7.TabIndex = 30;
            label7.Text = "Rs.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Myriad Pro", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(407, 343);
            label6.Name = "label6";
            label6.Size = new Size(32, 23);
            label6.TabIndex = 29;
            label6.Text = "Rs.";
            // 
            // txtBoxCostingPrice
            // 
            txtBoxCostingPrice.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxCostingPrice.Location = new Point(636, 342);
            txtBoxCostingPrice.Multiline = true;
            txtBoxCostingPrice.Name = "txtBoxCostingPrice";
            txtBoxCostingPrice.ReadOnly = true;
            txtBoxCostingPrice.Size = new Size(65, 23);
            txtBoxCostingPrice.TabIndex = 28;
            txtBoxCostingPrice.Text = "146";
            // 
            // txtBoxSellingPrice
            // 
            txtBoxSellingPrice.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSellingPrice.Location = new Point(441, 343);
            txtBoxSellingPrice.Multiline = true;
            txtBoxSellingPrice.Name = "txtBoxSellingPrice";
            txtBoxSellingPrice.ReadOnly = true;
            txtBoxSellingPrice.Size = new Size(74, 23);
            txtBoxSellingPrice.TabIndex = 27;
            txtBoxSellingPrice.Text = "146";
            txtBoxSellingPrice.TextChanged += txtBoxSellingPrice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(598, 312);
            label5.Margin = new Padding(3, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 26;
            label5.Text = "Costing Price";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FloralWhite;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.DarkSlateGray;
            txtDescription.Location = new Point(407, 199);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(355, 109);
            txtDescription.TabIndex = 25;
            txtDescription.Text = resources.GetString("txtDescription.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(407, 176);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 24;
            label1.Text = "Description :";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Myriad Pro", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = SystemColors.ButtonShadow;
            lblCategory.Location = new Point(409, 36);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 19);
            lblCategory.TabIndex = 23;
            lblCategory.Text = "BEDROOM";
            // 
            // UserControlPrdDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UserControlPrdDetails";
            Size = new Size(824, 478);
            Load += UserControlPrdDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddtoCart;
        private Label label3;
        private Label label2;
        private TextBox txtProductName;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private TextBox txtBoxCostingPrice;
        private TextBox txtBoxSellingPrice;
        private Label label5;
        private TextBox txtDescription;
        private Label label1;
        private Label lblCategory;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label4;
    }
}
