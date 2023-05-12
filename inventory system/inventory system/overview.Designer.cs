namespace inventory_system
{
    partial class overview
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overview));
            sidebarContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            hamburgerBtn = new PictureBox();
            panel2 = new Panel();
            btnOverview = new Button();
            panel3 = new Panel();
            btnItems = new Button();
            panel4 = new Panel();
            btnCategory = new Button();
            panel5 = new Panel();
            btnProducts = new Button();
            userctrlSignin1 = new usercontrol.userctrlSignin();
            userctrlSignin2 = new usercontrol.userctrlSignin();
            panel6 = new Panel();
            userctrlLogin2 = new usercontrol.userctrlLogin();
            userctrlSignin4 = new usercontrol.userctrlSignin();
            userctrlSignin3 = new usercontrol.userctrlSignin();
            main_panel = new Panel();
            label2 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebarContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamburgerBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            main_panel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.CadetBlue;
            sidebarContainer.Controls.Add(panel1);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(panel3);
            sidebarContainer.Controls.Add(panel4);
            sidebarContainer.Controls.Add(panel5);
            sidebarContainer.Controls.Add(userctrlSignin1);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.Margin = new Padding(3, 2, 3, 2);
            sidebarContainer.MaximumSize = new Size(184, 526);
            sidebarContainer.MinimumSize = new Size(64, 526);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(184, 526);
            sidebarContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(hamburgerBtn);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // hamburgerBtn
            // 
            hamburgerBtn.Image = (Image)resources.GetObject("hamburgerBtn.Image");
            hamburgerBtn.Location = new Point(19, 12);
            hamburgerBtn.Name = "hamburgerBtn";
            hamburgerBtn.Size = new Size(24, 24);
            hamburgerBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            hamburgerBtn.TabIndex = 0;
            hamburgerBtn.TabStop = false;
            hamburgerBtn.Click += hamburgerBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnOverview);
            panel2.Location = new Point(3, 73);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30, 0, 0, 0);
            panel2.Size = new Size(168, 43);
            panel2.TabIndex = 1;
            // 
            // btnOverview
            // 
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOverview.ForeColor = Color.White;
            btnOverview.Image = (Image)resources.GetObject("btnOverview.Image");
            btnOverview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverview.Location = new Point(-7, -7);
            btnOverview.Name = "btnOverview";
            btnOverview.Padding = new Padding(20, 0, 0, 0);
            btnOverview.Size = new Size(199, 56);
            btnOverview.TabIndex = 2;
            btnOverview.Text = "          Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.UseVisualStyleBackColor = true;
            btnOverview.Click += btnOverview_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnItems);
            panel3.Location = new Point(3, 122);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30, 0, 0, 0);
            panel3.Size = new Size(168, 43);
            panel3.TabIndex = 2;
            // 
            // btnItems
            // 
            btnItems.FlatStyle = FlatStyle.Flat;
            btnItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnItems.ForeColor = Color.White;
            btnItems.Image = (Image)resources.GetObject("btnItems.Image");
            btnItems.ImageAlign = ContentAlignment.MiddleLeft;
            btnItems.Location = new Point(-7, -7);
            btnItems.Name = "btnItems";
            btnItems.Padding = new Padding(20, 0, 0, 0);
            btnItems.Size = new Size(199, 56);
            btnItems.TabIndex = 2;
            btnItems.Text = "          Items";
            btnItems.TextAlign = ContentAlignment.MiddleLeft;
            btnItems.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCategory);
            panel4.Location = new Point(3, 171);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30, 0, 0, 0);
            panel4.Size = new Size(168, 43);
            panel4.TabIndex = 3;
            // 
            // btnCategory
            // 
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.White;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(-7, -7);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(20, 0, 0, 0);
            btnCategory.Size = new Size(199, 56);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "          Sign Up";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnProducts);
            panel5.Location = new Point(3, 220);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30, 0, 0, 0);
            panel5.Size = new Size(168, 43);
            panel5.TabIndex = 4;
            // 
            // btnProducts
            // 
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(-7, -7);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(20, 0, 0, 0);
            btnProducts.Size = new Size(199, 56);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "          Login In";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // userctrlSignin1
            // 
            userctrlSignin1.Location = new Point(3, 269);
            userctrlSignin1.Name = "userctrlSignin1";
            userctrlSignin1.Size = new Size(17, 22);
            userctrlSignin1.TabIndex = 5;
            // 
            // userctrlSignin2
            // 
            userctrlSignin2.Location = new Point(-11, -3);
            userctrlSignin2.Name = "userctrlSignin2";
            userctrlSignin2.Size = new Size(646, 524);
            userctrlSignin2.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(userctrlSignin2);
            panel6.Controls.Add(userctrlLogin2);
            panel6.Controls.Add(userctrlSignin4);
            panel6.Controls.Add(userctrlSignin3);
            panel6.Location = new Point(190, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(646, 524);
            panel6.TabIndex = 1;
            // 
            // userctrlLogin2
            // 
            userctrlLogin2.Location = new Point(-3, -2);
            userctrlLogin2.Name = "userctrlLogin2";
            userctrlLogin2.Size = new Size(646, 524);
            userctrlLogin2.TabIndex = 6;
            // 
            // userctrlSignin4
            // 
            userctrlSignin4.Location = new Point(-3, -2);
            userctrlSignin4.Name = "userctrlSignin4";
            userctrlSignin4.Size = new Size(646, 524);
            userctrlSignin4.TabIndex = 9;
            // 
            // userctrlSignin3
            // 
            userctrlSignin3.Location = new Point(-3, -3);
            userctrlSignin3.Name = "userctrlSignin3";
            userctrlSignin3.Size = new Size(646, 524);
            userctrlSignin3.TabIndex = 9;
            // 
            // main_panel
            // 
            main_panel.BackColor = SystemColors.ControlLight;
            main_panel.Controls.Add(label2);
            main_panel.Location = new Point(187, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(646, 524);
            main_panel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(156, 37);
            label2.Name = "label2";
            label2.Size = new Size(343, 65);
            label2.TabIndex = 0;
            label2.Text = "OverView Page";
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 30;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // overview
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 526);
            Controls.Add(main_panel);
            Controls.Add(panel6);
            Controls.Add(sidebarContainer);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(853, 565);
            Name = "overview";
            Text = "overview";
            sidebarContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hamburgerBtn).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebarContainer;
        private Panel panel1;
        private Label label1;
        private PictureBox hamburgerBtn;
        private Panel panel2;
        private Button btnOverview;
        private Panel panel3;
        private Button btnItems;
        private Panel panel4;
        private Button btnCategory;
        private Button btnProducts;
        private Panel panel6;
        private usercontrol.userctrlSignin userctrlSignin2;
        private Panel panel5;
        private usercontrol.userctrlSignin userctrlSignin1;
        private usercontrol.userctrlLogin userctrlLogin2;
        private usercontrol.userctrlSignin userctrlSignin4;
        private usercontrol.userctrlSignin userctrlSignin3;
        private Panel main_panel;
        private Label label2;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}