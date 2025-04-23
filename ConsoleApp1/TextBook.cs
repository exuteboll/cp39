using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TextBook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public string Subject { get; }

        public TextBook(string title, string author, string subject)
        {
            Title = title;
            Author = author;
            Subject = subject;
        }

        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public string GetInfo() => $"[Учебник]\nНазвание: {Title}\nАвтор: {Author}\nПредмет: {Subject}";

    }
}
