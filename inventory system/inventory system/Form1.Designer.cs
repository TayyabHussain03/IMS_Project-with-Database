namespace inventory_system
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnsignup = new Button();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // btnsignup
            // 
            btnsignup.BackColor = SystemColors.ActiveCaption;
            btnsignup.Location = new Point(314, 96);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(121, 48);
            btnsignup.TabIndex = 0;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ActiveCaption;
            btnlogin.Location = new Point(314, 208);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(121, 48);
            btnlogin.TabIndex = 1;
            btnlogin.Text = "LogIn";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(btnsignup);
            Name = "index";
            Text = "Index";
            ResumeLayout(false);
        }

        #endregion

        private Button btnsignup;
        private Button btnlogin;
    }
}