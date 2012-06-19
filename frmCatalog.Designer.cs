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
            this.btnRent = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtISBN13 = new System.Windows.Forms.TextBox();
            this.bookBS = new System.Windows.Forms.BindingSource(this.components);
            this.librarianDS = new Library.LibrarianDS();
            this.lblISBN13 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.categoryBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.typeBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.publisherBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblYear = new System.Windows.Forms.Label();
            this.mtbYear = new System.Windows.Forms.MaskedTextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN10 = new System.Windows.Forms.TextBox();
            this.lblISBN10 = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
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
            this.grpEdit.Controls.Add(this.btnRent);
            this.grpEdit.Controls.Add(this.btnAdd);
            this.grpEdit.Controls.Add(this.btnEdit);
            this.grpEdit.Controls.Add(this.btnRemove);
            this.grpEdit.Controls.Add(this.txtISBN13);
            this.grpEdit.Controls.Add(this.lblISBN13);
            this.grpEdit.Controls.Add(this.cmbCategory);
            this.grpEdit.Controls.Add(this.lblCategory);
            this.grpEdit.Controls.Add(this.cmbType);
            this.grpEdit.Controls.Add(this.lblType);
            this.grpEdit.Controls.Add(this.lblStock);
            this.grpEdit.Controls.Add(this.nupStock);
            this.grpEdit.Controls.Add(this.lblPublisher);
            this.grpEdit.Controls.Add(this.cmbPublisher);
            this.grpEdit.Controls.Add(this.lblYear);
            this.grpEdit.Controls.Add(this.mtbYear);
            this.grpEdit.Controls.Add(this.txtAuthor);
            this.grpEdit.Controls.Add(this.lblAuthor);
            this.grpEdit.Controls.Add(this.txtTitle);
            this.grpEdit.Controls.Add(this.lblTitle);
            this.grpEdit.Controls.Add(this.txtISBN10);
            this.grpEdit.Controls.Add(this.lblISBN10);
            this.grpEdit.Location = new System.Drawing.Point(12, 12);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(357, 517);
            this.grpEdit.TabIndex = 0;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Uredi";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(251, 414);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(99, 45);
            this.btnRent.TabIndex = 23;
            this.btnRent.Text = "Posudi";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 45);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
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
            this.btnRemove.Location = new System.Drawing.Point(251, 465);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 45);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Obriši";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // txtISBN13
            // 
            this.txtISBN13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtISBN13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "ISBN13", true));
            this.txtISBN13.Location = new System.Drawing.Point(129, 228);
            this.txtISBN13.Name = "txtISBN13";
            this.txtISBN13.Size = new System.Drawing.Size(222, 20);
            this.txtISBN13.TabIndex = 19;
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
            // lblISBN13
            // 
            this.lblISBN13.AutoSize = true;
            this.lblISBN13.Location = new System.Drawing.Point(6, 231);
            this.lblISBN13.Name = "lblISBN13";
            this.lblISBN13.Size = new System.Drawing.Size(44, 13);
            this.lblISBN13.TabIndex = 18;
            this.lblISBN13.Text = "ISBN13";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookBS, "category_id", true));
            this.cmbCategory.DataSource = this.categoryBS;
            this.cmbCategory.DisplayMember = "name";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(129, 201);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(222, 21);
            this.cmbCategory.TabIndex = 17;
            this.cmbCategory.ValueMember = "id";
            // 
            // categoryBS
            // 
            this.categoryBS.DataMember = "category";
            this.categoryBS.DataSource = this.librarianDS;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 204);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 13);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Kategorija";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookBS, "type_id", true));
            this.cmbType.DataSource = this.typeBS;
            this.cmbType.DisplayMember = "name";
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(129, 174);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(222, 21);
            this.cmbType.TabIndex = 15;
            this.cmbType.ValueMember = "id";
            // 
            // typeBS
            // 
            this.typeBS.DataMember = "type";
            this.typeBS.DataSource = this.librarianDS;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 177);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(22, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Tip";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 150);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 13);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Komada";
            // 
            // nupStock
            // 
            this.nupStock.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBS, "stock", true));
            this.nupStock.Location = new System.Drawing.Point(251, 148);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(100, 20);
            this.nupStock.TabIndex = 10;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(6, 124);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(45, 13);
            this.lblPublisher.TabIndex = 9;
            this.lblPublisher.Text = "Izdavač";
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPublisher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookBS, "publisher_id", true));
            this.cmbPublisher.DataSource = this.publisherBS;
            this.cmbPublisher.DisplayMember = "name";
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(129, 121);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(222, 21);
            this.cmbPublisher.TabIndex = 8;
            this.cmbPublisher.ValueMember = "id";
            // 
            // publisherBS
            // 
            this.publisherBS.DataMember = "publisher";
            this.publisherBS.DataSource = this.librarianDS;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 98);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 13);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Godina";
            // 
            // mtbYear
            // 
            this.mtbYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "year", true));
            this.mtbYear.Location = new System.Drawing.Point(251, 95);
            this.mtbYear.Mask = "0000";
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.Size = new System.Drawing.Size(100, 20);
            this.mtbYear.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "author", true));
            this.txtAuthor.Location = new System.Drawing.Point(129, 69);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(222, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 72);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(32, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Autor";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "title", true));
            this.txtTitle.Location = new System.Drawing.Point(129, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(222, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Naslov";
            // 
            // txtISBN10
            // 
            this.txtISBN10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtISBN10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "ISBN10", true));
            this.txtISBN10.Location = new System.Drawing.Point(129, 17);
            this.txtISBN10.Name = "txtISBN10";
            this.txtISBN10.Size = new System.Drawing.Size(222, 20);
            this.txtISBN10.TabIndex = 1;
            // 
            // lblISBN10
            // 
            this.lblISBN10.AutoSize = true;
            this.lblISBN10.Location = new System.Drawing.Point(6, 20);
            this.lblISBN10.Name = "lblISBN10";
            this.lblISBN10.Size = new System.Drawing.Size(44, 13);
            this.lblISBN10.TabIndex = 0;
            this.lblISBN10.Text = "ISBN10";
            // 
            // grpList
            // 
            this.grpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(371, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(418, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
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
        private System.Windows.Forms.TextBox txtISBN10;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.MaskedTextBox mtbYear;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource publisherBS;
        private LibrarianDSTableAdapters.publisherTA publisherTA;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nupStock;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.BindingSource typeBS;
        private LibrarianDSTableAdapters.typeTA typeTA;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.BindingSource categoryBS;
        private LibrarianDSTableAdapters.categoryTA categoryTA;
        private System.Windows.Forms.TextBox txtISBN13;
        private System.Windows.Forms.Label lblISBN13;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
    }
}