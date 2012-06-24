namespace Library
{
    partial class frmUserRents
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
            this.librarianDS = new Library.LibrarianDS();
            this.rentBS = new System.Windows.Forms.BindingSource(this.components);
            this.rentTA = new Library.LibrarianDSTableAdapters.rentTA();
            this.dgvRents = new System.Windows.Forms.DataGridView();
            this.dgvTxtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtUserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtUserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtRentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtReturned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBS = new System.Windows.Forms.BindingSource(this.components);
            this.bookTA = new Library.LibrarianDSTableAdapters.bookTA();
            this.userTA = new Library.LibrarianDSTableAdapters.userTA();
            this.userBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).BeginInit();
            this.cmsAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).BeginInit();
            this.SuspendLayout();
            // 
            // librarianDS
            // 
            this.librarianDS.DataSetName = "LibrarianDS";
            this.librarianDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dgvRents
            // 
            this.dgvRents.AllowUserToAddRows = false;
            this.dgvRents.AllowUserToDeleteRows = false;
            this.dgvRents.AutoGenerateColumns = false;
            this.dgvRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtId,
            this.dgvTxtTitle,
            this.dgvTxtAuthor,
            this.dgvTxtUserName,
            this.dgvTxtUserSurname,
            this.dgvTxtUserEmail,
            this.dataGridViewTextBoxColumn2,
            this.dgvTxtBookID,
            this.dgvTxtRentDate,
            this.dgvTxtReturnDate,
            this.dgvTxtReturned});
            this.dgvRents.ContextMenuStrip = this.cmsAction;
            this.dgvRents.DataSource = this.rentBS;
            this.dgvRents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRents.Location = new System.Drawing.Point(0, 0);
            this.dgvRents.Name = "dgvRents";
            this.dgvRents.ReadOnly = true;
            this.dgvRents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRents.Size = new System.Drawing.Size(832, 410);
            this.dgvRents.TabIndex = 1;
            this.dgvRents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRents_CellDoubleClick);
            // 
            // dgvTxtId
            // 
            this.dgvTxtId.DataPropertyName = "id";
            this.dgvTxtId.HeaderText = "ID";
            this.dgvTxtId.Name = "dgvTxtId";
            this.dgvTxtId.ReadOnly = true;
            this.dgvTxtId.Visible = false;
            // 
            // dgvTxtTitle
            // 
            this.dgvTxtTitle.DataPropertyName = "title";
            this.dgvTxtTitle.HeaderText = "Naslov";
            this.dgvTxtTitle.Name = "dgvTxtTitle";
            this.dgvTxtTitle.ReadOnly = true;
            // 
            // dgvTxtAuthor
            // 
            this.dgvTxtAuthor.DataPropertyName = "author";
            this.dgvTxtAuthor.HeaderText = "Autor";
            this.dgvTxtAuthor.Name = "dgvTxtAuthor";
            this.dgvTxtAuthor.ReadOnly = true;
            // 
            // dgvTxtUserName
            // 
            this.dgvTxtUserName.DataPropertyName = "name";
            this.dgvTxtUserName.HeaderText = "Korisničko ime";
            this.dgvTxtUserName.Name = "dgvTxtUserName";
            this.dgvTxtUserName.ReadOnly = true;
            // 
            // dgvTxtUserSurname
            // 
            this.dgvTxtUserSurname.DataPropertyName = "surname";
            this.dgvTxtUserSurname.HeaderText = "Korisničko prezime";
            this.dgvTxtUserSurname.Name = "dgvTxtUserSurname";
            this.dgvTxtUserSurname.ReadOnly = true;
            // 
            // dgvTxtUserEmail
            // 
            this.dgvTxtUserEmail.DataPropertyName = "email";
            this.dgvTxtUserEmail.HeaderText = "Korisnički E-mail";
            this.dgvTxtUserEmail.Name = "dgvTxtUserEmail";
            this.dgvTxtUserEmail.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "User ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dgvTxtBookID
            // 
            this.dgvTxtBookID.DataPropertyName = "book_id";
            this.dgvTxtBookID.HeaderText = "Book ID";
            this.dgvTxtBookID.Name = "dgvTxtBookID";
            this.dgvTxtBookID.ReadOnly = true;
            this.dgvTxtBookID.Visible = false;
            // 
            // dgvTxtRentDate
            // 
            this.dgvTxtRentDate.DataPropertyName = "rent_date";
            this.dgvTxtRentDate.HeaderText = "Datum posudbe";
            this.dgvTxtRentDate.Name = "dgvTxtRentDate";
            this.dgvTxtRentDate.ReadOnly = true;
            // 
            // dgvTxtReturnDate
            // 
            this.dgvTxtReturnDate.DataPropertyName = "return_date";
            this.dgvTxtReturnDate.HeaderText = "Datum razduženja";
            this.dgvTxtReturnDate.Name = "dgvTxtReturnDate";
            this.dgvTxtReturnDate.ReadOnly = true;
            // 
            // dgvTxtReturned
            // 
            this.dgvTxtReturned.DataPropertyName = "returned";
            this.dgvTxtReturned.HeaderText = "Razduženo";
            this.dgvTxtReturned.Name = "dgvTxtReturned";
            this.dgvTxtReturned.ReadOnly = true;
            // 
            // cmsAction
            // 
            this.cmsAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRent,
            this.tsmSendEmail});
            this.cmsAction.Name = "contextMenuStrip1";
            this.cmsAction.Size = new System.Drawing.Size(208, 70);
            // 
            // tsmRent
            // 
            this.tsmRent.Name = "tsmRent";
            this.tsmRent.Size = new System.Drawing.Size(207, 22);
            this.tsmRent.Text = "Razduži";
            this.tsmRent.Click += new System.EventHandler(this.tsmRent_Click);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(207, 22);
            this.tsmSendEmail.Text = "Pošalji molbu za vraćanje";
            this.tsmSendEmail.Click += new System.EventHandler(this.tsmSendEmail_Click);
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
            // userTA
            // 
            this.userTA.ClearBeforeFill = true;
            // 
            // userBS
            // 
            this.userBS.DataMember = "user";
            this.userBS.DataSource = this.librarianDS;
            // 
            // frmUserRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 410);
            this.Controls.Add(this.dgvRents);
            this.Name = "frmUserRents";
            this.Text = "Posudbe";
            this.Load += new System.EventHandler(this.frmRents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librarianDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).EndInit();
            this.cmsAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibrarianDS librarianDS;
        private System.Windows.Forms.BindingSource rentBS;
        private LibrarianDSTableAdapters.rentTA rentTA;
        private System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtUserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtUserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtRentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtReturnDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTxtReturned;
        private System.Windows.Forms.BindingSource bookBS;
        private LibrarianDSTableAdapters.bookTA bookTA;
        private LibrarianDSTableAdapters.userTA userTA;
        private System.Windows.Forms.BindingSource userBS;
        private System.Windows.Forms.ContextMenuStrip cmsAction;
        private System.Windows.Forms.ToolStripMenuItem tsmRent;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
    }
}