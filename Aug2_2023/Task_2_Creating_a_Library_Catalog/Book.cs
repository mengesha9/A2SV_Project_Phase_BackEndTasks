using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    internal class Book
    {

        private string title;
        private string author;
        private string isbn;
        private int publicationYear;

        public Book(string _title, string _author, string _isbn, int _publicationYear)
        {
            title = _title;
            author = _author;
            isbn = _isbn;
            publicationYear = _publicationYear;
           
        }

        public string Title
        {
            get { return title; }
            set { title = value; }


        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }

        }
        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value;}
        }
    }
}
