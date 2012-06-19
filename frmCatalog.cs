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
            this.bookTA.FillWithRelations(this.librarianDS.book);

        }

        private void dgvCatalog_Resize(object sender, EventArgs e)
        {
            AdjustCatalogColumnsSize();
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
    }
}
