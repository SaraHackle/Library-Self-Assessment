using System;
using System.Collections.Generic;

namespace Library
{
    public class LibraryManager
    {
        //create a pricate field with a list a books
        private List<Book> _books = new List<Book>();
        
        //name the library
        public string Name {get;}

        //add a Name property to the Library
        public LibraryManager (string name)
        {
            Name= name;
        }

        //method that shows each book in the private field
        public void ShowBooks() 
        {
            foreach (Book book in _books)
            {
            Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        //method that adds books to private field
        public void AddBooks (Book book)
        {
            _books.Add(book);
        }
        
    }
}