using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Create instances of new books

            Book catcher = new Book() 
            {
                Title= "Catcher In The Rye",
                Author="J.D. Salinger",
                PublishDate= new DateTime(1951, 7, 16),
                Genre="Young Adult Fiction"
            };
            Book eightyFour = new Book() 
            {
                Title= "Nineteen Eighty-Four",
                Author="George Orwell",
                PublishDate= new DateTime(1949, 6, 8),
                Genre="Dystopian Fiction"
            };
            Book endersGame = new Book() 
            {
                Title= "Ender's Game",
                Author="Orson Scott Card",
                PublishDate= new DateTime(1985, 1, 15),
                Genre="Science Fiction"
            };
            //create a new library
            LibraryManager sarasLibrary = new LibraryManager("Sara's Lovely Library");
            
            //Write welcome message for Library
            Console.WriteLine($"Welcome to {sarasLibrary.Name} Management System!");
            Console.WriteLine();
            Console.WriteLine("Here are the books we have in stock: ");
            Console.WriteLine();
            
            //add books to each library
            sarasLibrary.AddBooks(catcher);
            sarasLibrary.AddBooks(endersGame);
            sarasLibrary.AddBooks(eightyFour);

            //show all books in specific library
            sarasLibrary.ShowBooks();
        }


    }
}
