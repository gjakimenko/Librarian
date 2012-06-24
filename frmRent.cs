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
    public partial class frmRent : Form
    {
        private LibrarianDS.bookRow bookRow;
        private LibrarianDS.userRow userRow;
        private LibrarianDS.rentRow rentRow;

        public frmRent()
        {
            InitializeComponent();
        }

        public frmRent(LibrarianDS.bookRow bookRow)
        {
            InitializeComponent();

            this.bookRow = bookRow;

            dtpReturnDate.Value = System.DateTime.Now.Add(new System.TimeSpan(21, 0, 0, 0));
        }

        public frmRent(LibrarianDS.rentRow rentRow)
        {
            InitializeComponent();
            
            this.rentRow = rentRow;
            this.bookRow = rentRow.tbl_bookRow;
            this.userRow = rentRow.userRow;

            btnRent.Text = "Razduži";
            btnRent.Enabled = true;
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            // book is available in both, rent and return
            txtISBN10.Text = this.bookRow.ISBN10;
            txtTitle.Text = this.bookRow.title;
            txtAuthor.Text = this.bookRow.author;
            // check if book parameters are set, else display empty string
            txtPublisher.Text = this.bookRow.publisherRow != null ? this.bookRow.publisherRow.name : "";
            txtType.Text = this.bookRow.typeRow != null ? this.bookRow.typeRow.name : "";
            txtCategory.Text = this.bookRow.categoryRow != null ? this.bookRow.categoryRow.name : "";

            if (this.rentRow != null)
            {
                PopulateUserFields(this.userRow);
                txtUserId.Enabled = false;
            }
        }

        private void txtUserId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LibrarianDS.userRow userRow = findByUserId(Convert.ToInt32(txtUserId.Text));
                // if there is user with given id, show user's attributes in text controls and enable rent button
                if (userRow != null)
                {
                    PopulateUserFields(userRow);
                    txtUserId.SelectAll();

                    btnRent.Enabled = true;
                }
                // clean the text controls for user, disable rent button
                else
                {
                    txtSurname.Text = "";
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";

                    btnRent.Enabled = false;
                }
            }
        }

        /*
         * Populates user fields with data from userRow
         */
        private void PopulateUserFields(LibrarianDS.userRow userRow)
        {
            txtUserId.Text = userRow.id.ToString();
            txtSurname.Text = userRow.surname;
            txtName.Text = userRow.name;
            txtPhone.Text = userRow.phone;
            txtEmail.Text = userRow.email;
        }

        /*
         * Fetch user by user id
         * If user not found in database, return null
         */
        private LibrarianDS.userRow findByUserId(int userId)
        {
            try
            {
                this.userTA.FillByUserId(this.librarianDS.user, userId);
                return this.librarianDS.user.First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnRent_Click(object sender, EventArgs e)
        {
            //If form is called for rent - rent book
            if (btnRent.Text == "Zaduži")
            {
                RentBook();
            }
            else
            {
                if (this.rentTA.UpdateRent(true, rentRow.id) > 0)
                {
                    foreach (Form form in this.MdiParent.MdiChildren)
                    {
                        if (form.Name == "frmUserRents")
                        {
                            ((frmUserRents)form).refresh();
                        }
                    }
                    ((frmMain)this.MdiParent).WriteToStatus("Knjiga razdužena", 3000);
                    this.Close();
                }
            }
        }

        private void RentBook()
        {
            if (findByUserId(Convert.ToInt32(txtUserId.Text)) != null)
            {
                if (this.rentTA.InsertRent(Convert.ToInt32(txtUserId.Text), bookRow.id, dtpRentDate.Value, dtpReturnDate.Value, false) > 0)
                {
                    ((frmMain)this.MdiParent).WriteToStatus("Knjiga zadužena", 3000);
                    this.Close();
                }
            }
        }
    }
}
