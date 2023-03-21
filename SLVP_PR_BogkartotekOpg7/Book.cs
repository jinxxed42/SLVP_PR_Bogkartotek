using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg7
{
    internal class Book
    {
        // Public properties needed for the DataGridView to display data.
        public Guid ID { get; set; }
        public string Title { get; set; }
        public Author Auth { get; set; }
        public Publisher Pub { get; set; }

        /// <summary>
        /// Constructor that assigns a new random Guid as ID.
        /// </summary>
        /// <param name="title">title of the Book</param>
        /// <param name="auth">Author of the Book</param>
        /// <param name="pub">Publisher of the Book</param>
        public Book(string title, Author auth, Publisher pub)
        {
            // Assigns a new random Guid as ID.
            this.ID = Guid.NewGuid();
            Title = title;
            Auth = auth;
            Pub = pub;
        }

        /// <summary>
        /// Constructor that uses the given Guid as ID.
        /// </summary>
        /// <param name="id">Guid of the Book</param>
        /// <param name="title">title of the Book</param>
        /// <param name="auth">Author of the Book</param>
        /// <param name="pub">Publisher of the Book</param>
        public Book(Guid id, string title, Author auth, Publisher pub)
        {
            ID = id;
            Title = title;
            Auth = auth;
            Pub = pub;
        }
    }
}
