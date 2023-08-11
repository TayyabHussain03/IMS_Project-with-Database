namespace inventory_system
{
    partial class Login
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
            Togglebtn = new Button();
            signup = new Button();
            userctrlSignin1 = new usercontrol.userctrlSignin();
            usercontrolLogin1 = new usercontrol.UsercontrolLogin();
            SuspendLayout();
            // 
            // Togglebtn
            // 
            Togglebtn.BackColor = Color.FloralWhite;
            Togglebtn.Cursor = Cursors.Hand;
            Togglebtn.FlatAppearance.BorderSize = 0;
            Togglebtn.FlatStyle = FlatStyle.Flat;
            Togglebtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Togglebtn.ForeColor = Color.Black;
            Togglebtn.ImageAlign = ContentAlignment.MiddleLeft;
            Togglebtn.Location = new Point(1, 1);
            Togglebtn.Name = "Togglebtn";
            Togglebtn.Padding = new Padding(20, 0, 0, 0);
            Togglebtn.Size = new Size(165, 47);
            Togglebtn.TabIndex = 26;
            Togglebtn.Text = "         LOG IN";
            Togglebtn.TextAlign = ContentAlignment.MiddleLeft;
            Togglebtn.UseVisualStyleBackColor = false;
            Togglebtn.Click += Togglebtn_Click;
            // 
            // signup
            // 
            signup.BackColor = Color.White;
            signup.Cursor = Cursors.Hand;
            signup.FlatAppearance.BorderSize = 0;
            signup.FlatStyle = FlatStyle.Flat;
            signup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            signup.ForeColor = Color.Black;
            signup.ImageAlign = ContentAlignment.MiddleLeft;
            signup.Location = new Point(164, 1);
            signup.Name = "signup";
            signup.Padding = new Padding(20, 0, 0, 0);
            signup.Size = new Size(175, 47);
            signup.TabIndex = 27;
            signup.Text = "         SIGN IN";
            signup.TextAlign = ContentAlignment.MiddleLeft;
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // userctrlSignin1
            // 
            userctrlSignin1.Location = new Point(3, 49);
            userctrlSignin1.Name = "userctrlSignin1";
            userctrlSignin1.Size = new Size(333, 373);
            userctrlSignin1.TabIndex = 28;
            // 
            // usercontrolLogin1
            // 
            usercontrolLogin1.Location = new Point(3, 49);
            usercontrolLogin1.Name = "usercontrolLogin1";
            usercontrolLogin1.Size = new Size(334, 373);
            usercontrolLogin1.TabIndex = 29;
            usercontrolLogin1.Load += usercontrolLogin1_Load;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 437);
            Controls.Add(usercontrolLogin1);
            Controls.Add(userctrlSignin1);
            Controls.Add(signup);
            Controls.Add(Togglebtn);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Togglebtn;
        private Button signup;
        private usercontrol.userctrlSignin userctrlSignin1;
        private usercontrol.UsercontrolLogin usercontrolLogin1;
    }
}