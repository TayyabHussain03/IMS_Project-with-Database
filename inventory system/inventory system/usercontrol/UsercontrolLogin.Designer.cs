namespace inventory_system.usercontrol
{
    partial class UsercontrolLogin
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
            txtemail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnlogin = new Button();
            txtpassword = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 368);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log In";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveBorder;
            txtemail.Location = new Point(137, 104);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(156, 26);
            txtemail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 168);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(88, 33);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 1;
            label1.Text = "Welcome Admin";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.CadetBlue;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(114, 259);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(80, 40);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "LogIn";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveBorder;
            txtpassword.Location = new Point(137, 168);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(156, 26);
            txtpassword.TabIndex = 8;
            // 
            // UsercontrolLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UsercontrolLogin";
            Size = new Size(334, 373);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtemail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnlogin;
        private TextBox txtpassword;
    }
}
