namespace DrawGit
{
    partial class frmRectangle1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenRoi = new System.Windows.Forms.Button();
            this.btnSaveRoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnGenRoi
            // 
            this.btnGenRoi.Location = new System.Drawing.Point(657, 12);
            this.btnGenRoi.Name = "btnGenRoi";
            this.btnGenRoi.Size = new System.Drawing.Size(84, 29);
            this.btnGenRoi.TabIndex = 1;
            this.btnGenRoi.Text = "Gen ROI";
            this.btnGenRoi.UseVisualStyleBackColor = true;
            this.btnGenRoi.Click += new System.EventHandler(this.btnGenRoi_Click);
            // 
            // btnSaveRoi
            // 
            this.btnSaveRoi.Location = new System.Drawing.Point(657, 47);
            this.btnSaveRoi.Name = "btnSaveRoi";
            this.btnSaveRoi.Size = new System.Drawing.Size(84, 29);
            this.btnSaveRoi.TabIndex = 2;
            this.btnSaveRoi.Text = "Save ROI";
            this.btnSaveRoi.UseVisualStyleBackColor = true;
            // 
            // frmRectangle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 502);
            this.Controls.Add(this.btnSaveRoi);
            this.Controls.Add(this.btnGenRoi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRectangle1";
            this.Text = "frmRectangle1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenRoi;
        private System.Windows.Forms.Button btnSaveRoi;
    }
}