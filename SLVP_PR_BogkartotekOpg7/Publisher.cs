using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PR_BogkartotekOpg7
{
    internal class Publisher
    {
        // Public properties that are used in the DataGridView to display data.
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        /// <summary>
        /// Constructor that takes a string name as parameter and generates a random Guid id.
        /// </summary>
        /// <param name="name">name of the Publisher</param>
        public Publisher(string name)
        {
            this.ID = Guid.NewGuid();
            Name = name;
            Books = new List<Book>();
        }


        /// <summary>
        /// Constructor that takes both a Guid id and string name as parameters.
        /// </summary>
        /// <param name="id">Guid of the Publisher</param>
        /// <param name="name">name of the Publisher</param>
        public Publisher(Guid id, string name)
        {
            ID = id;
            Name = name;
            Books = new List<Book>();
        }
    }
}
