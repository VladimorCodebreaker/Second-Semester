using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_4
{
    internal class Test
    {
        public static void Run()
        {
            Library library = new Library();

            library.Add("Dune", "Frank Herbert", "Penguin", DateTime.Now, "10392131jak");
            library.Add("Dune Messiah", "Frank Herbert", "Penguin", DateTime.Now, "llask2938");
            library.Add("The Antichrist", "Friedrich Nietzsche", "Carlson", DateTime.Now, "oaif3002");
            library.Add("Die Morgenröte", "Friedrich Nietzsche", "Carlson", DateTime.Now, "oi232ofwo");
            library.Add("ES", "Stephen King", "Tengen", DateTime.Now, "lqfk20");

            Console.WriteLine("----------Whole library-------------");

            if (library.Books.Count != 0)
            {
                foreach (Book book in library.Books)
                {
                    library.Display(book);
                }
            }

            Console.WriteLine("Books from Stephen King - Count - ?");
            var searchForBook = library.Search("Stephen King");
            Console.WriteLine(searchForBook.Count);

            foreach (Book book in searchForBook)
            {
                library.Delete(book);
            }

            Console.WriteLine("----------Whole library--------------");
            foreach (Book book in library.Books)
            {
                library.Display(book);
            }
        }
    }
}
