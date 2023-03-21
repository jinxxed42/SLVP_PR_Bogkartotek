﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg4
{
    internal class Book
    {
        // Public properties needed for the DataGridView to display data.
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        /// <summary>
        /// Constructor that assigns a new random Guid as ID.
        /// </summary>
        /// <param name="title">title of the Book</param>
        /// <param name="author">author of the Book</param>
        /// <param name="publisher">publisher of the Book</param>
        public Book(string title, string author, string publisher)
        {
            // Assigns a new random Guid as ID.
            this.ID = Guid.NewGuid();
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        /// <summary>
        /// Constructor that uses the given Guid as ID.
        /// </summary>
        /// <param name="id">Guid of the Book</param>
        /// <param name="title">title of the Book</param>
        /// <param name="author">author of the Book</param>
        /// <param name="publisher">publisher of the Book</param>
        public Book(Guid id, string title, string author, string publisher)
        {
            ID = id;
            Title = title;
            Author = author;
            Publisher = publisher;
        }
    }
}
