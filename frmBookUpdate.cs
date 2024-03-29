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
    public partial class frmBookUpdate : Form
    {
        int bookId;
        Librarian librarian = new Librarian();

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
            this.categoryTA.Fill(this.librarianDS.category);
            this.typeTA.Fill(this.librarianDS.type);
            this.publisherTA.Fill(this.librarianDS.publisher);

            if (this.bookId > 0)
            {
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
            // fetch the data from controls
            try
            {
                // fetch the data from controls
                string ISBN10 = txtISBN10.Text.Trim();
                string ISBN13 = txtISBN13.Text.Trim();
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                int year = Convert.ToInt32(mtbYear.Text);
                int stock = Convert.ToInt32(nupStock.Value);
                int typeId = cmbType.SelectedIndex != -1 ? Convert.ToInt32(cmbType.SelectedValue) : string.IsNullOrEmpty(cmbType.Text) ? -1 : librarian.insertType(cmbType.Text, "");
                int publisherId = cmbPublisher.SelectedIndex != -1 ? Convert.ToInt32(cmbPublisher.SelectedValue) : string.IsNullOrEmpty(cmbPublisher.Text) ? -1 : librarian.insertPublisher(cmbPublisher.Text, "", "");
                int categoryId = cmbCategory.SelectedIndex != -1 ? Convert.ToInt32(cmbCategory.SelectedValue) : string.IsNullOrEmpty(cmbCategory.Text) ? -1 : librarian.insertCategory(cmbCategory.Text, "");

                if (string.IsNullOrEmpty(ISBN10) || string.IsNullOrEmpty(ISBN13) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                    throw new FormatException();
                }

                // if form is open for adding new book, insert to database
                if (btnEdit.Text == "Dodaj")
                {
                    // insert new book
                    if (librarian.insertBook(ISBN10, ISBN13, title, author, year, stock, typeId, publisherId, categoryId))
                    {
                        ((frmMain)this.MdiParent).WriteToStatus("Knjiga dodana", 3000);
                    }
                    else
                    {
                        ((frmMain)this.MdiParent).WriteToStatus("Greška kod zapisa u bazu", 3000);
                    }
                    this.Close();
                }
                // else, just update current record
                else
                {
                    this.typeTA.Fill(this.librarianDS.type);
                    this.publisherTA.Fill(this.librarianDS.publisher);
                    this.categoryTA.Fill(this.librarianDS.category);

                    cmbType.SelectedValue = typeId;
                    cmbPublisher.SelectedValue = publisherId;
                    cmbCategory.SelectedValue = categoryId;

                    this.bookBS.EndEdit();
                    this.bookTA.Update(librarianDS.book);
                    this.Close();
                }
            }
            catch (FormatException)
            {
                ((frmMain)this.MdiParent).WriteToStatus("Popunite sva polja...", 3000);
            }
        }

        private void frmBookUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            // iterate through all parent's children and find if catalog is open
            // and refresh dgv content
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form.Name == "frmCatalog")
                {
                    ((frmCatalog)form).catalogRefresh();
                }
            }
        }
    }
}
