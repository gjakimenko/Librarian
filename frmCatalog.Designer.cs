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
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lblISBN_10 = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblISBN10 = new System.Windows.Forms.Label();
            this.bookBS = new System.Windows.Forms.BindingSource(this.components);
            this.librarianDS = new Library.LibrarianDS();
            this.lblCategory = new System.Windows.Forms.Label();
            this.categoryBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.typeBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblPublisher = new System.Windows.Forms.Label();
            this.publisherBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.rdbAuthor = new System.Windows.Forms.RadioButton();
            this.rdbTitle = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.bookTA = new Library.LibrarianDSTableAdapters.bookTA();
            this.publisherTA = new Library.LibrarianDSTableAdapters.publisherTA();
            this.typeTA = new Library.LibrarianDSTableAdapters.typeTA();
            this.categoryTA = new Library.LibrarianDSTableAdapters.categoryTA();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).BeginInit();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
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
            this.grpEdit.Controls.Add(this.btnCopyToClipboard);
            this.grpEdit.Controls.Add(this.lblISBN_10);
            this.grpEdit.Controls.Add(this.lblKategorija);
            this.grpEdit.Controls.Add(this.lblTip);
            this.grpEdit.Controls.Add(this.lblIzdavac);
            this.grpEdit.Controls.Add(this.lblGodina);
            this.grpEdit.Controls.Add(this.btnRent);
            this.grpEdit.Controls.Add(this.btnAdd);
            this.grpEdit.Controls.Add(this.btnEdit);
            this.grpEdit.Controls.Add(this.btnRemove);
            this.grpEdit.Controls.Add(this.lblISBN10);
            this.grpEdit.Controls.Add(this.lblCategory);
            this.grpEdit.Controls.Add(this.lblType);
            this.grpEdit.Controls.Add(this.lblPublisher);
            this.grpEdit.Controls.Add(this.lblYear);
            this.grpEdit.Controls.Add(this.lblAuthor);
            this.grpEdit.Controls.Add(this.lblTitle);
            this.grpEdit.Location = new System.Drawing.Point(12, 12);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(357, 517);
            this.grpEdit.TabIndex = 0;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Uredi";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Image = global::Library.Properties.Resources.Copy_to_Clipboard;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(200, 414);
            this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(45, 45);
            this.btnCopyToClipboard.TabIndex = 29;
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // lblISBN_10
            // 
            this.lblISBN_10.AutoSize = true;
            this.lblISBN_10.Location = new System.Drawing.Point(7, 121);
            this.lblISBN_10.Name = "lblISBN_10";
            this.lblISBN_10.Size = new System.Drawing.Size(47, 13);
            this.lblISBN_10.TabIndex = 28;
            this.lblISBN_10.Text = "ISBN10:";
            this.lblISBN_10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(7, 104);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(57, 13);
            this.lblKategorija.TabIndex = 27;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(7, 87);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(25, 13);
            this.lblTip.TabIndex = 26;
            this.lblTip.Text = "Tip:";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(7, 53);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(48, 13);
            this.lblIzdavac.TabIndex = 25;
            this.lblIzdavac.Text = "Izdavač:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(7, 70);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(44, 13);
            this.lblGodina.TabIndex = 24;
            this.lblGodina.Text = "Godina:";
            // 
            // btnRent
            // 
            this.btnRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRent.Location = new System.Drawing.Point(251, 414);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(99, 45);
            this.btnRent.TabIndex = 23;
            this.btnRent.Text = "Posudi";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(41, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 45);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(146, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 45);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(251, 465);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 45);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Obriši";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblISBN10
            // 
            this.lblISBN10.AutoSize = true;
            this.lblISBN10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "ISBN10", true));
            this.lblISBN10.Location = new System.Drawing.Point(70, 121);
            this.lblISBN10.Name = "lblISBN10";
            this.lblISBN10.Size = new System.Drawing.Size(44, 13);
            this.lblISBN10.TabIndex = 18;
            this.lblISBN10.Text = "ISBN10";
            this.lblISBN10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookBS
            // 
            this.bookBS.DataMember = "book";
            this.bookBS.DataSource = this.librarianDS;
            // 
            // librarianDS
            // 
            this.librarianDS.DataSetName = "LibrarianDS";
            this.librarianDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBS, "name", true));
            this.lblCategory.Location = new System.Drawing.Point(70, 104);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 13);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Kategorija";
            // 
            // categoryBS
            // 
            this.categoryBS.DataMember = "category";
            this.categoryBS.DataSource = this.librarianDS;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBS, "name", true));
            this.lblType.Location = new System.Drawing.Point(70, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(22, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Tip";
            // 
            // typeBS
            // 
            this.typeBS.DataMember = "type";
            this.typeBS.DataSource = this.librarianDS;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBS, "name", true));
            this.lblPublisher.Location = new System.Drawing.Point(70, 53);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(45, 13);
            this.lblPublisher.TabIndex = 9;
            this.lblPublisher.Text = "Izdavač";
            // 
            // publisherBS
            // 
            this.publisherBS.DataMember = "publisher";
            this.publisherBS.DataSource = this.librarianDS;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "year", true));
            this.lblYear.Location = new System.Drawing.Point(70, 70);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 13);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Godina";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoEllipsis = true;
            this.lblAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "author", true));
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAuthor.Location = new System.Drawing.Point(7, 36);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(344, 17);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Autor";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "title", true));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(7, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Naslov";
            // 
            // grpList
            // 
            this.grpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpList.Controls.Add(this.rdbAuthor);
            this.grpList.Controls.Add(this.rdbTitle);
            this.grpList.Controls.Add(this.lblSearch);
            this.grpList.Controls.Add(this.txtSearch);
            this.grpList.Controls.Add(this.dgvCatalog);
            this.grpList.Location = new System.Drawing.Point(8, 12);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(694, 517);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "Ispis";
            // 
            // rdbAuthor
            // 
            this.rdbAuthor.AutoSize = true;
            this.rdbAuthor.Location = new System.Drawing.Point(291, 18);
            this.rdbAuthor.Name = "rdbAuthor";
            this.rdbAuthor.Size = new System.Drawing.Size(50, 17);
            this.rdbAuthor.TabIndex = 4;
            this.rdbAuthor.TabStop = true;
            this.rdbAuthor.Text = "Autor";
            this.rdbAuthor.UseVisualStyleBackColor = true;
            this.rdbAuthor.CheckedChanged += new System.EventHandler(this.rdbAuthor_CheckedChanged);
            // 
            // rdbTitle
            // 
            this.rdbTitle.AutoSize = true;
            this.rdbTitle.Checked = true;
            this.rdbTitle.Location = new System.Drawing.Point(213, 18);
            this.rdbTitle.Name = "rdbTitle";
            this.rdbTitle.Size = new System.Drawing.Size(58, 17);
            this.rdbTitle.TabIndex = 3;
            this.rdbTitle.TabStop = true;
            this.rdbTitle.Text = "Naslov";
            this.rdbTitle.UseVisualStyleBackColor = true;
            this.rdbTitle.CheckedChanged += new System.EventHandler(this.rdbTitle_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(371, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(33, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Traži:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(418, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dgvCatalog.DataSource = this.bookBS;
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
            // bookTA
            // 
            this.bookTA.ClearBeforeFill = true;
            // 
            // publisherTA
            // 
            this.publisherTA.ClearBeforeFill = true;
            // 
            // typeTA
            // 
            this.typeTA.ClearBeforeFill = true;
            // 
            // categoryTA
            // 
            this.categoryTA.ClearBeforeFill = true;
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 541);
            this.Controls.Add(this.spcContainer);
            this.MinimumSize = new System.Drawing.Size(1111, 579);
            this.Name = "frmCatalog";
            this.Text = "Katalog";
            this.Load += new System.EventHandler(this.frmCatalog_Load);
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).EndInit();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private LibrarianDS librarianDS;
        private System.Windows.Forms.BindingSource bookBS;
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
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource publisherBS;
        private LibrarianDSTableAdapters.publisherTA publisherTA;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.BindingSource typeBS;
        private LibrarianDSTableAdapters.typeTA typeTA;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.BindingSource categoryBS;
        private LibrarianDSTableAdapters.categoryTA categoryTA;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RadioButton rdbAuthor;
        private System.Windows.Forms.RadioButton rdbTitle;
        private System.Windows.Forms.Label lblISBN_10;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Button btnCopyToClipboard;
    }
}