namespace Library
{
    partial class frmAbout
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
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.linkLblEmail = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.library_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(166, 12);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(71, 13);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Librarian v1.0";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(166, 70);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(139, 13);
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "(C) 2012 Gordan Jakimenko";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(182, 41);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(213, 13);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "- Desktop application for book managment. ";
            // 
            // linkLblEmail
            // 
            this.linkLblEmail.AutoSize = true;
            this.linkLblEmail.Location = new System.Drawing.Point(166, 95);
            this.linkLblEmail.Name = "linkLblEmail";
            this.linkLblEmail.Size = new System.Drawing.Size(149, 13);
            this.linkLblEmail.TabIndex = 4;
            this.linkLblEmail.TabStop = true;
            this.linkLblEmail.Text = "gordan.jakimenko@gmail.com";
            this.linkLblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEmail_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 160);
            this.Controls.Add(this.linkLblEmail);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAbout";
            this.Text = "O programu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.LinkLabel linkLblEmail;
    }
}