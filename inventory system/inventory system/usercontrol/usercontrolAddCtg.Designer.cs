namespace inventory_system.usercontrol
{
    partial class usercontrolAddCtg
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
            btnAddCtg = new Button();
            txtCtgName = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtCtgDesc = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(btnAddCtg);
            groupBox1.Controls.Add(txtCtgName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCtgDesc);
            groupBox1.Location = new Point(170, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 482);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Category";
            // 
            // btnAddCtg
            // 
            btnAddCtg.BackColor = Color.CadetBlue;
            btnAddCtg.ForeColor = Color.White;
            btnAddCtg.Location = new Point(196, 423);
            btnAddCtg.Name = "btnAddCtg";
            btnAddCtg.Size = new Size(110, 43);
            btnAddCtg.TabIndex = 19;
            btnAddCtg.Text = "Add";
            btnAddCtg.UseVisualStyleBackColor = false;
            btnAddCtg.Click += btnAddCtg_Click_1;
            // 
            // txtCtgName
            // 
            txtCtgName.BackColor = SystemColors.InactiveBorder;
            txtCtgName.Location = new Point(20, 135);
            txtCtgName.Name = "txtCtgName";
            txtCtgName.Size = new Size(238, 23);
            txtCtgName.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(151, 19);
            label8.Name = "label8";
            label8.Size = new Size(179, 42);
            label8.TabIndex = 17;
            label8.Text = "Add Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 107);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 9;
            label4.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 182);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 5;
            label2.Text = "Description:";
            // 
            // txtCtgDesc
            // 
            txtCtgDesc.BackColor = SystemColors.InactiveBorder;
            txtCtgDesc.Location = new Point(20, 214);
            txtCtgDesc.Multiline = true;
            txtCtgDesc.Name = "txtCtgDesc";
            txtCtgDesc.Size = new Size(431, 135);
            txtCtgDesc.TabIndex = 4;
            // 
            // usercontrolAddCtg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "usercontrolAddCtg";
            Size = new Size(762, 660);
            Load += usercontrolAddCtg_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Button btnAddCtg;
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
        private TextBox txtCtgDesc;
        private TextBox txtCtgName;
    }
}
