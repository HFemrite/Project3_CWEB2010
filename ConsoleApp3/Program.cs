using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Book
    {
        public int BookID { get; set; }
        public String BookName { get; set; }
        public int Pages { get; set; }
        public String Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book[] bookArray = {
            new Book() { BookID = 1, BookName = "Legend", Pages = 352 , Author = "Marie Lu" },
            new Book() { BookID = 2, BookName = "Prodigy", Pages = 416 , Author = "Marie Lu" },
            new Book() { BookID = 3, BookName = "Champion", Pages = 384 , Author = "Marie Lu" },
            new Book() { BookID = 4, BookName = "The Da Vinci Code", Pages = 689 , Author = "Dan Brown" },
            new Book() { BookID = 5, BookName = "The Hobbit", Pages = 320 , Author = "J. R. R. Tolkien" },
            new Book() { BookID = 6, BookName = "The Lord of the Rings", Pages = 1137 , Author = "J. R. R. Tolkien" },
            new Book() { BookID = 7, BookName = "The Lion, the Witch and the Wardrobe", Pages = 208 , Author = "C. S. Lewis" },
            new Book() { BookID = 8, BookName = "Harry Potter and the Philosopher's Stone", Pages = 310 , Author = "J. K. Rowling" },
            new Book() { BookID = 9, BookName = "Harry Potter and the Chamber of Secrets", Pages = 341 , Author = "J. K. Rowling" },
            new Book() { BookID = 10, BookName = "Harry Potter and the Prizoner of Azkaban", Pages = 435 , Author = "J. K. Rowling" },
            new Book() { BookID = 11, BookName = "Harry Potter and the Goblet of Fire", Pages = 734 , Author = "J. K. Rowling" },
            new Book() { BookID = 12, BookName = "Harry Potter and the Order of the Pheonix", Pages = 870 , Author = "J. K. Rowling" },
            new Book() { BookID = 13, BookName = "Harry Potter and the Half-Blood Prince", Pages = 652 , Author = "J. K. Rowling" },
            new Book() { BookID = 14, BookName = "Harry Potter and the Deathly Hollows", Pages = 759 , Author = "J. K. Rowling" },
            new Book() { BookID = 15, BookName = "The Hunger Games", Pages = 374 , Author = "Suzanne Collins" },
            new Book() { BookID = 16, BookName = "Catching Fire", Pages = 391 , Author = "Suzanne Collins" },
            new Book() { BookID = 17, BookName = "Mockingjay", Pages = 400 , Author = "Suzanne Collins" },
            };
            var bookTitle = from a in bookArray
                            where a.BookName.StartsWith("The")
                            select a;
            var bookLength = from b in bookArray
                             orderby b.Pages descending
                             select b;
            var authorBooks = from c in bookArray
                              orderby c.Author
                              group c by c.Author;
            foreach (var book in authorBooks)
            {
                Console.WriteLine("==============   Author: {0}   ==============", book.Key);
                foreach (Book c in book)
                {
                    Console.WriteLine("Book Title: {0}", c.BookName);
                }
            }
            Console.WriteLine("============== Books ordered by Length ==============");
            foreach (var b in bookLength)
            {
                Console.WriteLine("Pages: {0}  |  Book Title: {1}", b.Pages, b.BookName);
            }
            Console.WriteLine("============== Books that start with 'The' ==============");
            foreach (var a in bookTitle)
            {
                Console.WriteLine("Book title: {0}  |  Pages: {1}  |  Author: {2}", a.BookName, a.Pages, a.Author);
            }
        }
    }
}
