using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLVP_PR_BogkartotekOpg3
{
    public partial class Form1 : Form
    {
        // Creating and instantiating the Library object immediately.
        Library lib = new Library();

        public Form1()
        {
            InitializeComponent();

            // Making sure the DataGridView shows headers and isn't greyed out when the program is loaded.
            BindingSource bs = new BindingSource();
            bs.DataSource = new { BookID = "", BookTitle = "", Author = "" };
            dgvBookList.DataSource = bs;
            // Setting the order of columns shown in the DataGridView.
            dgvBookList.Columns["BookID"].DisplayIndex = 0;
            dgvBookList.Columns["BookTitle"].DisplayIndex = 1;
            dgvBookList.Columns["Author"].DisplayIndex = 2;
            // Setting up the columns to use all space in the DataGridView with same size for all.
            for (int i = 0; i < 3; i++)
            {
                dgvBookList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Overloaded method.
        /// Setting up the List of Books provided as parameter as a DataSource for the DataGridView.
        /// If the List is empty the user is informed through a MessageBox and the DataGridView will show empty cells.
        /// </summary>
        /// <param name="toBind">List of Books to be shown in the DataGridView</param>
        private void dgvUpdate(List<Book> toBind)
        {
            BindingSource bs = new BindingSource();

            // If the List is empty then no Books exist in that List.
            if (toBind.Count == 0)
            {
                // Setting up an empty DataSource for our DataGridView if the List to update the DataGridView is empty.
                // That way we keep our headers instead of the box going blank and grey.
                // This would for instance occur if the last Book in the List is removed.
                bs.DataSource = new { BookID = "", BookTitle = "", Author = "" };
                MessageBox.Show("No books were found to display.");
            }
            else
            {
                // Using a query to setup the DataSource.
                var bind = from a in toBind
                           select new
                           {
                               BookID = a.ID,
                               BookTitle = a.Title,
                               Author = a.Author,
                           };
                bs.DataSource = bind;
            }
            dgvBookList.DataSource = bs;
            // Setting the order of columns shown in the DataGridView.
            dgvBookList.Columns["BookID"].DisplayIndex = 0;
            dgvBookList.Columns["BookTitle"].DisplayIndex = 1;
            dgvBookList.Columns["Author"].DisplayIndex = 2;
            // Setting up the columns to use all space in the DataGridView with same size for all.           
            for (int i = 0; i < 3; i++)
            {
                dgvBookList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Overloaded method.
        /// Setting up the Book provided as parameter as a DataSource for the DataGridView.
        /// Informs the user with a MessageBox if the Book doesn't exist and the DataGridView will then show
        /// empty cells.
        /// </summary>
        /// <param name="toBind">Book to be shown in the DataGridView</param>
        private void dgvUpdate(Book toBind)
        {
            BindingSource bs = new BindingSource();

            // If the Book is null then it doesn't exist.
            if (toBind is null)
            {
                bs.DataSource = new { BookID = "", BookTitle = "", Author = "" };
                MessageBox.Show("That book doesn't exist.");
            }
            else
            {
                // Setting up the object with headers and values for a single Book as DataSource.
                bs.DataSource = new { BookID = toBind.ID, BookTitle = toBind.Title, Author = toBind.Author };
            }
            dgvBookList.DataSource = bs;
            // Setting the order of columns shown in the DataGridView.
            dgvBookList.Columns["BookID"].DisplayIndex = 0;
            dgvBookList.Columns["BookTitle"].DisplayIndex = 1;
            dgvBookList.Columns["Author"].DisplayIndex = 2;
            // Setting up the columns to use all space in the DataGridView with same size for all.               
            for (int i = 0; i < 3; i++)
            {
                dgvBookList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Event listener for clicks on the Add book button.
        /// Adds the Book specified by title and author to the List of Books and then 
        /// uses the dgvUpdate method to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // If any input is blank we inform the user to try again with a MessageBox.
            if (tbAddBookTitle.Text == "" || tbAddBookAuthor.Text == "" )
            {
                MessageBox.Show("Either title, author or both fields are blank. Please provide valid input.");
            }
            else
            {
                Book book = new Book(tbAddBookTitle.Text, tbAddBookAuthor.Text);
                lib.AddBook(book);
                dgvUpdate(lib.GetAllBooks());
            }
        }

        /// <summary>
        /// Event listener for clicks on the Find by title button. Checks if any input is given. If not it displays a MessageBox
        /// with an error. Otherwise it calls the FindBookByTitle method in the Library class with the input in the tbFindByTitle textbox 
        /// as argument. Then calls the dgvUpdate method with the Book returned from FindBookByTitle as argument
        /// in order to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindByTitle_Click(object sender, EventArgs e)
        {
            if (tbFindByTitle.Text == "")
            {
                MessageBox.Show("Please provide some input and try again.");
            }
            else
            {
                dgvUpdate(lib.FindBookByTitle(tbFindByTitle.Text));
            }
        }

        /// <summary>
        /// Event listener for clicks on the Find by author button. Checks if any input is given. If not it displays a MessageBox
        /// with an error. Otherwise it uses the FindBooksByAuthor method from the Library class with the input from the tbFindByAuthor
        /// textbox as argument to get a List of all Books with that author. That is then passed to the dgvUpdate method to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindByAuthor_Click(object sender, EventArgs e)
        {
            if (tbFindByAuthor.Text == "")
            {
                MessageBox.Show("Please provide some input and try again.");
            }
            else
            {
                dgvUpdate(lib.FindBooksByAuthor(tbFindByAuthor.Text));
            }
        }


        /// <summary>
        /// Event listener for clicks on the Remove button. Checks if the provided input is a valid Guid. If so it calls the RemoveBook method of the
        /// Library class. If the input is an invalid Guid or can't be found the user is informed of this through a MessageBox and nothing happens. 
        /// Otherwise the Book is removed and the full List of Books is shown afterwards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveByID_Click(object sender, EventArgs e)
        {
            Guid tempID;
            // Check if the provided Guid is a valid Guid.
            if (!Guid.TryParse(tbRemoveByID.Text, out tempID))
            {
                MessageBox.Show("The input provided is not a valid Guid.");
            }
            else
            {
                // If the Book with the specified Guid is found it is removed and the List of remaining Books shown.
                if (lib.RemoveBook(tempID))
                {
                    dgvUpdate(lib.GetAllBooks());
                }
                // If no Book with the specified Guid is found we inform the user of this.
                else
                {
                    MessageBox.Show("The provided Guid cannot be found.");
                }
            }
        }

        /// <summary>
        /// Event listener for clicks on the Update button.
        /// Checks if the input is valid. If it is then it instantiates a new Book and uses the UpdateBook method in the Library class with
        /// the Book as argument in order to update the book. If unsuccessful whether the input is faulty or the Guid is not found
        /// the user is informed of this through a MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid tempID;
            // Check if the provided Guid is a valid Guid.
            if (!Guid.TryParse(tbUpdateID.Text, out tempID))
            {
                MessageBox.Show("The input provided is not a valid Guid.");
            }
            // If any input is blank we inform the user to try again with a MessageBox.
            else if (tbUpdateTitle.Text == "" || tbUpdateAuthor.Text == "" )
            {
                MessageBox.Show("Either title, author, publisher or multiple fields are blank. Please provide valid input.");
            }
            else
            {
                Book tempBook = new Book(tempID, tbUpdateTitle.Text, tbUpdateAuthor.Text);
                // If the Book with the specified Guid is found it is updated.
                if (lib.UpdateBook(tempBook))
                {
                    // After updating we show all Books.
                    dgvUpdate(lib.GetAllBooks());
                }
                // If no Book with the specified Guid is found we inform the user of this.
                else
                {
                    MessageBox.Show("No book with the specified ID was found. Please try again.");
                }
            }
        }

        /// <summary>
        /// Event listener for clicks on the Show all books button. Uses the GetAllBooks method from the Library class
        /// to get a List of all Books that are then passed to the dgvUpdate method to show the full List in the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            dgvUpdate(lib.GetAllBooks());
        }
    }
}
