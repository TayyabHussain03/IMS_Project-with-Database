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
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearchProducts.Location = new Point(78, 134);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search Products";
            txtSearchProducts.Size = new Size(559, 34);
            txtSearchProducts.TabIndex = 9;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Cursor = Cursors.Hand;
            btnSearchProducts.FlatStyle = FlatStyle.Flat;
            btnSearchProducts.Image = Properties.Resources.icons8_search_24;
            btnSearchProducts.Location = new Point(643, 134);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(39, 34);
            btnSearchProducts.TabIndex = 8;
            btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(332, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 47);
            label1.TabIndex = 7;
            label1.Text = "Products";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { id, name, category, quantity, price });
            dgvProducts.Location = new Point(78, 281);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(604, 325);
            dgvProducts.TabIndex = 10;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.Name = "category";
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
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
            btnAdd.Location = new Point(419, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(81, 39);
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
            btnEdit.Location = new Point(506, 219);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(80, 39);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "     Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(592, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5, 0, 0, 0);
            btnDelete.Size = new Size(90, 39);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "     Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // userctrlProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnSearchProducts);
            Controls.Add(label1);
            Name = "userctrlProductPage";
            Size = new Size(762, 660);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private Label label1;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
