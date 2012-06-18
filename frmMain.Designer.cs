namespace Library
{
    partial class frmMain
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
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCatalogImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Location = new System.Drawing.Point(0, 596);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1110, 22);
            this.stsStatusBar.TabIndex = 1;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.tsiUser,
            this.tsiCatalog,
            this.tsiRent});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsiFile
            // 
            this.tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsiFileExit});
            this.tsiFile.Name = "tsiFile";
            this.tsiFile.Size = new System.Drawing.Size(66, 20);
            this.tsiFile.Text = "Datoteka";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 6);
            // 
            // tsiFileExit
            // 
            this.tsiFileExit.Name = "tsiFileExit";
            this.tsiFileExit.Size = new System.Drawing.Size(96, 22);
            this.tsiFileExit.Text = "Izlaz";
            // 
            // tsiUser
            // 
            this.tsiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUserAdd,
            this.tsiUserEdit});
            this.tsiUser.Name = "tsiUser";
            this.tsiUser.Size = new System.Drawing.Size(61, 20);
            this.tsiUser.Text = "Korisnik";
            // 
            // tsiUserAdd
            // 
            this.tsiUserAdd.Name = "tsiUserAdd";
            this.tsiUserAdd.Size = new System.Drawing.Size(130, 22);
            this.tsiUserAdd.Text = "Dodaj";
            // 
            // tsiUserEdit
            // 
            this.tsiUserEdit.Name = "tsiUserEdit";
            this.tsiUserEdit.Size = new System.Drawing.Size(130, 22);
            this.tsiUserEdit.Text = "Uređivanje";
            // 
            // tsiCatalog
            // 
            this.tsiCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCatalogAdd,
            this.tsiCatalogList,
            this.toolStripMenuItem2,
            this.tsiCatalogImport,
            this.tsiCatalogExport});
            this.tsiCatalog.Name = "tsiCatalog";
            this.tsiCatalog.Size = new System.Drawing.Size(59, 20);
            this.tsiCatalog.Text = "Katalog";
            // 
            // tsiCatalogAdd
            // 
            this.tsiCatalogAdd.Name = "tsiCatalogAdd";
            this.tsiCatalogAdd.Size = new System.Drawing.Size(148, 22);
            this.tsiCatalogAdd.Text = "Dodaj";
            // 
            // tsiCatalogList
            // 
            this.tsiCatalogList.Name = "tsiCatalogList";
            this.tsiCatalogList.Size = new System.Drawing.Size(148, 22);
            this.tsiCatalogList.Text = "Prikaži";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // tsiCatalogImport
            // 
            this.tsiCatalogImport.Name = "tsiCatalogImport";
            this.tsiCatalogImport.Size = new System.Drawing.Size(148, 22);
            this.tsiCatalogImport.Text = "Uvoz kataloga";
            // 
            // tsiCatalogExport
            // 
            this.tsiCatalogExport.Name = "tsiCatalogExport";
            this.tsiCatalogExport.Size = new System.Drawing.Size(148, 22);
            this.tsiCatalogExport.Text = "Izvoz kataloga";
            // 
            // tsiRent
            // 
            this.tsiRent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiRentList});
            this.tsiRent.Name = "tsiRent";
            this.tsiRent.Size = new System.Drawing.Size(65, 20);
            this.tsiRent.Text = "Posudbe";
            // 
            // tsiRentList
            // 
            this.tsiRentList.Name = "tsiRentList";
            this.tsiRentList.Size = new System.Drawing.Size(108, 22);
            this.tsiRentList.Text = "Prikaži";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 618);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Librarian @ MIC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsiUser;
        private System.Windows.Forms.ToolStripMenuItem tsiUserAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiUserEdit;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalog;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogImport;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogExport;
        private System.Windows.Forms.ToolStripMenuItem tsiRent;
        private System.Windows.Forms.ToolStripMenuItem tsiRentList;
    }
}

