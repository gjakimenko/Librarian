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
            this.components = new System.ComponentModel.Container();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCatalogImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCatalogExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrClearStatus = new System.Windows.Forms.Timer(this.components);
            this.stsStatusBar.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 697);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1186, 22);
            this.stsStatusBar.TabIndex = 1;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.tsiCatalog,
            this.tsiRent,
            this.tsiHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1186, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tsiFile
            // 
            this.tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFileSep1,
            this.tsiFileExit});
            this.tsiFile.Name = "tsiFile";
            this.tsiFile.Size = new System.Drawing.Size(66, 20);
            this.tsiFile.Text = "Datoteka";
            // 
            // tsiFileSep1
            // 
            this.tsiFileSep1.Name = "tsiFileSep1";
            this.tsiFileSep1.Size = new System.Drawing.Size(93, 6);
            // 
            // tsiFileExit
            // 
            this.tsiFileExit.Name = "tsiFileExit";
            this.tsiFileExit.Size = new System.Drawing.Size(96, 22);
            this.tsiFileExit.Text = "Izlaz";
            // 
            // tsiCatalog
            // 
            this.tsiCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCatalogAdd,
            this.tsiCatalogList,
            this.tsiCatalogSep1,
            this.tsiCatalogImport,
            this.tsiCatalogExport});
            this.tsiCatalog.Name = "tsiCatalog";
            this.tsiCatalog.Size = new System.Drawing.Size(59, 20);
            this.tsiCatalog.Text = "Katalog";
            // 
            // tsiCatalogAdd
            // 
            this.tsiCatalogAdd.Name = "tsiCatalogAdd";
            this.tsiCatalogAdd.Size = new System.Drawing.Size(152, 22);
            this.tsiCatalogAdd.Text = "Dodaj knjigu";
            this.tsiCatalogAdd.Click += new System.EventHandler(this.tsiCatalogAdd_Click);
            // 
            // tsiCatalogList
            // 
            this.tsiCatalogList.Name = "tsiCatalogList";
            this.tsiCatalogList.Size = new System.Drawing.Size(152, 22);
            this.tsiCatalogList.Text = "Prikaži katalog";
            this.tsiCatalogList.Click += new System.EventHandler(this.tsiCatalogList_Click);
            // 
            // tsiCatalogSep1
            // 
            this.tsiCatalogSep1.Name = "tsiCatalogSep1";
            this.tsiCatalogSep1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsiCatalogImport
            // 
            this.tsiCatalogImport.Name = "tsiCatalogImport";
            this.tsiCatalogImport.Size = new System.Drawing.Size(152, 22);
            this.tsiCatalogImport.Text = "Uvoz kataloga";
            // 
            // tsiCatalogExport
            // 
            this.tsiCatalogExport.Name = "tsiCatalogExport";
            this.tsiCatalogExport.Size = new System.Drawing.Size(152, 22);
            this.tsiCatalogExport.Text = "Izvoz kataloga";
            // 
            // tsiRent
            // 
            this.tsiRent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiRentUser,
            this.tsiRentList});
            this.tsiRent.Name = "tsiRent";
            this.tsiRent.Size = new System.Drawing.Size(65, 20);
            this.tsiRent.Text = "Posudbe";
            // 
            // tsiRentUser
            // 
            this.tsiRentUser.Name = "tsiRentUser";
            this.tsiRentUser.Size = new System.Drawing.Size(152, 22);
            this.tsiRentUser.Text = "Korisnici";
            this.tsiRentUser.Click += new System.EventHandler(this.tsiRentUser_Click);
            // 
            // tsiRentList
            // 
            this.tsiRentList.Name = "tsiRentList";
            this.tsiRentList.Size = new System.Drawing.Size(152, 22);
            this.tsiRentList.Text = "Prikaži";
            // 
            // tsiHelp
            // 
            this.tsiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiHelpAbout});
            this.tsiHelp.Name = "tsiHelp";
            this.tsiHelp.Size = new System.Drawing.Size(57, 20);
            this.tsiHelp.Text = "Pomoć";
            // 
            // tsiHelpAbout
            // 
            this.tsiHelpAbout.Name = "tsiHelpAbout";
            this.tsiHelpAbout.Size = new System.Drawing.Size(139, 22);
            this.tsiHelpAbout.Text = "O programu";
            // 
            // tmrClearStatus
            // 
            this.tmrClearStatus.Tick += new System.EventHandler(this.tmrClearStatus_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 719);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Librarian @ MIC";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsiFile;
        private System.Windows.Forms.ToolStripSeparator tsiFileSep1;
        private System.Windows.Forms.ToolStripMenuItem tsiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalog;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogList;
        private System.Windows.Forms.ToolStripSeparator tsiCatalogSep1;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogImport;
        private System.Windows.Forms.ToolStripMenuItem tsiCatalogExport;
        private System.Windows.Forms.ToolStripMenuItem tsiRent;
        private System.Windows.Forms.ToolStripMenuItem tsiRentList;
        private System.Windows.Forms.ToolStripMenuItem tsiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsiHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Timer tmrClearStatus;
        private System.Windows.Forms.ToolStripMenuItem tsiRentUser;
    }
}

