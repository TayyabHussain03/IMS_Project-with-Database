namespace inventory_system.usercontrol
{
    partial class UserControlInvoiceDetails
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
            label8 = new Label();
            btnAddCtg = new Button();
            dgvInvDetails = new DataGridView();
            lblDate = new Label();
            lblInv = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvDetails).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(266, 13);
            label8.Name = "label8";
            label8.Size = new Size(188, 42);
            label8.TabIndex = 18;
            label8.Text = "Invoice Details";
            label8.Click += label8_Click;
            // 
            // btnAddCtg
            // 
            btnAddCtg.BackColor = Color.CadetBlue;
            btnAddCtg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCtg.ForeColor = Color.White;
            btnAddCtg.Location = new Point(303, 441);
            btnAddCtg.Name = "btnAddCtg";
            btnAddCtg.Size = new Size(151, 51);
            btnAddCtg.TabIndex = 20;
            btnAddCtg.Text = "Downalod in Pdf";
            btnAddCtg.UseVisualStyleBackColor = false;
            btnAddCtg.Click += btnAddCtg_Click;
            // 
            // dgvInvDetails
            // 
            dgvInvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvInvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvDetails.Location = new Point(98, 105);
            dgvInvDetails.Name = "dgvInvDetails";
            dgvInvDetails.RowTemplate.Height = 25;
            dgvInvDetails.Size = new Size(504, 189);
            dgvInvDetails.TabIndex = 28;
            dgvInvDetails.CellContentClick += dgvInvDetails_CellContentClick;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(140, 331);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 15);
            lblDate.TabIndex = 29;
            lblDate.Click += lblDate_Click;
            // 
            // lblInv
            // 
            lblInv.AutoSize = true;
            lblInv.Location = new Point(140, 363);
            lblInv.Name = "lblInv";
            lblInv.Size = new Size(0, 15);
            lblInv.TabIndex = 30;
            lblInv.Click += lblInv_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(140, 393);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 31;
            lblTotal.Click += lblTotal_Click;
            // 
            // UserControlInvoiceDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotal);
            Controls.Add(lblInv);
            Controls.Add(lblDate);
            Controls.Add(dgvInvDetails);
            Controls.Add(btnAddCtg);
            Controls.Add(label8);
            Name = "UserControlInvoiceDetails";
            Size = new Size(762, 660);
            Load += UserControlInvoiceDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Button btnAddCtg;
        private DataGridView dgvInvDetails;
        private Label lblDate;
        private Label lblInv;
        private Label lblTotal;
    }
}
