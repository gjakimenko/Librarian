using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class frmCatalog : Form
    {
        public frmCatalog()
        {
            InitializeComponent();
        }

        private void frmCatalog_Load(object sender, EventArgs e)
        {
            this.categoryTA.Fill(this.librarianDS.category);
            this.typeTA.Fill(this.librarianDS.type);
            this.publisherTA.Fill(this.librarianDS.publisher);
            this.bookTA.FillWithRelations(this.librarianDS.book);
        }

        private void dgvCatalog_Resize(object sender, EventArgs e)
        {
            AdjustCatalogColumnsSize();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Fetch currently selected book and open for editing
            UpdateBook(getSelectedBook().id);
        }

        /*
         * Opens form for editing books
         */
        public void UpdateBook(int bookId)
        {
            frmBookUpdate FrmBookUpdate = new frmBookUpdate(bookId);
            FrmBookUpdate.MdiParent = this.MdiParent;
            FrmBookUpdate.Show();
        }

        /*
         * Opens form adding new book
         */
        public void AddBook()
        {
            frmBookUpdate FrmBookUpdate = new frmBookUpdate();
            FrmBookUpdate.MdiParent = this.MdiParent;
            FrmBookUpdate.Show();
        }

        /*
         * Returns currently selected book in DataGridView
         */
        private LibrarianDS.bookRow getSelectedBook()
        {
            DataRowView current = (DataRowView)dgvCatalog.CurrentRow.DataBoundItem;
            LibrarianDS.bookRow selectedBook = (LibrarianDS.bookRow)current.Row;

            return selectedBook;
        }

        /*
         * Change AutoSizeColumnMode if DGV is bigget than size of columns
         */
        private void AdjustCatalogColumnsSize()
        {

            int columnsSize = 0;
            foreach (DataGridViewColumn col in dgvCatalog.Columns)
            {
                columnsSize += col.Width;
            }

            if (dgvCatalog.Size.Width > columnsSize)
            {
                dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
        /*
         * Function for DataGridView refresh
         */
        
        public void catalogRefresh()
        {
            this.bookTA.Fill(this.librarianDS.book);
            dgvCatalog.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.bookBS.RemoveCurrent();
            this.bookTA.Update(librarianDS.book);
            // Calling function catalogRefresh
            catalogRefresh();
        }

        /*
         * Function for adding new book, function will generate error if some spaces are empty
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }
    }
}
