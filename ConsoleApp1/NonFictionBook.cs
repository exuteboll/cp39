using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NonFictionBook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public string Topic { get; }
        public NonFictionBook(string title, string author, string topic)
        {
            Title = title;
            Author = author;
            Topic = topic;
        }
        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public string GetInfo() => $"[Научная книга]\nНазвание: {Title}\nАвтор: {Author}\nТема: {Topic}";

    }
}
