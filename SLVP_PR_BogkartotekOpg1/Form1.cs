using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLVP_PR_BogkartotekOpg1
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
                // Using a query to setup the datasource.
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
        /// Event listener for clicks on the Add book button.
        /// Adds the Book specified by title and author to the List of Books and then 
        /// uses the dgvUpdate method to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // If any input is blank we inform the user to try again with a MessageBox.
            if (tbAddBookTitle.Text == "" || tbAddBookAuthor.Text == "")
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
    }
}
