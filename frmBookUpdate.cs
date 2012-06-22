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
        /*
         *  Function overload
         */
        public frmBookUpdate()
        {
            InitializeComponent();
        }
        /*
         *  Function overload
         */
        public frmBookUpdate(int bookId)
        {
            InitializeComponent();

            this.bookId = bookId;
        }
        
        private void frmBookUpdate_Load(object sender, EventArgs e)
        {
            if (this.bookId > 0)
            {
                this.categoryTA.Fill(this.librarianDS.category);
                this.typeTA.Fill(this.librarianDS.type);
                this.publisherTA.Fill(this.librarianDS.publisher);
                this.bookTA.FillById(this.librarianDS.book, this.bookId);

                this.Text = "Uredi: " + txtTitle.Text; 
            }
            else
            {
                this.Text = "Dodaj: " + txtTitle.Text;
                this.grpEdit.Text = "Dodaj:";
                this.btnEdit.Text = "Dodaj";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // unload the form
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.bookBS.EndEdit();
            this.bookTA.Update(librarianDS.book);
            this.Close();
        }

        private void frmBookUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmCatalog")
                {
                    ((frmCatalog)form).catalogRefresh();
                }
            }
        }
            
    }
}
