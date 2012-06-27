using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Librarian
    {
        LibrarianDS librarianDS = new LibrarianDS();
        LibrarianDSTableAdapters.bookTA bTA = new LibrarianDSTableAdapters.bookTA();
        LibrarianDSTableAdapters.typeTA tTA = new LibrarianDSTableAdapters.typeTA();
        LibrarianDSTableAdapters.categoryTA cTA = new LibrarianDSTableAdapters.categoryTA();
        LibrarianDSTableAdapters.publisherTA pTA = new LibrarianDSTableAdapters.publisherTA();

        /*
         * Inserts new book into database
         * return True if book successfully added to database
         */
        public bool insertBook(string ISBN10, string ISBN13, string title, string author, int year, int stock, int typeId, int publisherId, int categoryId)
        {
            this.tTA.Fill(this.librarianDS.type);
            this.cTA.Fill(this.librarianDS.category);
            this.pTA.Fill(this.librarianDS.publisher);
            this.bTA.Fill(this.librarianDS.book);
            return this.bTA.InsertBook(ISBN10, ISBN13, title, author, year, stock, typeId != -1 ? (int?)typeId : null, publisherId != -1 ? (int?)publisherId : null, categoryId != -1 ? (int?)categoryId : null) > 0;
        }

        /*
         * Inserts new book type in database
         * return int Id of inserted book type
         */
        public int insertType(string name, string description)
        {
            return Convert.ToInt32(this.tTA.InsertType(name, description));
        }

        /*
         * Inserts new publisher in database
         * return int Id of inserted publisher
         */
        public int insertPublisher(string name, string description, string website)
        {
            return Convert.ToInt32(this.pTA.InsertPublisher(name, description, website));
        }

        /*
         * Inserts new category in database
         * return int Id of inserted category
         */
        public int insertCategory(string name, string description)
        {
            return Convert.ToInt32(this.cTA.InsertCategory(name, description));
        }
    }
}
