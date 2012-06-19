namespace Library
{
    partial class frmBookUpdate
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
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtISBN13 = new System.Windows.Forms.TextBox();
            this.lblISBN13 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.mtbYear = new System.Windows.Forms.MaskedTextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN10 = new System.Windows.Forms.TextBox();
            this.lblISBN10 = new System.Windows.Forms.Label();
            this.librarianDS = new Library.LibrarianDS();
            this.bookBS = new System.Windows.Forms.BindingSource(this.components);
            this.bookTA = new Library.LibrarianDSTableAdapters.bookTA();
            this.publisherBS = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTA = new Library.LibrarianDSTableAdapters.publisherTA();
            this.typeBS = new System.Windows.Forms.BindingSource(this.components);
            this.typeTA = new Library.LibrarianDSTableAdapters.typeTA();
            this.categoryBS = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTA = new Library.LibrarianDSTableAdapters.categoryTA();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBS)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEdit
            // 
            this.grpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEdit.Controls.Add(this.btnCancel);
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
            this.grpEdit.Size = new System.Drawing.Size(521, 311);
            this.grpEdit.TabIndex = 1;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Uredi";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(129, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 45);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(413, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 45);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(306, 256);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 45);
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
            this.txtISBN13.Size = new System.Drawing.Size(386, 20);
            this.txtISBN13.TabIndex = 19;
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
            this.cmbCategory.Size = new System.Drawing.Size(386, 21);
            this.cmbCategory.TabIndex = 17;
            this.cmbCategory.ValueMember = "id";
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
            this.cmbType.Size = new System.Drawing.Size(386, 21);
            this.cmbType.TabIndex = 15;
            this.cmbType.ValueMember = "id";
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
            this.nupStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupStock.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBS, "stock", true));
            this.nupStock.Location = new System.Drawing.Point(414, 148);
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
            this.cmbPublisher.Size = new System.Drawing.Size(386, 21);
            this.cmbPublisher.TabIndex = 8;
            this.cmbPublisher.ValueMember = "id";
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
            this.mtbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "year", true));
            this.mtbYear.Location = new System.Drawing.Point(415, 95);
            this.mtbYear.Mask = "0000";
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.Size = new System.Drawing.Size(99, 20);
            this.mtbYear.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBS, "author", true));
            this.txtAuthor.Location = new System.Drawing.Point(129, 69);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(386, 20);
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
            this.txtTitle.Size = new System.Drawing.Size(386, 20);
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
            this.txtISBN10.Size = new System.Drawing.Size(386, 20);
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
            // librarianDS
            // 
            this.librarianDS.DataSetName = "LibrarianDS";
            this.librarianDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBS
            // 
            this.bookBS.DataMember = "book";
            this.bookBS.DataSource = this.librarianDS;
            // 
            // bookTA
            // 
            this.bookTA.ClearBeforeFill = true;
            // 
            // publisherBS
            // 
            this.publisherBS.DataMember = "publisher";
            this.publisherBS.DataSource = this.librarianDS;
            // 
            // publisherTA
            // 
            this.publisherTA.ClearBeforeFill = true;
            // 
            // typeBS
            // 
            this.typeBS.DataMember = "type";
            this.typeBS.DataSource = this.librarianDS;
            // 
            // typeTA
            // 
            this.typeTA.ClearBeforeFill = true;
            // 
            // categoryBS
            // 
            this.categoryBS.DataMember = "category";
            this.categoryBS.DataSource = this.librarianDS;
            // 
            // categoryTA
            // 
            this.categoryTA.ClearBeforeFill = true;
            // 
            // frmBookUpdate
            // 
            this.AcceptButton = this.btnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(545, 335);
            this.Controls.Add(this.grpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBookUpdate";
            this.Text = "Uredi";
            this.Load += new System.EventHandler(this.frmBookUpdate_Load);
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtISBN13;
        private System.Windows.Forms.Label lblISBN13;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nupStock;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.MaskedTextBox mtbYear;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtISBN10;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.Button btnCancel;
        private LibrarianDS librarianDS;
        private System.Windows.Forms.BindingSource bookBS;
        private LibrarianDSTableAdapters.bookTA bookTA;
        private System.Windows.Forms.BindingSource publisherBS;
        private LibrarianDSTableAdapters.publisherTA publisherTA;
        private System.Windows.Forms.BindingSource typeBS;
        private LibrarianDSTableAdapters.typeTA typeTA;
        private System.Windows.Forms.BindingSource categoryBS;
        private LibrarianDSTableAdapters.categoryTA categoryTA;
    }
}