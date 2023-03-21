using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg1
{
    internal class Book
    {
        // Public properties needed for the DataGridView to display data.
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        /// <summary>
        /// Constructor that assigns a new random Guid as ID.
        /// </summary>
        /// <param name="title">title of the Book</param>
        /// <param name="author">author of the Book</param>
        public Book(string title, string author)
        {
            // Assigns a new random Guid as ID.
            this.ID = Guid.NewGuid();
            Title = title;
            Author = author;
        }
    }
}
