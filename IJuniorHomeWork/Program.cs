using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BooksKeeper!");
            BooksKeeper booksKeeper = new BooksKeeper();
            bool isWorking = true;
            
            do
            {
                Console.WriteLine("1. Add book.");
                Console.WriteLine("2. Remove book.");
                Console.WriteLine("3. Show all books.");
                Console.WriteLine("4. Show book by name.");
                Console.WriteLine("5. Show book by author.");
                Console.WriteLine("6. Show book by year published.");
                Console.WriteLine("7. Exit.");
                Console.Write("Choose wisely: ");
                string userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int menuItem))
                {
                    switch (menuItem)
                    {
                        case 1:
                            booksKeeper.AddBook();
                            break;

                        case 2:
                            booksKeeper.RemoveBook();
                            break;

                        case 3:
                            booksKeeper.ShowAllBooksToConsole();
                            break;

                        case 4:
                            booksKeeper.ShowBookByName();
                            break;

                        case 5:
                            booksKeeper.ShowBookByAuthor();
                            break;

                        case 6:
                            booksKeeper.ShowBookByYearPublished();
                            break;

                        case 7:
                            isWorking = false;
                            break;

                        default:
                            Console.WriteLine("There is no such item in menu. Choose wisely)))");
                            break;
                    }
                }
                else
                    Console.WriteLine("Wrong input");
            } while (isWorking);
        }
    }

    internal class BooksKeeper
    {
        private List<Book> _books = new List<Book>();
        public BooksKeeper()
        {
            _books.Add(new Book("Alice's Adventures in Wonderland", "Lewis Carroll", 1865));
            _books.Add(new Book("Robinson Crusoe", "Daniel Defoe", 1719));
            _books.Add(new Book("The Adventures of Tom Sawyer", "Mark Twain", 1876));
        }

        internal void AddBook()
        {
            Console.Write("Enter new book name: ");
            string newBookName = Console.ReadLine();
            Console.Write("Enter new book author: ");
            string newBookAuthor = Console.ReadLine();
            Console.Write("Enter new book year published: ");
            if (Int32.TryParse(Console.ReadLine(), out int newBookYearPublished))
                _books.Add(new Book(newBookName, newBookAuthor, newBookYearPublished));
            else
                Console.WriteLine("Wrong input, enter year published.");
        }

        internal void ShowAllBooksToConsole()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"Name: {book.Name}, Author: {book.Author}, Year published: {book.YearPublished}");
            }
        }

        internal void RemoveBook()
        {
            Console.Write("Enter book name to delete: ");
            string bookNameToDelete = Console.ReadLine();

            bool HadDelete = false;
            foreach (var book in _books)
            {
                if (book.Name == bookNameToDelete)
                {
                    _books.Remove(book);
                    HadDelete = true;
                    break;
                }
            }

            if (HadDelete)
                Console.WriteLine("Book has been deleted.");
        }

        internal void ShowBookByName()
        {   
            Console.Write("Enter book name to find: ");
            string bookNameToFind = Console.ReadLine();

            bool isFound = false;
            foreach (var book in _books)
            {
                if (book.Name == bookNameToFind)
                {
                    Console.WriteLine(book);
                    isFound = true;
                }
            }

            if (!isFound)
                Console.WriteLine("There are no such book.");
        }

        internal void ShowBookByAuthor()
        {
            Console.Write("Enter book author to find: ");
            string bookAuthorToFind = Console.ReadLine();

            bool isFound = false;
            foreach (var book in _books)
            {
                if (book.Author == bookAuthorToFind)
                {
                    Console.WriteLine(book);
                    isFound = true;
                }
            }

            if (!isFound)
                Console.WriteLine("There are no such book.");
        }

        internal void ShowBookByYearPublished()
        {
            Console.Write("Enter book name to find: ");
            int bookYearPublishedToFind;
            while (!Int32.TryParse(Console.ReadLine(), out bookYearPublishedToFind))
            {
                Console.WriteLine("Must be a number. Try againe.");
            }

            bool isFound = false;
            foreach (var book in _books)
            {
                if (book.YearPublished == bookYearPublishedToFind)
                {
                    Console.WriteLine(book);
                    isFound = true;
                }
            }

            if (!isFound)
                Console.WriteLine("There are no such book.");
        }
    }

    internal class Book
    {
        public string Name { get; }
        public string Author { get; }
        public int YearPublished { get; }

        public Book(string name, string author, int yearPublished)
        {
            Name = name;
            Author = author;
            YearPublished = yearPublished;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Author: {Author}, Year published: {YearPublished}";
        }
    }
}
