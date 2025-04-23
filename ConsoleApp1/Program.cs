using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Libary library = new Libary();
            bool running = true;

            while (running)
            {
                Console.WriteLine("===== МЕНЮ БИБЛИОТЕКИ =====");
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Удалить книгу");
                Console.WriteLine("3. Показать все книги");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Выберите тип книги:");
                        Console.WriteLine("1 - Художественная");
                        Console.WriteLine("2 - Научная");
                        Console.WriteLine("3 - Учебник");
                        Console.Write("Тип: ");
                        string type = Console.ReadLine();

                        Console.Write("Введите название: ");
                        string title = Console.ReadLine();
                        Console.Write("Введите автора: ");
                        string author = Console.ReadLine();

                        IBook newBook = null;
                        if (type == "1")
                        {
                            Console.Write("Введите жанр: ");
                            string genre = Console.ReadLine();
                            newBook = new FictionBook(title, author, genre);
                        }
                        else if (type == "2")
                        {
                            Console.Write("Введите тему: ");
                            string topic = Console.ReadLine();
                            newBook = new NonFictionBook(title, author, topic);
                        }
                        else if (type == "3")
                        {
                            Console.Write("Введите предмет: ");
                            string subject = Console.ReadLine();
                            newBook = new TextBook(title, author, subject);
                        }

                        if (newBook != null)
                            library.AddBook(newBook);
                        else
                            Console.WriteLine("Неверный выбор типа книги.\n");
                        break;

                    case "2":
                        Console.Write("Введите название книги для удаления: ");
                        string removeTitle = Console.ReadLine();
                        library.RemoveBook(removeTitle);
                        break;

                    case "3":
                        library.DisplayBooks();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Выход из программы...");
                        break;

                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.\n");
                        break;
                }
            }
        }
    }    
}
