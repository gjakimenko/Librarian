﻿using System;
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
        public int tabPage;

        public frmTPCEdit()
        {
            InitializeComponent();
        }

        public frmTPCEdit(int tabPage)
        {
            InitializeComponent();
            this.tbcTPC.SelectedIndex = tabPage;
        }

        private void frmTPCEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarianDS.category' table. You can move, or remove it, as needed.
            this.categoryTA.Fill(this.librarianDS.category);
            // TODO: This line of code loads data into the 'librarianDS.type' table. You can move, or remove it, as needed.
            this.typeTA.Fill(this.librarianDS.type);
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
            try
            {
                this.publisherBS.EndEdit();
                this.publisherTA.Update(librarianDS);
                dgvPublisher.Refresh();
                btnAddPublisher.Enabled = true;
                // Calling function from frmMain
                ((frmMain)this.MdiParent).WriteToStatus("Izdavač ažuriran...", 5000);
            }
            catch (Exception)
            {
                ((frmMain)this.MdiParent).WriteToStatus("Ispunite navedena polja...", 5000);
            }
        }

        private void btnRemovePublisher_Click(object sender, EventArgs e)
        {
            this.publisherBS.RemoveCurrent();
            this.publisherTA.Update(librarianDS);
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Izdavač obrisan...", 5000);
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            this.typeBS.AddNew();
            btnAddType.Enabled = false;
            ((frmMain)this.MdiParent).WriteToStatus("Unesite naziv tipa i opis, zatim pritistnite Uredi", 5000);
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeBS.EndEdit();
                this.typeTA.Update(librarianDS);
                dgvType.Refresh();
                btnAddType.Enabled = true;
                // Calling function from frmMain
                ((frmMain)this.MdiParent).WriteToStatus("Tip ažuriran...", 5000);
            }
            catch (Exception)
            {
                ((frmMain)this.MdiParent).WriteToStatus("Ispunite sva navedena polja...", 5000);
            }
        }

        private void btnRemoveType_Click(object sender, EventArgs e)
        {
            this.typeBS.RemoveCurrent();
            this.typeTA.Update(librarianDS);
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Tip obrisan...", 5000);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            this.categoryBS.AddNew();
            btnAddCategory.Enabled = false;
            ((frmMain)this.MdiParent).WriteToStatus("Unesite naziv kategorije i opis, zatim pritistnite Uredi", 5000);
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryBS.EndEdit();
                this.categoryTA.Update(librarianDS);
                dgvCategory.Refresh();
                btnAddCategory.Enabled = true;
                // Calling function from frmMain
                ((frmMain)this.MdiParent).WriteToStatus("Kategorija ažurirana...", 5000);
            }
            catch (Exception)
            {
                ((frmMain)this.MdiParent).WriteToStatus("Ispunite sva navedena polja...", 5000);
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            this.categoryBS.RemoveCurrent();
            this.categoryTA.Update(librarianDS);
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Kategorija obrisana...", 5000);
        }

    }
}
