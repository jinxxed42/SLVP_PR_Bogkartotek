using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg4
{
    internal class Library
    {
        // Private properties that are only used inside the Library class.
        private Guid ID { get; set; }
        private List<Book> Books { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Library()
        {
            // Assigns a new random Guid as ID.
            this.ID = Guid.NewGuid();
            // Instantiating the List of Books used in the Library.
            Books = new List<Book>();
        }


        /// <summary>
        /// Adds a Book to the List of Books in the Library.
        /// </summary>
        /// <param name="book">Book to be added</param>
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        /// <summary>
        /// Returns the full List of Books in the Library.
        /// </summary>
        /// <returns>List of all Books</returns>
        public List<Book> GetAllBooks()
        {
            return Books;
        }

        /// <summary>
        /// Finds the first Book by title.
        /// </summary>
        /// <param name="title">title of Book</param>
        /// <returns>Book - Can be null which means no matching Book was found.</returns>
        public Book FindBookByTitle(string title)
        {
            // Lambda expression that evaluates if the title of a Book is equal to the title we are looking for.
            // This is used by the Find method of our List of Books to find the first match.
            return Books.Find(book => book.Title == title);
        }

        /// <summary>
        /// Finds all Books by author name.
        /// </summary>
        /// <param name="author">name of author</param>
        /// <returns>List of all Books by the specified author</returns>
        public List<Book> FindBooksByAuthor(string author)
        {
            // Lambda expression that evaluates if the author of a Book is equal to the author we are looking for.
            // This is used by the FindAll method of our List of Books to find all matches.
            return Books.FindAll(book => book.Author == author);
        }

        /// <summary>
        /// Removes the specified Book by Guid from the List of Books.
        /// </summary>
        /// <param name="ID">Guid of Book to be removed</param>
        /// <returns>bool - true if successful, else false</returns>
        public bool RemoveBook(Guid ID)
        {
            // Lambda expression that evaluates if the ID of a Book is equal to the ID we are looking for.
            // This is used by the Find method of our List of Books to find the only match since Guids for Books are unique.
            Book toRemove = Books.Find(book => book.ID == ID);
            return Books.Remove(toRemove);
        }

        /// <summary>
        /// Updates the specified Book entry in the List of books, by first removing the old entry and then adding a new updated entry. Does not
        /// change the Guid of the Book.
        /// </summary>
        /// <param name="book">Book to be updated</param>
        /// <returns>bool - true if successful, else false</returns>
        public bool UpdateBook(Book book)
        {
            // Uses the RemoveBook method which removes the Book by ID from the List of Books and then returns true if successful and false if not.
            // If true is returned it was successful and therefore we add the new and updated Book to the List.
            if (RemoveBook(book.ID))
            {
                AddBook(book);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finds all Books by publisher name.
        /// </summary>
        /// <param name="publisher">name of publisher</param>
        /// <returns>List of Books by the specified publisher</returns>
        public List<Book> FindBooksByPublisher(string publisher)
        {
            // Lambda expression that evaluates if the publisher of a Book is equal to the publisher we are looking for.
            // This is used by the FindAll method of our List of Books to find all matches.
            return Books.FindAll(book => book.Publisher == publisher);
        }

    }
}
