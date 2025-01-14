using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Library
    {
        public string Name { get; set; }
        public Book[] Books  { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public Author Author { get; set; }
    public Book(Author author)
    {
        Author = author;
    }
}
    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
