using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Libary
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book)
        {
            books.Add(book);
            Console.WriteLine("Книга добавлена.\n");
        }

        public void RemoveBook(string title)
        {
            var book = books.Find(b => b.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Книга удалена.\n");
            }
            else
            {
                Console.WriteLine("Книга не найдена.\n");
            }
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотека пуста.\n");
                return;
            }

            Console.WriteLine("Книги в библиотеке:");
            foreach (var book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
            Console.WriteLine();
        }

    }
}

