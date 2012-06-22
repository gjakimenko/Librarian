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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarianDS.user' table. You can move, or remove it, as needed.
            this.userTA.Fill(this.librarianDS.user);

        }
        /*
         * Edit user row in database
         */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.userBS.EndEdit();
            this.userTA.Update(librarianDS);
            dgvUsers.Refresh();
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.userBS.AddNew();
            btnAdd.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.userBS.RemoveCurrent();
        }

    }
}
