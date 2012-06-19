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
    public partial class frmBookUpdate : Form
    {
        int bookId;

        public frmBookUpdate()
        {
            InitializeComponent();
        }

        public frmBookUpdate(int bookId)
        {
            InitializeComponent();

            this.bookId = bookId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // unload the form
            this.Close();
        }
    }
}
