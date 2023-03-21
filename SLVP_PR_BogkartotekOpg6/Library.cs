using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg6
{
    internal class Library
    {
        // Private properties that are only used inside the Library class.
        private Guid ID { get; set; }
        private List<Book> Books { get; set; }
        private List<Author> Authors { get; set; }
        private List<Publisher> Publishers { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Library()
        {
            // Assigns a new random Guid as ID.
            this.ID = Guid.NewGuid();
            // Instantiating the Lists of Books, Authors and Publishers used in our Library.
            Books = new List<Book>();
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
        }


        /// <summary>
        /// Adds a Book to the List of Books in the library. Also adds the Author to the List of Authors and the Publisher to the List
        /// of Publishers if either is not already there.
        /// </summary>
        /// <param name="book">Book to be added</param>
        public void AddBook(Book book)
        {
            Books.Add(book);

            // If the Author doesn't exist in the List of Authors it is added.
            // Uses a Lambda expression to look for the Author by name in the List of Authors. If the result is null
            // then the Author is not found and therefore we add it.
            if (Authors.Find(Auth => Auth.Name == book.Auth.Name) is null)
            {
                Authors.Add(book.Auth);
            }
            // If the Publisher doesn't exist in the list of Publishers it is added.
            // Uses a Lambda expression to look for the Publisher by name in the list of Publishers. If the result is null
            // then the Publisher is not found and therefore we add it.
            if (Publishers.Find(Pub => Pub.Name == book.Pub.Name) is null)
            {
                Publishers.Add(book.Pub);
            }
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
        /// Finds all Books by Author name.
        /// </summary>
        /// <param name="author">name of Author</param>
        /// <returns>List of all Books by the specified Author</returns>
        public List<Book> FindBooksByAuthor(string author)
        {
            // Lambda expression that evaluates if the Author name of a Book is equal to the Author we are looking for.
            // This is used by the FindAll method of our List of Books to find all matches.
            return Books.FindAll(book => book.Auth.Name == author);
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
        /// Updates the specified Book entry in the List of Books, by first removing the old entry and then adding a new updated entry. Does not
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
        /// Finds all Books by Publisher name.
        /// </summary>
        /// <param name="publisher">name of Publisher</param>
        /// <returns>List of Books by the specified Publisher</returns>
        public List<Book> FindBooksByPublisher(string publisher)
        {
            // Lambda expression that evaluates if the Publisher name of a Book is equal to the Publisher we are looking for.
            // This is used by the FindAll method of our List of Books to find all matches.
            return Books.FindAll(book => book.Pub.Name == publisher);
        }


        /// <summary>
        /// Adds the Author provided as parameter to the List of Authors.
        /// </summary>
        /// <param name="author">Author to be added</param>
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        /// <summary>
        /// Adds the Publisher provided as parameter to the List of Publishers.
        /// </summary>
        /// <param name="publisher">Publisher to be added</param>
        public void AddPublisher(Publisher publisher)
        {
            Publishers.Add(publisher);
        }

        /// <summary>
        /// Gets the List of Authors.
        /// </summary>
        /// <returns>List of all Authors</returns>
        public List<Author> GetAllAuthors()
        {
            return Authors;
        }

        /// <summary>
        /// Gets the List of Publishers.
        /// </summary>
        /// <returns>List of all Publishers</returns>
        public List<Publisher> GetAllPublishers()
        {
            return Publishers;
        }
    }
}