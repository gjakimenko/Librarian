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
    public partial class frmUserRents : Form
    {
        public frmUserRents()
        {
            InitializeComponent();
        }

        private void frmRents_Load(object sender, EventArgs e)
        {
            this.bookTA.Fill(this.librarianDS.book);
            this.userTA.Fill(this.librarianDS.user);
            this.rentTA.FillWithRelations(this.librarianDS.rent);
        }

        private void dgvRents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openRent();
        }

        private void openRent()
        {
            if (!((frmMain)this.MdiParent).focusForm("frmRent"))
            {
                frmRent FrmRent = new frmRent(getSelectedRent());
                FrmRent.MdiParent = this.MdiParent;
                FrmRent.StartPosition = FormStartPosition.CenterParent;
                FrmRent.Show();
            }
        }

        /*
         * Returns currently selected book in DataGridView
         */
        private LibrarianDS.rentRow getSelectedRent()
        {
            DataRowView current = (DataRowView)dgvRents.CurrentRow.DataBoundItem;
            LibrarianDS.rentRow selectedRent = (LibrarianDS.rentRow)current.Row;

            return selectedRent;
        }

        public void refresh()
        {
            this.rentTA.FillWithRelations(this.librarianDS.rent);
            dgvRents.Refresh();
        }

        private void tsmRent_Click(object sender, EventArgs e)
        {
            openRent();
        }

        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"mailto:" + getSelectedRent().userRow.email + "&subject=Vrati knjigu!");
        }
    }
}
