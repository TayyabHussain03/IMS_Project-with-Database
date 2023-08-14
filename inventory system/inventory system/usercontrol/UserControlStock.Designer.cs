namespace inventory_system.usercontrol
{
    partial class UserControlStock
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
            btnRefresh = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            txtSearchProducts = new TextBox();
            btnSearchProducts = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(66, 163);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(80, 33);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(224, 224, 224);
            btnDelete.Image = Properties.Resources.icons8_delete_16;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(611, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5, 0, 0, 0);
            btnDelete.Size = new Size(85, 33);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "     Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(66, 202);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(630, 345);
            dgvProducts.TabIndex = 34;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearchProducts.Location = new Point(66, 93);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search Products by Name";
            txtSearchProducts.Size = new Size(584, 34);
            txtSearchProducts.TabIndex = 33;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Cursor = Cursors.Hand;
            btnSearchProducts.FlatStyle = FlatStyle.Flat;
            btnSearchProducts.Image = Properties.Resources.icons8_search_24;
            btnSearchProducts.Location = new Point(656, 93);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(40, 34);
            btnSearchProducts.TabIndex = 32;
            btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(340, 37);
            label1.Name = "label1";
            label1.Size = new Size(94, 42);
            label1.TabIndex = 31;
            label1.Text = "Stocks";
            label1.Click += label1_Click;
            // 
            // UserControlStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(label1);
            Name = "UserControlStock";
            Size = new Size(762, 660);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private Label label1;
    }
}
