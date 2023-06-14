namespace inventory_system
{
    partial class dashboard
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
            usercontrolPurchasereturn1 = new usercontrol.usercontrolPurchasereturn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnLogout = new Button();
            siderbarTimer = new System.Windows.Forms.Timer(components);
            panel7 = new Panel();
            btnAnalysis = new Button();
            panel5 = new Panel();
            btnStock = new Button();
            btnYearlySales = new Button();
            btnMonthlySales = new Button();
            btnDailySales = new Button();
            panel6 = new Panel();
            btnReport = new Button();
            btnSalesReturn = new Button();
            panel4 = new Panel();
            btnSale = new Button();
            btnPurchaseReturn = new Button();
            panel3 = new Panel();
            btnPurchases = new Button();
            btnProductDetails = new Button();
            btnProductTypes = new Button();
            btnProductCategory = new Button();
            panel2 = new Panel();
            products = new Button();
            panel1 = new Panel();
            label1 = new Label();
            menubtn = new PictureBox();
            sidebar = new FlowLayoutPanel();
            button1 = new Button();
            userctrlanalysis1 = new userctrlanalysis();
            useryearlysale1 = new usercontrol.useryearlysale();
            usermonthlysale1 = new usercontrol.usermonthlysale();
            userctrldailysale1 = new userctrldailysale();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubtn).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // usercontrolPurchasereturn1
            // 
            usercontrolPurchasereturn1.Location = new Point(427, 307);
            usercontrolPurchasereturn1.Name = "usercontrolPurchasereturn1";
            usercontrolPurchasereturn1.Size = new Size(8, 8);
            usercontrolPurchasereturn1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(35, 59, 59);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(738, -202);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(124, 47);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "        Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // siderbarTimer
            // 
            siderbarTimer.Interval = 20;
            siderbarTimer.Tick += siderbarTimer_Tick;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(35, 59, 59);
            panel7.Controls.Add(btnAnalysis);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(3, 593);
            panel7.Name = "panel7";
            panel7.Size = new Size(232, 34);
            panel7.TabIndex = 6;
            // 
            // btnAnalysis
            // 
            btnAnalysis.FlatStyle = FlatStyle.Flat;
            btnAnalysis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalysis.ForeColor = Color.FromArgb(224, 224, 224);
            btnAnalysis.Image = Properties.Resources.icons8_graph_report_241;
            btnAnalysis.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalysis.Location = new Point(-10, -12);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Padding = new Padding(35, 0, 0, 0);
            btnAnalysis.Size = new Size(253, 57);
            btnAnalysis.TabIndex = 1;
            btnAnalysis.Text = "              Analysis";
            btnAnalysis.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalysis.UseVisualStyleBackColor = true;
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 59, 59);
            panel5.Controls.Add(btnStock);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(3, 553);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 34);
            panel5.TabIndex = 4;
            // 
            // btnStock
            // 
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStock.ForeColor = Color.FromArgb(224, 224, 224);
            btnStock.Image = Properties.Resources.icons8_stock_24;
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(-10, -12);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(35, 0, 0, 0);
            btnStock.Size = new Size(253, 57);
            btnStock.TabIndex = 1;
            btnStock.Text = "              Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = true;
            // 
            // btnYearlySales
            // 
            btnYearlySales.BackColor = Color.DarkSlateGray;
            btnYearlySales.FlatAppearance.BorderSize = 0;
            btnYearlySales.FlatStyle = FlatStyle.Flat;
            btnYearlySales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnYearlySales.ForeColor = Color.FromArgb(224, 224, 224);
            btnYearlySales.Image = Properties.Resources.icons8_dot_16;
            btnYearlySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnYearlySales.Location = new Point(3, 511);
            btnYearlySales.Name = "btnYearlySales";
            btnYearlySales.Padding = new Padding(35, 0, 0, 0);
            btnYearlySales.Size = new Size(227, 36);
            btnYearlySales.TabIndex = 8;
            btnYearlySales.Text = "              Yearly Sales";
            btnYearlySales.TextAlign = ContentAlignment.MiddleLeft;
            btnYearlySales.UseVisualStyleBackColor = false;
            btnYearlySales.Click += btnYearlySales_Click;
            // 
            // btnMonthlySales
            // 
            btnMonthlySales.BackColor = Color.DarkSlateGray;
            btnMonthlySales.FlatAppearance.BorderSize = 0;
            btnMonthlySales.FlatStyle = FlatStyle.Flat;
            btnMonthlySales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonthlySales.ForeColor = Color.FromArgb(224, 224, 224);
            btnMonthlySales.Image = Properties.Resources.icons8_dot_16;
            btnMonthlySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonthlySales.Location = new Point(3, 469);
            btnMonthlySales.Name = "btnMonthlySales";
            btnMonthlySales.Padding = new Padding(35, 0, 0, 0);
            btnMonthlySales.Size = new Size(227, 36);
            btnMonthlySales.TabIndex = 7;
            btnMonthlySales.Text = "              Monthly Sales";
            btnMonthlySales.TextAlign = ContentAlignment.MiddleLeft;
            btnMonthlySales.UseVisualStyleBackColor = false;
            btnMonthlySales.Click += btnMonthlySales_Click;
            // 
            // btnDailySales
            // 
            btnDailySales.BackColor = Color.DarkSlateGray;
            btnDailySales.FlatAppearance.BorderSize = 0;
            btnDailySales.FlatStyle = FlatStyle.Flat;
            btnDailySales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDailySales.ForeColor = Color.FromArgb(224, 224, 224);
            btnDailySales.Image = Properties.Resources.icons8_dot_16;
            btnDailySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnDailySales.Location = new Point(3, 427);
            btnDailySales.Name = "btnDailySales";
            btnDailySales.Padding = new Padding(35, 0, 0, 0);
            btnDailySales.Size = new Size(227, 36);
            btnDailySales.TabIndex = 6;
            btnDailySales.Text = "              Daily Sales";
            btnDailySales.TextAlign = ContentAlignment.MiddleLeft;
            btnDailySales.UseVisualStyleBackColor = false;
            btnDailySales.Click += btnDailySales_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 59, 59);
            panel6.Controls.Add(btnReport);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(3, 387);
            panel6.Name = "panel6";
            panel6.Size = new Size(232, 34);
            panel6.TabIndex = 5;
            // 
            // btnReport
            // 
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.FromArgb(224, 224, 224);
            btnReport.Image = Properties.Resources.icons8_graph_report_24;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-10, -12);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(35, 0, 0, 0);
            btnReport.Size = new Size(253, 57);
            btnReport.TabIndex = 1;
            btnReport.Text = "              Reports";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnSalesReturn
            // 
            btnSalesReturn.BackColor = Color.DarkSlateGray;
            btnSalesReturn.FlatAppearance.BorderSize = 0;
            btnSalesReturn.FlatStyle = FlatStyle.Flat;
            btnSalesReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalesReturn.ForeColor = Color.FromArgb(224, 224, 224);
            btnSalesReturn.Image = Properties.Resources.icons8_dot_16;
            btnSalesReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalesReturn.Location = new Point(3, 345);
            btnSalesReturn.Name = "btnSalesReturn";
            btnSalesReturn.Padding = new Padding(35, 0, 0, 0);
            btnSalesReturn.Size = new Size(227, 36);
            btnSalesReturn.TabIndex = 5;
            btnSalesReturn.Text = "              Sales Return";
            btnSalesReturn.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesReturn.UseVisualStyleBackColor = false;
            btnSalesReturn.Click += btnSalesReturn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSale);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(3, 305);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 34);
            panel4.TabIndex = 3;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.FromArgb(35, 59, 59);
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSale.ForeColor = Color.FromArgb(224, 224, 224);
            btnSale.Image = Properties.Resources.icons8_sale_24;
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(-10, -12);
            btnSale.Name = "btnSale";
            btnSale.Padding = new Padding(35, 0, 0, 0);
            btnSale.Size = new Size(253, 57);
            btnSale.TabIndex = 1;
            btnSale.Text = "              Sale";
            btnSale.TextAlign = ContentAlignment.MiddleLeft;
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // btnPurchaseReturn
            // 
            btnPurchaseReturn.BackColor = Color.DarkSlateGray;
            btnPurchaseReturn.FlatAppearance.BorderSize = 0;
            btnPurchaseReturn.FlatStyle = FlatStyle.Flat;
            btnPurchaseReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPurchaseReturn.ForeColor = Color.FromArgb(224, 224, 224);
            btnPurchaseReturn.Image = Properties.Resources.icons8_dot_16;
            btnPurchaseReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchaseReturn.Location = new Point(3, 263);
            btnPurchaseReturn.Name = "btnPurchaseReturn";
            btnPurchaseReturn.Padding = new Padding(35, 0, 0, 0);
            btnPurchaseReturn.Size = new Size(227, 36);
            btnPurchaseReturn.TabIndex = 4;
            btnPurchaseReturn.Text = "              Purchase Return";
            btnPurchaseReturn.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchaseReturn.UseVisualStyleBackColor = false;
            btnPurchaseReturn.Click += btnPurchaseReturn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPurchases);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(3, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 34);
            panel3.TabIndex = 2;
            // 
            // btnPurchases
            // 
            btnPurchases.BackColor = Color.FromArgb(35, 59, 59);
            btnPurchases.FlatStyle = FlatStyle.Flat;
            btnPurchases.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPurchases.ForeColor = Color.FromArgb(224, 224, 224);
            btnPurchases.Image = Properties.Resources.icons8_purchases_24;
            btnPurchases.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchases.Location = new Point(-10, -12);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Padding = new Padding(35, 0, 0, 0);
            btnPurchases.Size = new Size(253, 57);
            btnPurchases.TabIndex = 1;
            btnPurchases.Text = "              Purchases";
            btnPurchases.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchases.UseVisualStyleBackColor = false;
            btnPurchases.Click += btnPurchases_Click;
            // 
            // btnProductDetails
            // 
            btnProductDetails.BackColor = Color.DarkSlateGray;
            btnProductDetails.FlatAppearance.BorderSize = 0;
            btnProductDetails.FlatStyle = FlatStyle.Flat;
            btnProductDetails.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductDetails.ForeColor = Color.FromArgb(224, 224, 224);
            btnProductDetails.Image = Properties.Resources.icons8_dot_16;
            btnProductDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductDetails.Location = new Point(3, 181);
            btnProductDetails.Name = "btnProductDetails";
            btnProductDetails.Padding = new Padding(35, 0, 0, 0);
            btnProductDetails.Size = new Size(227, 36);
            btnProductDetails.TabIndex = 3;
            btnProductDetails.Text = "              Product Details";
            btnProductDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnProductDetails.UseVisualStyleBackColor = false;
            btnProductDetails.Click += btnProductDetails_Click;
            // 
            // btnProductTypes
            // 
            btnProductTypes.BackColor = Color.DarkSlateGray;
            btnProductTypes.FlatAppearance.BorderSize = 0;
            btnProductTypes.FlatStyle = FlatStyle.Flat;
            btnProductTypes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductTypes.ForeColor = Color.FromArgb(224, 224, 224);
            btnProductTypes.Image = Properties.Resources.icons8_dot_16;
            btnProductTypes.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductTypes.Location = new Point(3, 139);
            btnProductTypes.Name = "btnProductTypes";
            btnProductTypes.Padding = new Padding(35, 0, 0, 0);
            btnProductTypes.Size = new Size(227, 36);
            btnProductTypes.TabIndex = 2;
            btnProductTypes.Text = "              Product Types";
            btnProductTypes.TextAlign = ContentAlignment.MiddleLeft;
            btnProductTypes.UseVisualStyleBackColor = false;
            btnProductTypes.Click += btnProductTypes_Click;
            // 
            // btnProductCategory
            // 
            btnProductCategory.BackColor = Color.DarkSlateGray;
            btnProductCategory.FlatAppearance.BorderSize = 0;
            btnProductCategory.FlatStyle = FlatStyle.Flat;
            btnProductCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductCategory.ForeColor = Color.FromArgb(224, 224, 224);
            btnProductCategory.Image = Properties.Resources.icons8_dot_16;
            btnProductCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductCategory.Location = new Point(3, 97);
            btnProductCategory.Name = "btnProductCategory";
            btnProductCategory.Padding = new Padding(35, 0, 0, 0);
            btnProductCategory.Size = new Size(227, 36);
            btnProductCategory.TabIndex = 1;
            btnProductCategory.Text = "              Product Category";
            btnProductCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnProductCategory.UseVisualStyleBackColor = false;
            btnProductCategory.Click += btnProductCategory_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 59, 59);
            panel2.Controls.Add(products);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 34);
            panel2.TabIndex = 1;
            // 
            // products
            // 
            products.FlatStyle = FlatStyle.Flat;
            products.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            products.ForeColor = Color.FromArgb(224, 224, 224);
            products.Image = Properties.Resources.icons8_products_24;
            products.ImageAlign = ContentAlignment.MiddleLeft;
            products.Location = new Point(-14, -13);
            products.Name = "products";
            products.Padding = new Padding(45, 0, 0, 0);
            products.Size = new Size(253, 58);
            products.TabIndex = 1;
            products.Text = "              Products";
            products.TextAlign = ContentAlignment.MiddleLeft;
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(83, 13);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // menubtn
            // 
            menubtn.Cursor = Cursors.Hand;
            menubtn.Image = Properties.Resources.icons8_menu_25;
            menubtn.Location = new Point(25, 6);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(42, 36);
            menubtn.SizeMode = PictureBoxSizeMode.CenterImage;
            menubtn.TabIndex = 0;
            menubtn.TabStop = false;
            menubtn.Click += menubtn_Click;
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sidebar.BackColor = Color.DarkSlateGray;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnProductCategory);
            sidebar.Controls.Add(btnProductTypes);
            sidebar.Controls.Add(btnProductDetails);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(btnPurchaseReturn);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(btnSalesReturn);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(btnDailySales);
            sidebar.Controls.Add(btnMonthlySales);
            sidebar.Controls.Add(btnYearlySales);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel7);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(3, 3);
            sidebar.MaximumSize = new Size(230, 1000);
            sidebar.MinimumSize = new Size(83, 1000);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(222, 1000);
            sidebar.TabIndex = 8;
            sidebar.WrapContents = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(35, 59, 59);
            button1.Image = Properties.Resources.icons8_logout_24__2_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(879, 15);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(124, 47);
            button1.TabIndex = 10;
            button1.Text = "        Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userctrlanalysis1
            // 
            userctrlanalysis1.Location = new Point(238, 61);
            userctrlanalysis1.Name = "userctrlanalysis1";
            userctrlanalysis1.Size = new Size(762, 660);
            userctrlanalysis1.TabIndex = 11;
            // 
            // useryearlysale1
            // 
            useryearlysale1.Location = new Point(238, 61);
            useryearlysale1.Name = "useryearlysale1";
            useryearlysale1.Size = new Size(762, 660);
            useryearlysale1.TabIndex = 12;
            // 
            // usermonthlysale1
            // 
            usermonthlysale1.Location = new Point(238, 61);
            usermonthlysale1.Name = "usermonthlysale1";
            usermonthlysale1.Size = new Size(762, 660);
            usermonthlysale1.TabIndex = 13;
            // 
            // userctrldailysale1
            // 
            userctrldailysale1.Location = new Point(238, 61);
            userctrldailysale1.Name = "userctrldailysale1";
            userctrldailysale1.Size = new Size(762, 660);
            userctrldailysale1.TabIndex = 14;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 733);
            Controls.Add(button1);
            Controls.Add(btnLogout);
            Controls.Add(sidebar);
            Controls.Add(usercontrolPurchasereturn1);
            Controls.Add(userctrlanalysis1);
            Controls.Add(useryearlysale1);
            Controls.Add(userctrldailysale1);
            Controls.Add(usermonthlysale1);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubtn).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private usercontrol.usercontrolPurchasereturn usercontrolPurchasereturn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLogout;
        private System.Windows.Forms.Timer siderbarTimer;
        private Panel panel7;
        private Button btnAnalysis;
        private Panel panel5;
        private Button btnStock;
        private Button btnYearlySales;
        private Button btnMonthlySales;
        private Button btnDailySales;
        private Panel panel6;
        private Button btnReport;
        private Button btnSalesReturn;
        private Panel panel4;
        private Button btnSale;
        private Button btnPurchaseReturn;
        private Panel panel3;
        private Button btnPurchases;
        private Button btnProductDetails;
        private Button btnProductTypes;
        private Button btnProductCategory;
        private Panel panel2;
        private Button products;
        private Panel panel1;
        private Label label1;
        private PictureBox menubtn;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private userctrlanalysis userctrlanalysis1;
        private usercontrol.useryearlysale useryearlysale1;
        private usercontrol.usermonthlysale usermonthlysale1;
        private userctrldailysale userctrldailysale1;
    }
}