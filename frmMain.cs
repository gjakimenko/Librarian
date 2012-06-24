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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WriteToStatus("Welcome to Librarian...", 5000);
        }

        private void tsiCatalogList_Click(object sender, EventArgs e)
        {
            OpenCatalog();
        }

        /*
         * Tries to focus form if exists as Child of main form
         */
        public bool focusForm(string formName)
        {
            // if form already opened, focus on form
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formName)
                {
                    form.Focus();
                    return true;
                }
            }

            return false;
        }

        /*
         * Open catalog form as child
         */
        private void OpenCatalog()
        {
            if (!focusForm("frmCatalog"))
            {
                frmCatalog FrmCatalog = new frmCatalog();
                FrmCatalog.MdiParent = this;
                FrmCatalog.StartPosition = FormStartPosition.CenterParent;
                FrmCatalog.Show();
            }
        }

        /*
         * Open BookUpdate form as child
         */
        private void addBook()
        {
            if (!focusForm("frmBookUpdate"))
            {
                frmBookUpdate FrmBookUpdate = new frmBookUpdate();
                FrmBookUpdate.MdiParent = this;
                FrmBookUpdate.StartPosition = FormStartPosition.CenterParent;
                FrmBookUpdate.Show();
            }
        }

        /*
         * Function for writing status messages on main window status bar
         */
        public void WriteToStatus(string text, int duration)
        {
            // disable timer to prevent clearing status
            if (tmrClearStatus.Enabled)
            {
                tmrClearStatus.Stop();
            }
            
            tslStatus.Text = text;

            tmrClearStatus.Interval = duration;
            tmrClearStatus.Start();
        }

        private void tmrClearStatus_Tick(object sender, EventArgs e)
        {
            // clean status and stop timer when time is up!
            tslStatus.Text = "";
            tmrClearStatus.Stop();
        }

        private void tsiCatalogAdd_Click(object sender, EventArgs e)
        {
            addBook();
        }

        private void tsiRentUser_Click(object sender, EventArgs e)
        {
            if (!focusForm("frmUsers"))
            {
                frmUsers FrmUsers = new frmUsers();
                FrmUsers.MdiParent = this;
                FrmUsers.StartPosition = FormStartPosition.CenterParent;
                FrmUsers.Show(); 
            }
        }

        private void tsiRentList_Click(object sender, EventArgs e)
        {
            if (!focusForm("frmRents"))
            {
                frmUserRents FrmRents = new frmUserRents();
                FrmRents.MdiParent = this;
                FrmRents.StartPosition = FormStartPosition.CenterParent;
                FrmRents.Show(); 
            }
        }
    }
}
