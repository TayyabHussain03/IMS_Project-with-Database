namespace inventory_system.usercontrol
{
    partial class userctrlSignin
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
            txtaddress = new TextBox();
            label5 = new Label();
            txtcontact = new TextBox();
            label2 = new Label();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            name = new Label();
            label1 = new Label();
            btnsignup = new Button();
            txtusername = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtcontact);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnsignup);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 368);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // txtaddress
            // 
            txtaddress.BackColor = SystemColors.InactiveBorder;
            txtaddress.Location = new Point(139, 257);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(156, 26);
            txtaddress.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 257);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // txtcontact
            // 
            txtcontact.BackColor = SystemColors.InactiveBorder;
            txtcontact.Location = new Point(138, 215);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(156, 26);
            txtcontact.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 215);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 8;
            label2.Text = "Contact No";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveBorder;
            txtpassword.Location = new Point(137, 169);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(156, 26);
            txtpassword.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveBorder;
            txtemail.Location = new Point(137, 123);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(156, 26);
            txtemail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 169);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 123);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(31, 81);
            name.Name = "name";
            name.Size = new Size(46, 23);
            name.TabIndex = 3;
            name.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(100, 19);
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
            btnsignup.Location = new Point(112, 313);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(80, 40);
            btnsignup.TabIndex = 2;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.InactiveBorder;
            txtusername.Location = new Point(137, 79);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(156, 26);
            txtusername.TabIndex = 0;
            // 
            // userctrlSignin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "userctrlSignin";
            Size = new Size(333, 373);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtpassword;
        private TextBox txtemail;
        private Label label4;
        private Label label3;
        private Label name;
        private Label label1;
        private Button btnsignup;
        private TextBox txtusername;
        private TextBox txtaddress;
        private Label label5;
        private TextBox txtcontact;
        private Label label2;
    }
}
