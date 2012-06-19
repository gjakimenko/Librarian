namespace Library
{
    partial class frmCatalog
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
            this.spcContainer = new System.Windows.Forms.SplitContainer();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.dgvTxtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtISBN10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtISBN13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarianDS = new Library.LibrarianDS();
            this.bookTA = new Library.LibrarianDSTableAdapters.bookTA();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).BeginInit();
            this.SuspendLayout();
            // 
            // spcContainer
            // 
            this.spcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContainer.Location = new System.Drawing.Point(0, 0);
            this.spcContainer.Name = "spcContainer";
            // 
            // spcContainer.Panel1
            // 
            this.spcContainer.Panel1.Controls.Add(this.grpEdit);
            // 
            // spcContainer.Panel2
            // 
            this.spcContainer.Panel2.Controls.Add(this.grpList);
            this.spcContainer.Size = new System.Drawing.Size(1095, 541);
            this.spcContainer.SplitterDistance = 377;
            this.spcContainer.TabIndex = 0;
            // 
            // grpEdit
            // 
            this.grpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEdit.Location = new System.Drawing.Point(12, 12);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(357, 517);
            this.grpEdit.TabIndex = 0;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Uredi";
            // 
            // grpList
            // 
            this.grpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpList.Controls.Add(this.dgvCatalog);
            this.grpList.Location = new System.Drawing.Point(8, 12);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(694, 517);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "Ispis";
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.AllowUserToOrderColumns = true;
            this.dgvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalog.AutoGenerateColumns = false;
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatalog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtId,
            this.dgvTxtISBN10,
            this.dgvTxtTitle,
            this.dgvTxtAuthor,
            this.dgvTxtYear,
            this.dgvTxtPublisherName,
            this.dgvTxtStock,
            this.dgvTxtTypeName,
            this.dgvTxtCategoryName,
            this.dgvTxtISBN13});
            this.dgvCatalog.DataSource = this.bookBindingSource;
            this.dgvCatalog.Location = new System.Drawing.Point(6, 47);
            this.dgvCatalog.MultiSelect = false;
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalog.Size = new System.Drawing.Size(682, 464);
            this.dgvCatalog.TabIndex = 0;
            this.dgvCatalog.Resize += new System.EventHandler(this.dgvCatalog_Resize);
            // 
            // dgvTxtId
            // 
            this.dgvTxtId.DataPropertyName = "id";
            this.dgvTxtId.HeaderText = "ID";
            this.dgvTxtId.Name = "dgvTxtId";
            this.dgvTxtId.ReadOnly = true;
            this.dgvTxtId.Visible = false;
            this.dgvTxtId.Width = 43;
            // 
            // dgvTxtISBN10
            // 
            this.dgvTxtISBN10.DataPropertyName = "ISBN10";
            this.dgvTxtISBN10.HeaderText = "ISBN10";
            this.dgvTxtISBN10.Name = "dgvTxtISBN10";
            this.dgvTxtISBN10.ReadOnly = true;
            this.dgvTxtISBN10.Width = 69;
            // 
            // dgvTxtTitle
            // 
            this.dgvTxtTitle.DataPropertyName = "title";
            this.dgvTxtTitle.HeaderText = "Naslov";
            this.dgvTxtTitle.Name = "dgvTxtTitle";
            this.dgvTxtTitle.ReadOnly = true;
            this.dgvTxtTitle.Width = 65;
            // 
            // dgvTxtAuthor
            // 
            this.dgvTxtAuthor.DataPropertyName = "author";
            this.dgvTxtAuthor.HeaderText = "Autor";
            this.dgvTxtAuthor.Name = "dgvTxtAuthor";
            this.dgvTxtAuthor.ReadOnly = true;
            this.dgvTxtAuthor.Width = 57;
            // 
            // dgvTxtYear
            // 
            this.dgvTxtYear.DataPropertyName = "year";
            this.dgvTxtYear.HeaderText = "Godina";
            this.dgvTxtYear.Name = "dgvTxtYear";
            this.dgvTxtYear.ReadOnly = true;
            this.dgvTxtYear.Width = 66;
            // 
            // dgvTxtPublisherName
            // 
            this.dgvTxtPublisherName.DataPropertyName = "publisher_name";
            this.dgvTxtPublisherName.HeaderText = "Izdavač";
            this.dgvTxtPublisherName.Name = "dgvTxtPublisherName";
            this.dgvTxtPublisherName.ReadOnly = true;
            this.dgvTxtPublisherName.Width = 70;
            // 
            // dgvTxtStock
            // 
            this.dgvTxtStock.DataPropertyName = "stock";
            this.dgvTxtStock.HeaderText = "Komada";
            this.dgvTxtStock.Name = "dgvTxtStock";
            this.dgvTxtStock.ReadOnly = true;
            this.dgvTxtStock.Width = 71;
            // 
            // dgvTxtTypeName
            // 
            this.dgvTxtTypeName.DataPropertyName = "type_name";
            this.dgvTxtTypeName.HeaderText = "Tip";
            this.dgvTxtTypeName.Name = "dgvTxtTypeName";
            this.dgvTxtTypeName.ReadOnly = true;
            this.dgvTxtTypeName.Width = 47;
            // 
            // dgvTxtCategoryName
            // 
            this.dgvTxtCategoryName.DataPropertyName = "category_name";
            this.dgvTxtCategoryName.HeaderText = "Kategorija";
            this.dgvTxtCategoryName.Name = "dgvTxtCategoryName";
            this.dgvTxtCategoryName.ReadOnly = true;
            this.dgvTxtCategoryName.Width = 79;
            // 
            // dgvTxtISBN13
            // 
            this.dgvTxtISBN13.DataPropertyName = "ISBN13";
            this.dgvTxtISBN13.HeaderText = "ISBN13";
            this.dgvTxtISBN13.Name = "dgvTxtISBN13";
            this.dgvTxtISBN13.ReadOnly = true;
            this.dgvTxtISBN13.Width = 69;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.librarianDS;
            // 
            // librarianDS
            // 
            this.librarianDS.DataSetName = "LibrarianDS";
            this.librarianDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTA
            // 
            this.bookTA.ClearBeforeFill = true;
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 541);
            this.Controls.Add(this.spcContainer);
            this.Name = "frmCatalog";
            this.Text = "Katalog";
            this.Load += new System.EventHandler(this.frmCatalog_Load);
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private LibrarianDS librarianDS;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibrarianDSTableAdapters.bookTA bookTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtISBN10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtISBN13;
    }
}