using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg2
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
    }
}
