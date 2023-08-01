namespace inventory_system.usercontrol
{
    partial class userctrlProductPage
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
            txtSearchProducts = new TextBox();
            btnSearchProducts = new Button();
            label1 = new Label();
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCtgPage = new Button();
            cmbCategoryFilter = new ComboBox();
            label2 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearchProducts.Location = new Point(27, 124);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search Products";
            txtSearchProducts.Size = new Size(414, 34);
            txtSearchProducts.TabIndex = 9;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Cursor = Cursors.Hand;
            btnSearchProducts.FlatStyle = FlatStyle.Flat;
            btnSearchProducts.Image = Properties.Resources.icons8_search_24;
            btnSearchProducts.Location = new Point(447, 124);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(40, 34);
            btnSearchProducts.TabIndex = 8;
            btnSearchProducts.UseVisualStyleBackColor = true;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(335, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 47);
            label1.TabIndex = 7;
            label1.Text = "Products";
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(27, 241);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(713, 325);
            dgvProducts.TabIndex = 10;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(224, 224, 224);
            btnAdd.Image = Properties.Resources.icons8_plus_16;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(483, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(80, 33);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "     Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Blue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(224, 224, 224);
            btnEdit.Image = Properties.Resources.icons8_edit_16;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(569, 202);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(80, 33);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "     Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnDelete.Location = new Point(655, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5, 0, 0, 0);
            btnDelete.Size = new Size(85, 33);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "     Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnCtgPage
            // 
            btnCtgPage.BackColor = Color.ForestGreen;
            btnCtgPage.FlatAppearance.BorderSize = 0;
            btnCtgPage.FlatStyle = FlatStyle.Flat;
            btnCtgPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCtgPage.ForeColor = Color.FromArgb(224, 224, 224);
            btnCtgPage.Image = Properties.Resources.icons8_plus_16;
            btnCtgPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnCtgPage.Location = new Point(27, 202);
            btnCtgPage.Name = "btnCtgPage";
            btnCtgPage.Padding = new Padding(10, 0, 0, 0);
            btnCtgPage.Size = new Size(131, 33);
            btnCtgPage.TabIndex = 14;
            btnCtgPage.Text = "     Add Category";
            btnCtgPage.TextAlign = ContentAlignment.MiddleLeft;
            btnCtgPage.UseVisualStyleBackColor = false;
            btnCtgPage.Click += btnCtgPage_Click;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(597, 126);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(143, 33);
            cmbCategoryFilter.TabIndex = 15;
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(527, 127);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 16;
            label2.Text = "Filter :";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Image = Properties.Resources.icons8_refresh_18;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(164, 202);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 0, 0);
            btnRefresh.Size = new Size(80, 33);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "      Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // userctrlProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(btnCtgPage);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(label1);
            Name = "userctrlProductPage";
            Padding = new Padding(3, 0, 0, 0);
            Size = new Size(762, 660);
            Load += userctrlProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private Label label1;
        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCtgPage;
        private ComboBox cmbCategoryFilter;
        private Label label2;
        private Button btnRefresh;
    }
}
