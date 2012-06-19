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

        private void frmBookUpdate_Load(object sender, EventArgs e)
        {
            this.categoryTA.Fill(this.librarianDS.category);
            this.typeTA.Fill(this.librarianDS.type);
            this.publisherTA.Fill(this.librarianDS.publisher);
            this.bookTA.FillById(this.librarianDS.book, this.bookId);

            this.Text = "Uredi: " + txtTitle.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // unload the form
            this.Close();
        }
    }
}
