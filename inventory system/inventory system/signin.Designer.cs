namespace inventory_system
{
    partial class signin
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
            txtusername = new TextBox();
            label1 = new Label();
            btnsignup = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveBorder;
            txtusername.Location = new Point(137, 104);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(156, 26);
            txtusername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(100, 22);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 1;
            label1.Text = "Hello Admin";
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.CadetBlue;
            btnsignup.Cursor = Cursors.Hand;
            btnsignup.FlatStyle = FlatStyle.Popup;
            btnsignup.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsignup.ForeColor = Color.White;
            btnsignup.Location = new Point(112, 291);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(80, 40);
            btnsignup.TabIndex = 2;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnsignup);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 368);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 106);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 167);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 227);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveBorder;
            txtemail.Location = new Point(137, 167);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(156, 26);
            txtemail.TabIndex = 6;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveBorder;
            txtpassword.Location = new Point(137, 227);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(156, 26);
            txtpassword.TabIndex = 7;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "signin";
            Text = "signin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtusername;
        private Label label1;
        private Button btnsignup;
        private GroupBox groupBox1;
        private TextBox txtpassword;
        private TextBox txtemail;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}