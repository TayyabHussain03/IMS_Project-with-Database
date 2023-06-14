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
            label4 = new Label();
            btnBuyNow = new Button();
            btnAddtoCart = new Button();
            txtQuantity = new TextBox();
            btnAddQuantity = new Button();
            btnSubQuantity = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            txtProductName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(8, 606);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 31;
            label4.Text = "Copyright @ 2023";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuyNow
            // 
            btnBuyNow.BackColor = Color.Blue;
            btnBuyNow.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuyNow.ForeColor = Color.White;
            btnBuyNow.Location = new Point(500, 425);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.Size = new Size(132, 44);
            btnBuyNow.TabIndex = 30;
            btnBuyNow.Text = "Buy Now";
            btnBuyNow.UseVisualStyleBackColor = false;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.Red;
            btnAddtoCart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddtoCart.ForeColor = Color.White;
            btnAddtoCart.Location = new Point(346, 425);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(132, 44);
            btnAddtoCart.TabIndex = 29;
            btnAddtoCart.Text = "Add to Basket";
            btnAddtoCart.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Location = new Point(422, 357);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(23, 23);
            txtQuantity.TabIndex = 28;
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddQuantity
            // 
            btnAddQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQuantity.Location = new Point(449, 356);
            btnAddQuantity.Name = "btnAddQuantity";
            btnAddQuantity.Size = new Size(23, 25);
            btnAddQuantity.TabIndex = 27;
            btnAddQuantity.Text = "+";
            btnAddQuantity.TextAlign = ContentAlignment.TopCenter;
            btnAddQuantity.UseVisualStyleBackColor = true;
            // 
            // btnSubQuantity
            // 
            btnSubQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubQuantity.Location = new Point(395, 356);
            btnSubQuantity.Name = "btnSubQuantity";
            btnSubQuantity.Size = new Size(23, 25);
            btnSubQuantity.TabIndex = 26;
            btnSubQuantity.Text = "-";
            btnSubQuantity.TextAlign = ContentAlignment.TopCenter;
            btnSubQuantity.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(349, 356);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 25;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(346, 293);
            label2.Margin = new Padding(3, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 35);
            label2.TabIndex = 24;
            label2.Text = "Rs.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FloralWhite;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.SeaGreen;
            textBox1.Location = new Point(391, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 36);
            textBox1.TabIndex = 23;
            textBox1.Text = "400";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FloralWhite;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.ForeColor = Color.DarkSlateGray;
            txtProductName.Location = new Point(356, 187);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(278, 74);
            txtProductName.TabIndex = 22;
            txtProductName.Text = "Sunsilk Shampoo 200ml | Hair Conditioner Shampoo";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Sunsilk_Stunning_Black_Shine_Shampoo;
            pictureBox1.Location = new Point(8, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(286, 36);
            label1.Name = "label1";
            label1.Size = new Size(201, 42);
            label1.TabIndex = 32;
            label1.Text = "Prdoduct Detail";
            // 
            // UserControlPrdDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
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
            Name = "UserControlPrdDetails";
            Size = new Size(762, 660);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnBuyNow;
        private Button btnAddtoCart;
        private TextBox txtQuantity;
        private Button btnAddQuantity;
        private Button btnSubQuantity;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtProductName;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
