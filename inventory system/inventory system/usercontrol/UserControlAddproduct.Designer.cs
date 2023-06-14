namespace inventory_system.usercontrol
{
    partial class UserControlAddproduct
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
            label8 = new Label();
            btnAddProduct = new Button();
            label7 = new Label();
            btnChooseProduct = new Button();
            cmbproductCategory = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtproductID = new TextBox();
            label4 = new Label();
            txtproductName = new TextBox();
            label3 = new Label();
            txtproductQuantity = new TextBox();
            label2 = new Label();
            txtproductPrice = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnChooseProduct);
            groupBox1.Controls.Add(cmbproductCategory);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtproductID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtproductName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtproductQuantity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtproductPrice);
            groupBox1.Location = new Point(149, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 482);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(151, 19);
            label8.Name = "label8";
            label8.Size = new Size(163, 42);
            label8.TabIndex = 17;
            label8.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.CadetBlue;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(184, 423);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(110, 43);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 333);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 15;
            label7.Text = "Product Image:";
            // 
            // btnChooseProduct
            // 
            btnChooseProduct.BackColor = SystemColors.InactiveBorder;
            btnChooseProduct.Location = new Point(20, 369);
            btnChooseProduct.Name = "btnChooseProduct";
            btnChooseProduct.Size = new Size(110, 23);
            btnChooseProduct.TabIndex = 14;
            btnChooseProduct.Text = "Choose File";
            btnChooseProduct.UseVisualStyleBackColor = false;
            // 
            // cmbproductCategory
            // 
            cmbproductCategory.BackColor = SystemColors.InactiveBorder;
            cmbproductCategory.FormattingEnabled = true;
            cmbproductCategory.Items.AddRange(new object[] { "Karyana Items", "Kitchen Wares", "Bathroom Wares", "Crockery" });
            cmbproductCategory.Location = new Point(20, 275);
            cmbproductCategory.Name = "cmbproductCategory";
            cmbproductCategory.Size = new Size(431, 23);
            cmbproductCategory.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 241);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 12;
            label6.Text = "Product Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 88);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 11;
            label5.Text = "Product ID:";
            // 
            // txtproductID
            // 
            txtproductID.BackColor = SystemColors.InactiveBorder;
            txtproductID.Location = new Point(16, 114);
            txtproductID.Name = "txtproductID";
            txtproductID.Size = new Size(156, 23);
            txtproductID.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(295, 88);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 9;
            label4.Text = "Product Name:";
            // 
            // txtproductName
            // 
            txtproductName.BackColor = SystemColors.InactiveBorder;
            txtproductName.Location = new Point(295, 114);
            txtproductName.Name = "txtproductName";
            txtproductName.Size = new Size(156, 23);
            txtproductName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 162);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 7;
            label3.Text = "Product Quantity:";
            // 
            // txtproductQuantity
            // 
            txtproductQuantity.BackColor = SystemColors.InactiveBorder;
            txtproductQuantity.Location = new Point(16, 188);
            txtproductQuantity.Name = "txtproductQuantity";
            txtproductQuantity.Size = new Size(156, 23);
            txtproductQuantity.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 162);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 5;
            label2.Text = "Product Price:";
            // 
            // txtproductPrice
            // 
            txtproductPrice.BackColor = SystemColors.InactiveBorder;
            txtproductPrice.Location = new Point(295, 188);
            txtproductPrice.Name = "txtproductPrice";
            txtproductPrice.Size = new Size(156, 23);
            txtproductPrice.TabIndex = 4;
            // 
            // UserControlAddproduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UserControlAddproduct";
            Size = new Size(762, 660);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddProduct;
        private Label label7;
        private Button btnChooseProduct;
        private ComboBox cmbproductCategory;
        private Label label6;
        private Label label5;
        private TextBox txtproductID;
        private Label label4;
        private TextBox txtproductName;
        private Label label3;
        private TextBox txtproductQuantity;
        private Label label2;
        private TextBox txtproductPrice;
        private Label label8;
    }
}
