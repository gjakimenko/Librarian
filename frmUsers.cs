using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;


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
            //If mail isnt valid, program generates erorr message.
            if (IsValidEmail(txtEmail.Text))
            {
                this.userBS.EndEdit();
                this.userTA.Update(librarianDS);
                dgvUsers.Refresh();
                btnAdd.Enabled = true;
                ((frmMain)this.MdiParent).WriteToStatus("Korisnik ažuriran...", 5000);
            }
            else
            {
                MessageBox.Show("E-mail adresa koju ste upisali nije ispravna!");
            }
        }
        /*
         * Add user in database
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.userBS.AddNew();
            btnAdd.Enabled = false;
            ((frmMain)this.MdiParent).WriteToStatus("Unesite podatke korisnika, zatim pritisnite Uredi", 5000);
        }
        /*
         * Delete user row in database
         */
        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.userBS.RemoveCurrent();
            this.userTA.Update(librarianDS);
            // Calling function from frmMain
            ((frmMain)this.MdiParent).WriteToStatus("Korisnik obrisan...", 5000);
        }
        /*
         * Method for mail validation
         */
        public bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // generate string complient with sql LIKE operator
            string searchString = "%" + txtSearch.Text.Replace(" ", "%") + "%";
            this.userTA.SearchByFullName(this.librarianDS.user, searchString);
            dgvUsers.Refresh();
        }
    }
}
