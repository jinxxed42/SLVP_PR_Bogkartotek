using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg1
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
    }
}
