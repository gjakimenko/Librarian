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
            // if login form already opened, focus on form
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
    }
}
