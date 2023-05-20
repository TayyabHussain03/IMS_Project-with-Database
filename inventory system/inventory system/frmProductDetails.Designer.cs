namespace inventory_system
{
    partial class frmProductDetails
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
            pictureBox1 = new PictureBox();
            txtProductName = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSubQuantity = new Button();
            btnAddQuantity = new Button();
            txtQuantity = new TextBox();
            btnAddtoCart = new Button();
            btnBuyNow = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(322, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 39);
            label1.TabIndex = 8;
            label1.Text = "Product Details";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Sunsilk_Stunning_Black_Shine_Shampoo;
            pictureBox1.Location = new Point(39, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FloralWhite;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.ForeColor = Color.DarkSlateGray;
            txtProductName.Location = new Point(418, 103);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(369, 86);
            txtProductName.TabIndex = 10;
            txtProductName.Text = "Sunsilk Shampoo 200ml | Hair Conditioner Shampoo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FloralWhite;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.SeaGreen;
            textBox1.Location = new Point(463, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 36);
            textBox1.TabIndex = 11;
            textBox1.Text = "400";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(418, 223);
            label2.Margin = new Padding(3, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 35);
            label2.TabIndex = 12;
            label2.Text = "Rs.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(418, 280);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 13;
            label3.Text = "Qty";
            // 
            // btnSubQuantity
            // 
            btnSubQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubQuantity.Location = new Point(467, 280);
            btnSubQuantity.Name = "btnSubQuantity";
            btnSubQuantity.Size = new Size(23, 25);
            btnSubQuantity.TabIndex = 14;
            btnSubQuantity.Text = "-";
            btnSubQuantity.TextAlign = ContentAlignment.TopCenter;
            btnSubQuantity.UseVisualStyleBackColor = true;
            // 
            // btnAddQuantity
            // 
            btnAddQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQuantity.Location = new Point(521, 280);
            btnAddQuantity.Name = "btnAddQuantity";
            btnAddQuantity.Size = new Size(23, 25);
            btnAddQuantity.TabIndex = 15;
            btnAddQuantity.Text = "+";
            btnAddQuantity.TextAlign = ContentAlignment.TopCenter;
            btnAddQuantity.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Location = new Point(494, 281);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(23, 23);
            txtQuantity.TabIndex = 16;
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.Red;
            btnAddtoCart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddtoCart.ForeColor = Color.White;
            btnAddtoCart.Location = new Point(418, 345);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(132, 44);
            btnAddtoCart.TabIndex = 17;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.UseVisualStyleBackColor = false;
            // 
            // btnBuyNow
            // 
            btnBuyNow.BackColor = Color.Blue;
            btnBuyNow.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuyNow.ForeColor = Color.White;
            btnBuyNow.Location = new Point(572, 345);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.Size = new Size(132, 44);
            btnBuyNow.TabIndex = 18;
            btnBuyNow.Text = "Buy Now";
            btnBuyNow.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(39, 488);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 19;
            label4.Text = "Copyright @ 2023";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(809, 514);
            Controls.Add(label4);
            Controls.Add(btnBuyNow);
            Controls.Add(btnAddtoCart);
            Controls.Add(txtQuantity);
            Controls.Add(btnAddQuantity);
            Controls.Add(btnSubQuantity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(txtProductName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmProductDetails";
            Text = "frmProductDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtProductName;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button btnSubQuantity;
        private Button btnAddQuantity;
        private TextBox txtQuantity;
        private Button btnAddtoCart;
        private Button btnBuyNow;
        private Label label4;
    }
}