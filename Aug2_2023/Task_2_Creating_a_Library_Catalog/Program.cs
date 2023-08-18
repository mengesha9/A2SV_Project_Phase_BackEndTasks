namespace LibraryCatalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library("MyLibrary", "123 Main St.");

            Book book1 = new Book("Fikir Eske Mekabir", "hadis alemayehu", "1234567890", 2000);
            Book book2 = new Book(" The art of not giving a fuck", "mark manson", "0987654321", 2016);
            MediaItem mediaItem1 = new MediaItem("Avengers", "DVD", 120);
            MediaItem mediaItem2 = new MediaItem("Game of thrones", "CD", 60);

            MediaItem mediaItem3 = new MediaItem("breaking bad", "CD", 45);
            library.addBook(book1);
            library.addBook(book2);
            library.addMediaItem(mediaItem1);
            library.addMediaItem(mediaItem2);

            library.printCatalog();

            Console.WriteLine(library.sereachBook(book2));
            Console.WriteLine(library.sereachItem(mediaItem3));


        }
    }
}