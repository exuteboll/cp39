using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FictionBook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public FictionBook(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public string GetInfo() => $"[Художественная]\nНазвание: {Title}\nАвтор: {Author}\nЖанр: {Genre}";
    }
}
