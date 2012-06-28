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
    public partial class frmTPCEdit : Form
    {
        public frmTPCEdit()
        {
            InitializeComponent();
        }

        private void frmTPCEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarianDS.publisher' table. You can move, or remove it, as needed.
            this.publisherTA.Fill(this.librarianDS.publisher);

        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            this.publisherBS.AddNew();
            btnAddPublisher.Enabled = false;
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Unesite podatke izdavača, zatim pritisnite Uredi", 5000);
        }

        private void btnEditPublisher_Click(object sender, EventArgs e)
        {
            this.publisherBS.EndEdit();
            this.publisherTA.Update(librarianDS);
            dgvPublisher.Refresh();
            btnAddPublisher.Enabled = true;
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Izdavač ažuriran...", 5000);
        }

        private void btnRemovePublisher_Click(object sender, EventArgs e)
        {
            this.publisherBS.RemoveCurrent();
            this.publisherTA.Update(librarianDS);
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Izdavač obrisan...", 5000);
        }

    }
}
