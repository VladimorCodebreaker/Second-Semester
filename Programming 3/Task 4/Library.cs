using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_4
{
    internal class Library
    {
        public string Name { get; set; }

        public List<Book> Books = new List<Book>();

        public void Add(string title, string author, string publisher,
            DateTime releaseDate, string isbn)
        {
            Book bookA = new Book
            {
                Author = author,
                Title = title,
                ISBN = isbn,
                Publisher = publisher,
                ReleaseDate = releaseDate
            };
            Books.Add(bookA);
        }

        public void Delete(Book book)
        {
            Books.Remove(book);
        }

        public void Display(Book book)
        {
            Console.WriteLine("Title: {0}\n" +
                "Author: {1}\n" +
                "ISBN: {2}\n" +
                "Publisher: {3}\n" +
                "ReleaseDate: {4}", book.Title, book.Author, book.ISBN,
                book.Publisher, book.ReleaseDate);
            Console.WriteLine("------------------------------------ \n");
        }

        public List<Book> Search(string author)
        {
            return Books.Where(b => b.Author == author).ToList();
        }
    }
}
