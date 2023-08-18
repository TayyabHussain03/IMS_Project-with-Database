namespace inventory_system.usercontrol
{
    partial class UserControlPurchaseReturnView
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
            txtSearchProducts = new TextBox();
            btnSearchProducts = new Button();
            btnRefresh = new Button();
            label2 = new Label();
            cmbBoxReason = new ComboBox();
            label4 = new Label();
            cmbBoxView = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(276, 25);
            label1.Name = "label1";
            label1.Size = new Size(212, 42);
            label1.TabIndex = 23;
            label1.Text = "Purchase Return";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearchProducts.Location = new Point(47, 108);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search Return Products by Name";
            txtSearchProducts.Size = new Size(632, 34);
            txtSearchProducts.TabIndex = 33;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.BackColor = Color.Gainsboro;
            btnSearchProducts.Cursor = Cursors.Hand;
            btnSearchProducts.FlatStyle = FlatStyle.Flat;
            btnSearchProducts.Image = Properties.Resources.icons8_search_24;
            btnSearchProducts.Location = new Point(685, 108);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(40, 34);
            btnSearchProducts.TabIndex = 32;
            btnSearchProducts.UseVisualStyleBackColor = false;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(47, 187);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(91, 33);
            btnRefresh.TabIndex = 46;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(210, 193);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 45;
            label2.Text = "Reason:";
            // 
            // cmbBoxReason
            // 
            cmbBoxReason.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxReason.FormattingEnabled = true;
            cmbBoxReason.Items.AddRange(new object[] { "All", "Damaged/Defected", "Expired", "Faulty", "Duplicate", "Unusable", "Unsatisfactory", "Mismatched", "Other..." });
            cmbBoxReason.Location = new Point(276, 190);
            cmbBoxReason.Name = "cmbBoxReason";
            cmbBoxReason.Size = new Size(147, 28);
            cmbBoxReason.TabIndex = 44;
            cmbBoxReason.SelectedIndexChanged += cmbBoxReason_SelectedIndexChanged;
            cmbBoxReason.KeyPress += cmbBoxReason_KeyPress_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(436, 193);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 43;
            label4.Text = "View Purchase Return:";
            // 
            // cmbBoxView
            // 
            cmbBoxView.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxView.FormattingEnabled = true;
            cmbBoxView.Location = new Point(595, 190);
            cmbBoxView.Name = "cmbBoxView";
            cmbBoxView.Size = new Size(130, 28);
            cmbBoxView.TabIndex = 42;
            cmbBoxView.SelectedIndexChanged += cmbBoxView_SelectedIndexChanged;
            cmbBoxView.KeyPress += cmbBoxView_KeyPress_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(678, 343);
            dataGridView1.TabIndex = 41;
            // 
            // UserControlPurchaseRetrunView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(cmbBoxReason);
            Controls.Add(label4);
            Controls.Add(cmbBoxView);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(label1);
            Name = "UserControlPurchaseRetrunView";
            Size = new Size(780, 589);
            Load += UserControlPurchaseRetrunView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private Button btnRefresh;
        private Label label2;
        private ComboBox cmbBoxReason;
        private Label label4;
        private ComboBox cmbBoxView;
        private DataGridView dataGridView1;
    }
}
