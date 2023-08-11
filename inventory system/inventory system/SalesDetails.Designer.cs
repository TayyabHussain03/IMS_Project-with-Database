namespace inventory_system
{
    partial class SalesDetails
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
            lblTotal = new Label();
            lblInv = new Label();
            lblDate = new Label();
            dgvInvDetails = new DataGridView();
            btnAddCtg = new Button();
            label8 = new Label();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvDetails).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(161, 416);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 37;
            // 
            // lblInv
            // 
            lblInv.AutoSize = true;
            lblInv.Location = new Point(161, 386);
            lblInv.Name = "lblInv";
            lblInv.Size = new Size(0, 15);
            lblInv.TabIndex = 36;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(161, 354);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 15);
            lblDate.TabIndex = 35;
            // 
            // dgvInvDetails
            // 
            dgvInvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvInvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvDetails.Location = new Point(119, 128);
            dgvInvDetails.Name = "dgvInvDetails";
            dgvInvDetails.RowTemplate.Height = 25;
            dgvInvDetails.Size = new Size(504, 189);
            dgvInvDetails.TabIndex = 34;
            // 
            // btnAddCtg
            // 
            btnAddCtg.BackColor = Color.CadetBlue;
            btnAddCtg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCtg.ForeColor = Color.White;
            btnAddCtg.Location = new Point(324, 464);
            btnAddCtg.Name = "btnAddCtg";
            btnAddCtg.Size = new Size(151, 51);
            btnAddCtg.TabIndex = 33;
            btnAddCtg.Text = "Downalod in Pdf";
            btnAddCtg.UseVisualStyleBackColor = false;
            btnAddCtg.Click += btnAddCtg_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(287, 36);
            label8.Name = "label8";
            label8.Size = new Size(188, 42);
            label8.TabIndex = 32;
            label8.Text = "Invoice Details";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(399, 352);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 15);
            lblTime.TabIndex = 38;
            // 
            // SalesDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(lblTime);
            Controls.Add(lblTotal);
            Controls.Add(lblInv);
            Controls.Add(lblDate);
            Controls.Add(dgvInvDetails);
            Controls.Add(btnAddCtg);
            Controls.Add(label8);
            Name = "SalesDetails";
            Text = "SalesDetails";
            Load += SalesDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblInv;
        private Label lblDate;
        private DataGridView dgvInvDetails;
        private Button btnAddCtg;
        private Label label8;
        private Label lblTime;
    }
}