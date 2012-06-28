namespace Library
{
    partial class frmTPCEdit
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
            this.tbcTPC = new System.Windows.Forms.TabControl();
            this.tabPublisher = new System.Windows.Forms.TabPage();
            this.spcPublisher = new System.Windows.Forms.SplitContainer();
            this.grpPublisher = new System.Windows.Forms.GroupBox();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnEditPublisher = new System.Windows.Forms.Button();
            this.btnRemovePublisher = new System.Windows.Forms.Button();
            this.lblPublisherWeb = new System.Windows.Forms.Label();
            this.lblPublisherDesc = new System.Windows.Forms.Label();
            this.txtPublisherWeb = new System.Windows.Forms.TextBox();
            this.publisherBS = new System.Windows.Forms.BindingSource(this.components);
            this.librarianDS = new Library.LibrarianDS();
            this.txtPublisherDesc = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.grpPublisherPreview = new System.Windows.Forms.GroupBox();
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            this.dgvTxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabType = new System.Windows.Forms.TabPage();
            this.spcType = new System.Windows.Forms.SplitContainer();
            this.grpTypeEdit = new System.Windows.Forms.GroupBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnEditType = new System.Windows.Forms.Button();
            this.btnRemoveType = new System.Windows.Forms.Button();
            this.lblTypeDesc = new System.Windows.Forms.Label();
            this.txtTypeDesc = new System.Windows.Forms.TextBox();
            this.typeBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.grpTypePreview = new System.Windows.Forms.GroupBox();
            this.dgvType = new System.Windows.Forms.DataGridView();
            this.dgvTxtTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.publisherTA = new Library.LibrarianDSTableAdapters.publisherTA();
            this.typeTA = new Library.LibrarianDSTableAdapters.typeTA();
            this.tbcTPC.SuspendLayout();
            this.tabPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPublisher)).BeginInit();
            this.spcPublisher.Panel1.SuspendLayout();
            this.spcPublisher.Panel2.SuspendLayout();
            this.spcPublisher.SuspendLayout();
            this.grpPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).BeginInit();
            this.grpPublisherPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.tabType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcType)).BeginInit();
            this.spcType.Panel1.SuspendLayout();
            this.spcType.Panel2.SuspendLayout();
            this.spcType.SuspendLayout();
            this.grpTypeEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).BeginInit();
            this.grpTypePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTPC
            // 
            this.tbcTPC.Controls.Add(this.tabPublisher);
            this.tbcTPC.Controls.Add(this.tabType);
            this.tbcTPC.Controls.Add(this.tabCategory);
            this.tbcTPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTPC.Location = new System.Drawing.Point(0, 0);
            this.tbcTPC.Name = "tbcTPC";
            this.tbcTPC.SelectedIndex = 0;
            this.tbcTPC.Size = new System.Drawing.Size(860, 404);
            this.tbcTPC.TabIndex = 0;
            // 
            // tabPublisher
            // 
            this.tabPublisher.Controls.Add(this.spcPublisher);
            this.tabPublisher.Location = new System.Drawing.Point(4, 22);
            this.tabPublisher.Name = "tabPublisher";
            this.tabPublisher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublisher.Size = new System.Drawing.Size(852, 378);
            this.tabPublisher.TabIndex = 0;
            this.tabPublisher.Text = "Izdavač";
            this.tabPublisher.UseVisualStyleBackColor = true;
            // 
            // spcPublisher
            // 
            this.spcPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPublisher.Location = new System.Drawing.Point(3, 3);
            this.spcPublisher.Name = "spcPublisher";
            // 
            // spcPublisher.Panel1
            // 
            this.spcPublisher.Panel1.Controls.Add(this.grpPublisher);
            // 
            // spcPublisher.Panel2
            // 
            this.spcPublisher.Panel2.Controls.Add(this.grpPublisherPreview);
            this.spcPublisher.Size = new System.Drawing.Size(846, 372);
            this.spcPublisher.SplitterDistance = 281;
            this.spcPublisher.TabIndex = 0;
            // 
            // grpPublisher
            // 
            this.grpPublisher.Controls.Add(this.btnAddPublisher);
            this.grpPublisher.Controls.Add(this.btnEditPublisher);
            this.grpPublisher.Controls.Add(this.btnRemovePublisher);
            this.grpPublisher.Controls.Add(this.lblPublisherWeb);
            this.grpPublisher.Controls.Add(this.lblPublisherDesc);
            this.grpPublisher.Controls.Add(this.txtPublisherWeb);
            this.grpPublisher.Controls.Add(this.txtPublisherDesc);
            this.grpPublisher.Controls.Add(this.txtPublisherName);
            this.grpPublisher.Controls.Add(this.lblPublisherName);
            this.grpPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublisher.Location = new System.Drawing.Point(0, 0);
            this.grpPublisher.Name = "grpPublisher";
            this.grpPublisher.Size = new System.Drawing.Size(281, 372);
            this.grpPublisher.TabIndex = 0;
            this.grpPublisher.TabStop = false;
            this.grpPublisher.Text = "Uredi";
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPublisher.Location = new System.Drawing.Point(38, 321);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(75, 45);
            this.btnAddPublisher.TabIndex = 25;
            this.btnAddPublisher.Text = "Dodaj";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnEditPublisher
            // 
            this.btnEditPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPublisher.Location = new System.Drawing.Point(119, 321);
            this.btnEditPublisher.Name = "btnEditPublisher";
            this.btnEditPublisher.Size = new System.Drawing.Size(75, 45);
            this.btnEditPublisher.TabIndex = 24;
            this.btnEditPublisher.Text = "Uredi";
            this.btnEditPublisher.UseVisualStyleBackColor = true;
            this.btnEditPublisher.Click += new System.EventHandler(this.btnEditPublisher_Click);
            // 
            // btnRemovePublisher
            // 
            this.btnRemovePublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemovePublisher.Location = new System.Drawing.Point(200, 321);
            this.btnRemovePublisher.Name = "btnRemovePublisher";
            this.btnRemovePublisher.Size = new System.Drawing.Size(75, 45);
            this.btnRemovePublisher.TabIndex = 23;
            this.btnRemovePublisher.Text = "Obriši";
            this.btnRemovePublisher.UseVisualStyleBackColor = true;
            this.btnRemovePublisher.Click += new System.EventHandler(this.btnRemovePublisher_Click);
            // 
            // lblPublisherWeb
            // 
            this.lblPublisherWeb.AutoSize = true;
            this.lblPublisherWeb.Location = new System.Drawing.Point(7, 72);
            this.lblPublisherWeb.Name = "lblPublisherWeb";
            this.lblPublisherWeb.Size = new System.Drawing.Size(30, 13);
            this.lblPublisherWeb.TabIndex = 7;
            this.lblPublisherWeb.Text = "Web";
            // 
            // lblPublisherDesc
            // 
            this.lblPublisherDesc.AutoSize = true;
            this.lblPublisherDesc.Location = new System.Drawing.Point(7, 46);
            this.lblPublisherDesc.Name = "lblPublisherDesc";
            this.lblPublisherDesc.Size = new System.Drawing.Size(28, 13);
            this.lblPublisherDesc.TabIndex = 6;
            this.lblPublisherDesc.Text = "Opis";
            // 
            // txtPublisherWeb
            // 
            this.txtPublisherWeb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisherWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBS, "website", true));
            this.txtPublisherWeb.Location = new System.Drawing.Point(90, 69);
            this.txtPublisherWeb.Multiline = true;
            this.txtPublisherWeb.Name = "txtPublisherWeb";
            this.txtPublisherWeb.Size = new System.Drawing.Size(185, 20);
            this.txtPublisherWeb.TabIndex = 5;
            // 
            // publisherBS
            // 
            this.publisherBS.DataMember = "publisher";
            this.publisherBS.DataSource = this.librarianDS;
            // 
            // librarianDS
            // 
            this.librarianDS.DataSetName = "LibrarianDS";
            this.librarianDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPublisherDesc
            // 
            this.txtPublisherDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisherDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBS, "description", true));
            this.txtPublisherDesc.Location = new System.Drawing.Point(90, 43);
            this.txtPublisherDesc.Multiline = true;
            this.txtPublisherDesc.Name = "txtPublisherDesc";
            this.txtPublisherDesc.Size = new System.Drawing.Size(185, 20);
            this.txtPublisherDesc.TabIndex = 3;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisherName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBS, "name", true));
            this.txtPublisherName.Location = new System.Drawing.Point(90, 17);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(185, 20);
            this.txtPublisherName.TabIndex = 1;
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(7, 20);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(34, 13);
            this.lblPublisherName.TabIndex = 0;
            this.lblPublisherName.Text = "Naziv";
            // 
            // grpPublisherPreview
            // 
            this.grpPublisherPreview.Controls.Add(this.dgvPublisher);
            this.grpPublisherPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublisherPreview.Location = new System.Drawing.Point(0, 0);
            this.grpPublisherPreview.Name = "grpPublisherPreview";
            this.grpPublisherPreview.Size = new System.Drawing.Size(561, 372);
            this.grpPublisherPreview.TabIndex = 1;
            this.grpPublisherPreview.TabStop = false;
            this.grpPublisherPreview.Text = "Prikaz";
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.AllowUserToAddRows = false;
            this.dgvPublisher.AllowUserToDeleteRows = false;
            this.dgvPublisher.AutoGenerateColumns = false;
            this.dgvPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPublisher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPublisher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtID,
            this.dgvTxtName,
            this.dgvTxtDescription,
            this.dgvTxtWebsite});
            this.dgvPublisher.DataSource = this.publisherBS;
            this.dgvPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPublisher.Location = new System.Drawing.Point(3, 16);
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPublisher.Size = new System.Drawing.Size(555, 353);
            this.dgvPublisher.TabIndex = 0;
            // 
            // dgvTxtID
            // 
            this.dgvTxtID.DataPropertyName = "id";
            this.dgvTxtID.HeaderText = "id";
            this.dgvTxtID.Name = "dgvTxtID";
            this.dgvTxtID.ReadOnly = true;
            this.dgvTxtID.Visible = false;
            // 
            // dgvTxtName
            // 
            this.dgvTxtName.DataPropertyName = "name";
            this.dgvTxtName.HeaderText = "Naziv";
            this.dgvTxtName.Name = "dgvTxtName";
            this.dgvTxtName.ReadOnly = true;
            // 
            // dgvTxtDescription
            // 
            this.dgvTxtDescription.DataPropertyName = "description";
            this.dgvTxtDescription.HeaderText = "Opis";
            this.dgvTxtDescription.Name = "dgvTxtDescription";
            this.dgvTxtDescription.ReadOnly = true;
            // 
            // dgvTxtWebsite
            // 
            this.dgvTxtWebsite.DataPropertyName = "website";
            this.dgvTxtWebsite.HeaderText = "Web";
            this.dgvTxtWebsite.Name = "dgvTxtWebsite";
            this.dgvTxtWebsite.ReadOnly = true;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.spcType);
            this.tabType.Location = new System.Drawing.Point(4, 22);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(852, 378);
            this.tabType.TabIndex = 1;
            this.tabType.Text = "Tip";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // spcType
            // 
            this.spcType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcType.Location = new System.Drawing.Point(3, 3);
            this.spcType.Name = "spcType";
            // 
            // spcType.Panel1
            // 
            this.spcType.Panel1.Controls.Add(this.grpTypeEdit);
            // 
            // spcType.Panel2
            // 
            this.spcType.Panel2.Controls.Add(this.grpTypePreview);
            this.spcType.Size = new System.Drawing.Size(846, 372);
            this.spcType.SplitterDistance = 282;
            this.spcType.TabIndex = 0;
            // 
            // grpTypeEdit
            // 
            this.grpTypeEdit.Controls.Add(this.btnAddType);
            this.grpTypeEdit.Controls.Add(this.btnEditType);
            this.grpTypeEdit.Controls.Add(this.btnRemoveType);
            this.grpTypeEdit.Controls.Add(this.lblTypeDesc);
            this.grpTypeEdit.Controls.Add(this.txtTypeDesc);
            this.grpTypeEdit.Controls.Add(this.txtTypeName);
            this.grpTypeEdit.Controls.Add(this.lblTypeName);
            this.grpTypeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTypeEdit.Location = new System.Drawing.Point(0, 0);
            this.grpTypeEdit.Name = "grpTypeEdit";
            this.grpTypeEdit.Size = new System.Drawing.Size(282, 372);
            this.grpTypeEdit.TabIndex = 0;
            this.grpTypeEdit.TabStop = false;
            this.grpTypeEdit.Text = "Uredi";
            // 
            // btnAddType
            // 
            this.btnAddType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddType.Location = new System.Drawing.Point(39, 321);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 45);
            this.btnAddType.TabIndex = 28;
            this.btnAddType.Text = "Dodaj";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnEditType
            // 
            this.btnEditType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditType.Location = new System.Drawing.Point(120, 321);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(75, 45);
            this.btnEditType.TabIndex = 27;
            this.btnEditType.Text = "Uredi";
            this.btnEditType.UseVisualStyleBackColor = true;
            // 
            // btnRemoveType
            // 
            this.btnRemoveType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveType.Location = new System.Drawing.Point(201, 321);
            this.btnRemoveType.Name = "btnRemoveType";
            this.btnRemoveType.Size = new System.Drawing.Size(75, 45);
            this.btnRemoveType.TabIndex = 26;
            this.btnRemoveType.Text = "Obriši";
            this.btnRemoveType.UseVisualStyleBackColor = true;
            // 
            // lblTypeDesc
            // 
            this.lblTypeDesc.AutoSize = true;
            this.lblTypeDesc.Location = new System.Drawing.Point(8, 45);
            this.lblTypeDesc.Name = "lblTypeDesc";
            this.lblTypeDesc.Size = new System.Drawing.Size(28, 13);
            this.lblTypeDesc.TabIndex = 10;
            this.lblTypeDesc.Text = "Opis";
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBS, "description", true));
            this.txtTypeDesc.Location = new System.Drawing.Point(91, 42);
            this.txtTypeDesc.Multiline = true;
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.Size = new System.Drawing.Size(185, 20);
            this.txtTypeDesc.TabIndex = 9;
            // 
            // typeBS
            // 
            this.typeBS.DataMember = "type";
            this.typeBS.DataSource = this.librarianDS;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBS, "name", true));
            this.txtTypeName.Location = new System.Drawing.Point(91, 16);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(185, 20);
            this.txtTypeName.TabIndex = 8;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(8, 19);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(34, 13);
            this.lblTypeName.TabIndex = 7;
            this.lblTypeName.Text = "Naziv";
            // 
            // grpTypePreview
            // 
            this.grpTypePreview.Controls.Add(this.dgvType);
            this.grpTypePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTypePreview.Location = new System.Drawing.Point(0, 0);
            this.grpTypePreview.Name = "grpTypePreview";
            this.grpTypePreview.Size = new System.Drawing.Size(560, 372);
            this.grpTypePreview.TabIndex = 0;
            this.grpTypePreview.TabStop = false;
            this.grpTypePreview.Text = "Prikaz";
            // 
            // dgvType
            // 
            this.dgvType.AllowUserToAddRows = false;
            this.dgvType.AllowUserToDeleteRows = false;
            this.dgvType.AutoGenerateColumns = false;
            this.dgvType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtTypeName,
            this.dgvTxtTypeDesc});
            this.dgvType.DataSource = this.typeBS;
            this.dgvType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvType.Location = new System.Drawing.Point(3, 16);
            this.dgvType.Name = "dgvType";
            this.dgvType.ReadOnly = true;
            this.dgvType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvType.Size = new System.Drawing.Size(554, 353);
            this.dgvType.TabIndex = 0;
            // 
            // dgvTxtTypeName
            // 
            this.dgvTxtTypeName.DataPropertyName = "name";
            this.dgvTxtTypeName.HeaderText = "Naziv";
            this.dgvTxtTypeName.Name = "dgvTxtTypeName";
            this.dgvTxtTypeName.ReadOnly = true;
            // 
            // dgvTxtTypeDesc
            // 
            this.dgvTxtTypeDesc.DataPropertyName = "description";
            this.dgvTxtTypeDesc.HeaderText = "Opis";
            this.dgvTxtTypeDesc.Name = "dgvTxtTypeDesc";
            this.dgvTxtTypeDesc.ReadOnly = true;
            // 
            // tabCategory
            // 
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Size = new System.Drawing.Size(852, 378);
            this.tabCategory.TabIndex = 2;
            this.tabCategory.Text = "Kategorija";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // publisherTA
            // 
            this.publisherTA.ClearBeforeFill = true;
            // 
            // typeTA
            // 
            this.typeTA.ClearBeforeFill = true;
            // 
            // frmTPCEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 404);
            this.Controls.Add(this.tbcTPC);
            this.Name = "frmTPCEdit";
            this.Text = "Uredi";
            this.Load += new System.EventHandler(this.frmTPCEdit_Load);
            this.tbcTPC.ResumeLayout(false);
            this.tabPublisher.ResumeLayout(false);
            this.spcPublisher.Panel1.ResumeLayout(false);
            this.spcPublisher.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPublisher)).EndInit();
            this.spcPublisher.ResumeLayout(false);
            this.grpPublisher.ResumeLayout(false);
            this.grpPublisher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).EndInit();
            this.grpPublisherPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.tabType.ResumeLayout(false);
            this.spcType.Panel1.ResumeLayout(false);
            this.spcType.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcType)).EndInit();
            this.spcType.ResumeLayout(false);
            this.grpTypeEdit.ResumeLayout(false);
            this.grpTypeEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).EndInit();
            this.grpTypePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTPC;
        private System.Windows.Forms.TabPage tabPublisher;
        private System.Windows.Forms.SplitContainer spcPublisher;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.DataGridView dgvPublisher;
        private LibrarianDS librarianDS;
        private System.Windows.Forms.BindingSource publisherBS;
        private LibrarianDSTableAdapters.publisherTA publisherTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPublisherDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPublisherWeb;
        private System.Windows.Forms.GroupBox grpPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtWebsite;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.GroupBox grpPublisherPreview;
        private System.Windows.Forms.TextBox txtPublisherDesc;
        private System.Windows.Forms.TextBox txtPublisherWeb;
        private System.Windows.Forms.Label lblPublisherWeb;
        private System.Windows.Forms.Label lblPublisherDesc;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnEditPublisher;
        private System.Windows.Forms.Button btnRemovePublisher;
        private System.Windows.Forms.SplitContainer spcType;
        private System.Windows.Forms.GroupBox grpTypeEdit;
        private System.Windows.Forms.GroupBox grpTypePreview;
        private System.Windows.Forms.DataGridView dgvType;
        private System.Windows.Forms.BindingSource typeBS;
        private LibrarianDSTableAdapters.typeTA typeTA;
        private System.Windows.Forms.Label lblTypeDesc;
        private System.Windows.Forms.TextBox txtTypeDesc;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTypeDesc;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Button btnRemoveType;
    }
}