using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryCatalog
{
    internal class Library
    {
        private string name;
        private string adress;
        private List<Book> books;
        private List<MediaItem> mediaitems;

        public Library(string _name, string _adress)
        {
            name = _name;
            adress = _adress;
            books= new List<Book>();
            mediaitems = new List<MediaItem>();
        }
        public  string Name
        {
            get{ return name ; }
            set{ name = value ;}

        }
        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
            }
        }
        public List<Book> Books
        {
            get { return books; }
            set
            {
                books = value;
            }
        }

        public List<MediaItem> MediaItems
        {
            get { return mediaitems; }
            set { mediaitems = value; }
        }

        public void addBook(Book book)
        {

            books.Add(book);

        }
        public void removeBook(Book book)
        {
            books.Remove(book);

        }

        public void addMediaItem(MediaItem item)
        {
            mediaitems.Add(item);
        }
        public void removeMediaItem(MediaItem item)
        {
            mediaitems.Remove(item);

        }
        public void printCatalog()
        {

            Console.WriteLine("these are the books in your library :");
            foreach(var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN}, Publication Year: {book.PublicationYear})");
            }

            Console.WriteLine("these are the mediaitems in your library :");

            foreach (var item in mediaitems)
            {
                Console.WriteLine($"{item.Title} ({item.MediaType}, Duration: {item.Duration} minutes)");
            }
            
        }


        public bool sereachBook(Book target)
        {
            foreach(var book in books)
            {
                if (target.Title == book.Title)
                {
                    return true;
                }

            }

            return false;
            

        }

        public bool sereachItem(MediaItem target)
        {
            foreach(var item in mediaitems)
            {
               if(item.Title == target.Title)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
