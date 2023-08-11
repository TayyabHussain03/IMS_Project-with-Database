namespace inventory_system
{
    partial class SplashScreeen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreeen));
            percentagelbl = new Label();
            pictureBox4 = new PictureBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // percentagelbl
            // 
            percentagelbl.AutoSize = true;
            percentagelbl.FlatStyle = FlatStyle.Popup;
            percentagelbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            percentagelbl.ForeColor = Color.DimGray;
            percentagelbl.Location = new Point(199, 589);
            percentagelbl.Name = "percentagelbl";
            percentagelbl.Size = new Size(0, 29);
            percentagelbl.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(74, 2);
            pictureBox4.Margin = new Padding(28, 5, 3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(861, 548);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Enabled = false;
            progressBar1.Location = new Point(74, 629);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(861, 27);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(74, 589);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 5;
            label1.Text = "Loading...";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashScreeen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1012, 733);
            Controls.Add(percentagelbl);
            Controls.Add(pictureBox4);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "SplashScreeen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreeen";
            Load += SplashScreeen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label percentagelbl;
        private PictureBox pictureBox4;
        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}