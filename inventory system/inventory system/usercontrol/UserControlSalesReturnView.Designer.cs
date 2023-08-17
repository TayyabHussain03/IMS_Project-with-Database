namespace inventory_system.usercontrol
{
    partial class UserControlSalesReturnView
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtSearchProducts = new TextBox();
            btnSearchProducts = new Button();
            label4 = new Label();
            cmbBoxView = new ComboBox();
            cmbBoxReason = new ComboBox();
            label2 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(305, 26);
            label1.Name = "label1";
            label1.Size = new Size(168, 42);
            label1.TabIndex = 22;
            label1.Text = "Sales Return";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(678, 343);
            dataGridView1.TabIndex = 29;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearchProducts.Location = new Point(55, 104);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search Return Products by Name";
            txtSearchProducts.Size = new Size(632, 34);
            txtSearchProducts.TabIndex = 31;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.BackColor = Color.Gainsboro;
            btnSearchProducts.Cursor = Cursors.Hand;
            btnSearchProducts.FlatStyle = FlatStyle.Flat;
            btnSearchProducts.Image = Properties.Resources.icons8_search_24;
            btnSearchProducts.Location = new Point(693, 104);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(40, 34);
            btnSearchProducts.TabIndex = 30;
            btnSearchProducts.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(468, 190);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 37;
            label4.Text = "View Sales Return:";
            // 
            // cmbBoxView
            // 
            cmbBoxView.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxView.FormattingEnabled = true;
            cmbBoxView.Location = new Point(603, 187);
            cmbBoxView.Name = "cmbBoxView";
            cmbBoxView.Size = new Size(130, 28);
            cmbBoxView.TabIndex = 36;
            cmbBoxView.KeyPress += cmbBoxView_KeyPress_1;
            // 
            // cmbBoxReason
            // 
            cmbBoxReason.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxReason.FormattingEnabled = true;
            cmbBoxReason.Items.AddRange(new object[] { "All", "Damaged/Defected", "Expired", "Faulty", "Duplicate", "Unusable", "Unsatisfactory", "Mismatched", "Other..." });
            cmbBoxReason.Location = new Point(306, 187);
            cmbBoxReason.Name = "cmbBoxReason";
            cmbBoxReason.Size = new Size(147, 28);
            cmbBoxReason.TabIndex = 38;
            cmbBoxReason.SelectedIndexChanged += cmbBoxReason_SelectedIndexChanged;
            cmbBoxReason.KeyPress += cmbBoxReason_KeyPress_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(240, 190);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 39;
            label2.Text = "Reason:";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(55, 184);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(91, 33);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // UserControlSalesReturnView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(cmbBoxReason);
            Controls.Add(label4);
            Controls.Add(cmbBoxView);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserControlSalesReturnView";
            Size = new Size(780, 589);
            Load += UserControlSalesReturnView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private Label label4;
        private ComboBox cmbBoxView;
        private ComboBox cmbBoxReason;
        private Label label2;
        private Button btnRefresh;
    }
}
