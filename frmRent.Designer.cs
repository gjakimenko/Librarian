namespace Library
{
    partial class frmRent
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
            this.grpKnjiga = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN10 = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.typeBS = new System.Windows.Forms.BindingSource(this.components);
            this.librarianDS = new Library.LibrarianDS();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblISBN10 = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.bookBS = new System.Windows.Forms.BindingSource(this.components);
            this.grpKorisnik = new System.Windows.Forms.GroupBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBrojtelefona = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.grpAktivnosti = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.bookTA = new Library.LibrarianDSTableAdapters.bookTA();
            this.publisherBS = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTA = new Library.LibrarianDSTableAdapters.publisherTA();
            this.typeTA = new Library.LibrarianDSTableAdapters.typeTA();
            this.categoryBS = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTA = new Library.LibrarianDSTableAdapters.categoryTA();
            this.userTA = new Library.LibrarianDSTableAdapters.userTA();
            this.userBS = new System.Windows.Forms.BindingSource(this.components);
            this.rentBS = new System.Windows.Forms.BindingSource(this.components);
            this.rentTA = new Library.LibrarianDSTableAdapters.rentTA();
            this.grpKnjiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).BeginInit();
            this.grpKorisnik.SuspendLayout();
            this.grpAktivnosti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBS)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKnjiga
            // 
            this.grpKnjiga.Controls.Add(this.txtTitle);
            this.grpKnjiga.Controls.Add(this.txtISBN10);
            this.grpKnjiga.Controls.Add(this.txtCategory);
            this.grpKnjiga.Controls.Add(this.txtType);
            this.grpKnjiga.Controls.Add(this.txtPublisher);
            this.grpKnjiga.Controls.Add(this.txtAuthor);
            this.grpKnjiga.Controls.Add(this.lblAutor);
            this.grpKnjiga.Controls.Add(this.lblISBN10);
            this.grpKnjiga.Controls.Add(this.lblNaslov);
            this.grpKnjiga.Controls.Add(this.lblKategorija);
            this.grpKnjiga.Controls.Add(this.lblIzdavac);
            this.grpKnjiga.Controls.Add(this.lblTip);
            this.grpKnjiga.Location = new System.Drawing.Point(12, 12);
            this.grpKnjiga.Name = "grpKnjiga";
            this.grpKnjiga.Size = new System.Drawing.Size(269, 184);
            this.grpKnjiga.TabIndex = 7;
            this.grpKnjiga.TabStop = false;
            this.grpKnjiga.Text = "Knjiga";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(79, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(177, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtISBN10
            // 
            this.txtISBN10.Location = new System.Drawing.Point(79, 18);
            this.txtISBN10.Name = "txtISBN10";
            this.txtISBN10.ReadOnly = true;
            this.txtISBN10.Size = new System.Drawing.Size(177, 20);
            this.txtISBN10.TabIndex = 0;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(79, 153);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(177, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBS, "name", true));
            this.txtType.Location = new System.Drawing.Point(79, 126);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(177, 20);
            this.txtType.TabIndex = 4;
            // 
            // typeBS
            // 
            this.typeBS.DataMember = "type";
            this.typeBS.DataSource = this.librarianDS;
            // 
            // librarianDS
            // 
            this.librarianDS.DataSetName = "LibrarianDS";
            this.librarianDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(79, 99);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(177, 20);
            this.txtPublisher.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(79, 72);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(177, 20);
            this.txtAuthor.TabIndex = 2;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 75);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // lblISBN10
            // 
            this.lblISBN10.AutoSize = true;
            this.lblISBN10.Location = new System.Drawing.Point(6, 21);
            this.lblISBN10.Name = "lblISBN10";
            this.lblISBN10.Size = new System.Drawing.Size(44, 13);
            this.lblISBN10.TabIndex = 5;
            this.lblISBN10.Text = "ISBN10";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(6, 48);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(40, 13);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(6, 156);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 4;
            this.lblKategorija.Text = "Kategorija";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(6, 102);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(45, 13);
            this.lblIzdavac.TabIndex = 1;
            this.lblIzdavac.Text = "Izdavač";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(6, 129);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip";
            // 
            // bookBS
            // 
            this.bookBS.DataMember = "book";
            this.bookBS.DataSource = this.librarianDS;
            // 
            // grpKorisnik
            // 
            this.grpKorisnik.Controls.Add(this.txtUserId);
            this.grpKorisnik.Controls.Add(this.lblEmail);
            this.grpKorisnik.Controls.Add(this.lblBrojtelefona);
            this.grpKorisnik.Controls.Add(this.lblID);
            this.grpKorisnik.Controls.Add(this.lblPrezime);
            this.grpKorisnik.Controls.Add(this.txtEmail);
            this.grpKorisnik.Controls.Add(this.txtPhone);
            this.grpKorisnik.Controls.Add(this.txtSurname);
            this.grpKorisnik.Controls.Add(this.txtName);
            this.grpKorisnik.Controls.Add(this.lblIme);
            this.grpKorisnik.Location = new System.Drawing.Point(288, 12);
            this.grpKorisnik.Name = "grpKorisnik";
            this.grpKorisnik.Size = new System.Drawing.Size(269, 184);
            this.grpKorisnik.TabIndex = 6;
            this.grpKorisnik.TabStop = false;
            this.grpKorisnik.Text = "Korisnik";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(79, 18);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(177, 20);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyUp);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // lblBrojtelefona
            // 
            this.lblBrojtelefona.AutoSize = true;
            this.lblBrojtelefona.Location = new System.Drawing.Point(6, 102);
            this.lblBrojtelefona.Name = "lblBrojtelefona";
            this.lblBrojtelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojtelefona.TabIndex = 20;
            this.lblBrojtelefona.Text = "Broj telefona";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "Članski broj";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(6, 48);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 18;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 99);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(177, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(79, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(177, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 72);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(6, 75);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime";
            // 
            // grpAktivnosti
            // 
            this.grpAktivnosti.Controls.Add(this.btnCancel);
            this.grpAktivnosti.Controls.Add(this.lblReturnDate);
            this.grpAktivnosti.Controls.Add(this.lblRentDate);
            this.grpAktivnosti.Controls.Add(this.dtpReturnDate);
            this.grpAktivnosti.Controls.Add(this.dtpRentDate);
            this.grpAktivnosti.Controls.Add(this.btnRent);
            this.grpAktivnosti.Location = new System.Drawing.Point(12, 202);
            this.grpAktivnosti.Name = "grpAktivnosti";
            this.grpAktivnosti.Size = new System.Drawing.Size(544, 70);
            this.grpAktivnosti.TabIndex = 8;
            this.grpAktivnosti.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(324, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(6, 45);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(100, 13);
            this.lblReturnDate.TabIndex = 4;
            this.lblReturnDate.Text = "Datum razduživanja";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Location = new System.Drawing.Point(6, 16);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(82, 13);
            this.lblRentDate.TabIndex = 3;
            this.lblRentDate.Text = "Datum posudbe";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(117, 42);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(139, 20);
            this.dtpReturnDate.TabIndex = 2;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Location = new System.Drawing.Point(117, 15);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(139, 20);
            this.dtpRentDate.TabIndex = 1;
            // 
            // btnRent
            // 
            this.btnRent.Enabled = false;
            this.btnRent.Location = new System.Drawing.Point(434, 14);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(104, 44);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Zaduži";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
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
            // userTA
            // 
            this.userTA.ClearBeforeFill = true;
            // 
            // userBS
            // 
            this.userBS.DataMember = "user";
            this.userBS.DataSource = this.librarianDS;
            // 
            // rentBS
            // 
            this.rentBS.DataMember = "rent";
            this.rentBS.DataSource = this.librarianDS;
            // 
            // rentTA
            // 
            this.rentTA.ClearBeforeFill = true;
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(569, 280);
            this.Controls.Add(this.grpAktivnosti);
            this.Controls.Add(this.grpKorisnik);
            this.Controls.Add(this.grpKnjiga);
            this.Name = "frmRent";
            this.Text = "Posudi";
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.grpKnjiga.ResumeLayout(false);
            this.grpKnjiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).EndInit();
            this.grpKorisnik.ResumeLayout(false);
            this.grpKorisnik.PerformLayout();
            this.grpAktivnosti.ResumeLayout(false);
            this.grpAktivnosti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKnjiga;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN10;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox grpKorisnik;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBrojtelefona;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.GroupBox grpAktivnosti;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Button btnRent;
        private LibrarianDS librarianDS;
        private System.Windows.Forms.BindingSource bookBS;
        private LibrarianDSTableAdapters.bookTA bookTA;
        private System.Windows.Forms.BindingSource publisherBS;
        private LibrarianDSTableAdapters.publisherTA publisherTA;
        private System.Windows.Forms.BindingSource typeBS;
        private LibrarianDSTableAdapters.typeTA typeTA;
        private System.Windows.Forms.BindingSource categoryBS;
        private LibrarianDSTableAdapters.categoryTA categoryTA;
        private LibrarianDSTableAdapters.userTA userTA;
        private System.Windows.Forms.BindingSource userBS;
        private System.Windows.Forms.BindingSource rentBS;
        private LibrarianDSTableAdapters.rentTA rentTA;
    }
}