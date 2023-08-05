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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddproduct));
            groupBox1 = new GroupBox();
            txtproductQuantity = new NumericUpDown();
            txtSellingPrice = new NumericUpDown();
            txtCostingPrice = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnImage = new Button();
            label8 = new Label();
            btnAddProduct = new Button();
            label7 = new Label();
            cmbproductCategory = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtproductNumber = new TextBox();
            label4 = new Label();
            txtproductName = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtproductQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSellingPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCostingPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(txtproductQuantity);
            groupBox1.Controls.Add(txtSellingPrice);
            groupBox1.Controls.Add(txtCostingPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnImage);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbproductCategory);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtproductNumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtproductName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(149, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 482);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtproductQuantity
            // 
            txtproductQuantity.BackColor = SystemColors.InactiveBorder;
            txtproductQuantity.Location = new Point(16, 235);
            txtproductQuantity.Name = "txtproductQuantity";
            txtproductQuantity.Size = new Size(156, 23);
            txtproductQuantity.TabIndex = 28;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.BackColor = SystemColors.InactiveBorder;
            txtSellingPrice.Location = new Point(295, 173);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(156, 23);
            txtSellingPrice.TabIndex = 27;
            txtSellingPrice.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // txtCostingPrice
            // 
            txtCostingPrice.BackColor = SystemColors.InactiveBorder;
            txtCostingPrice.Location = new Point(16, 173);
            txtCostingPrice.Name = "txtCostingPrice";
            txtCostingPrice.Size = new Size(156, 23);
            txtCostingPrice.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 147);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 24;
            label1.Text = "Selling Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 209);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 23;
            label3.Text = "Product Quantity:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.BackColor = SystemColors.InactiveBorder;
            btnImage.Location = new Point(23, 363);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(110, 30);
            btnImage.TabIndex = 5;
            btnImage.Text = "Choose File";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(151, 13);
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
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 274);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 15;
            label7.Text = "Product Image:";
            // 
            // cmbproductCategory
            // 
            cmbproductCategory.BackColor = SystemColors.InactiveBorder;
            cmbproductCategory.FormattingEnabled = true;
            cmbproductCategory.Items.AddRange(new object[] { "Karyana Items", "Kitchen Wares", "Bathroom Wares", "Crockery" });
            cmbproductCategory.Location = new Point(295, 235);
            cmbproductCategory.Name = "cmbproductCategory";
            cmbproductCategory.Size = new Size(156, 23);
            cmbproductCategory.TabIndex = 4;
            cmbproductCategory.SelectedIndexChanged += cmbproductCategory_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(295, 209);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 12;
            label6.Text = "Product Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 80);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 11;
            label5.Text = "Product Number:";
            // 
            // txtproductNumber
            // 
            txtproductNumber.BackColor = SystemColors.InactiveBorder;
            txtproductNumber.Location = new Point(16, 106);
            txtproductNumber.Name = "txtproductNumber";
            txtproductNumber.Size = new Size(156, 23);
            txtproductNumber.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(295, 80);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 9;
            label4.Text = "Product Name:";
            // 
            // txtproductName
            // 
            txtproductName.BackColor = SystemColors.InactiveBorder;
            txtproductName.Location = new Point(295, 106);
            txtproductName.Name = "txtproductName";
            txtproductName.Size = new Size(156, 23);
            txtproductName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 5;
            label2.Text = "Costing Price:";
            // 
            // UserControlAddproduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UserControlAddproduct";
            Size = new Size(762, 660);
            Load += UserControlAddproduct_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtproductQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSellingPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCostingPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddProduct;
        private Label label7;
        private ComboBox cmbproductCategory;
        private Label label6;
        private Label label5;
        private TextBox txtproductNumber;
        private Label label4;
        private TextBox txtproductName;
        private Label label2;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btnImage;
        private Label label3;
        private Label label1;
        private NumericUpDown txtSellingPrice;
        private NumericUpDown txtCostingPrice;
        private NumericUpDown txtproductQuantity;
    }
}
