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

namespace SLVP_PR_BogkartotekOpg6
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
            bs.DataSource = new { BookID = "", BookTitle = "", AuthorID = "", AuthorName = "", PublisherID = "", PublisherName = "" };
            dgvBookList.DataSource = bs;
            // Setting the order of columns shown in the DataGridView.
            dgvBookList.Columns["BookID"].DisplayIndex = 0;
            dgvBookList.Columns["BookTitle"].DisplayIndex = 1;
            dgvBookList.Columns["AuthorID"].DisplayIndex = 2;
            dgvBookList.Columns["AuthorName"].DisplayIndex = 3;
            dgvBookList.Columns["PublisherID"].DisplayIndex = 4;
            dgvBookList.Columns["PublisherName"].DisplayIndex = 5;
            // Setting up the columns to use all space in the DataGridView with same size for all.
            for (int i = 0; i < 6; i++)
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
                bs.DataSource = new { BookID = "", BookTitle = "", AuthorID = "", AuthorName = "", PublisherID = "", PublisherName = "" };
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
                               AuthorID = a.Auth.ID,
                               AuthorName = a.Auth.Name,
                               PublisherID = a.Pub.ID,
                               PublisherName = a.Pub.Name
                           };
                bs.DataSource = bind;
            }
            dgvBookList.DataSource = bs;
            // Setting the order of columns shown in the DataGridView.
            dgvBookList.Columns["BookID"].DisplayIndex = 0;
            dgvBookList.Columns["BookTitle"].DisplayIndex = 1;
            dgvBookList.Columns["AuthorID"].DisplayIndex = 2;
            dgvBookList.Columns["AuthorName"].DisplayIndex = 3;
            dgvBookList.Columns["PublisherID"].DisplayIndex = 4;
            dgvBookList.Columns["PublisherName"].DisplayIndex = 5;
            // Setting up the columns to use all space in the DataGridView with same size for all.           
            for (int i = 0; i < 6; i++)
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
                bs.DataSource = new { BookID = "", BookTitle = "", AuthorID = "", AuthorName = "", PublisherID = "", PublisherName = "" };
                MessageBox.Show("That book doesn't exist.");
            }
            else
            {
                // Setting up the object with headers and values for a single Book as DataSource.
                bs.DataSource = new { BookID = toBind.ID, BookTitle = toBind.Title, AuthorID = toBind.Auth.ID, AuthorName = toBind.Auth.Name, PublisherID = toBind.Pub.ID, PublisherName = toBind.Pub.Name };
            }
            dgvBookList.DataSource = bs;
            // Setting the order of columns shown in the DataGridView.
            dgvBookList.Columns["BookID"].DisplayIndex = 0;
            dgvBookList.Columns["BookTitle"].DisplayIndex = 1;
            dgvBookList.Columns["AuthorID"].DisplayIndex = 2;
            dgvBookList.Columns["AuthorName"].DisplayIndex = 3;
            dgvBookList.Columns["PublisherID"].DisplayIndex = 4;
            dgvBookList.Columns["PublisherName"].DisplayIndex = 5;
            // Setting up the columns to use all space in the DataGridView with same size for all.               
            for (int i = 0; i < 6; i++)
            {
                dgvBookList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Overloaded method.
        /// Setting up the Author List provided as parameter as a DataSource for the DataGridView. Informs the user with a MessageBox
        /// if the Author doesn't exist and the DataGridView will then show empty cells.
        /// </summary>
        /// <param name="toBind">List of Authors to be shown in the DataGridView</param>
        private void dgvUpdate(List<Author> toBind)
        {
            BindingSource bs = new BindingSource();
            // If the List is empty then no Authors exist in that List.
            if (toBind.Count == 0)
            {
                bs.DataSource = new { AuthorID = "", AuthorName = "" };
                MessageBox.Show("No authors found.");
            }
            else
            {
                // Using a query to setup the DataSource.
                var bind = from a in toBind
                           select new
                           {
                               AuthorID = a.ID,
                               AuthorName = a.Name
                           };

                bs.DataSource = bind;
            }
            dgvBookList.DataSource = bs;
            // Setting up the columns to use all space in the DataGridView with same size for all.
            dgvBookList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBookList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Overloaded method.
        /// Setting up the Publisher List provided as parameter as a DataSource for the DataGridView. Informs the user with a MessageBox
        /// if the Publisher doesn't exist and the DataGridView will then show empty cells.
        /// </summary>
        /// <param name="toBind">List of Publishers to be shown in the DataGridView</param>
        private void dgvUpdate(List<Publisher> toBind)
        {
            BindingSource bs = new BindingSource();
            // If the List is empty then no Publishers exist in that List.
            if (toBind.Count == 0)
            {
                bs.DataSource = new { PublisherID = "", PublisherName = "" };
                MessageBox.Show("No publishers found.");
            }
            else
            {
                // Using a query to setup the DataSource.
                var bind = from a in toBind
                           select new
                           {
                               PublisherID = a.ID,
                               PublisherName = a.Name
                           };
                bs.DataSource = bind;
            }
            dgvBookList.DataSource = bs;
            // Setting up the columns to use all space in the DataGridView with same size for all.
            dgvBookList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBookList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Event listener for clicks on the Add book button.
        /// Adds the Book specified by title, Author and Publisher to the List of Books and then 
        /// uses the dgvUpdate method to update the DataGridView. After adding the GetAllAuthors and 
        /// GetAllPublishers methods to the Library class we can now check if they already exist, even if they
        /// have no Books. If they don't exist they will be added to their respective lists. Will reuse the ID of any 
        /// existing Author or Publisher.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {

            // If any input is blank we inform the user to try again with a MessageBox.
            if (tbAddBookTitle.Text == "" || tbAddBookAuthor.Text == "" || tbAddBookPublisher.Text == "")
            {
                MessageBox.Show("Either title, author, publisher or multiple fields are blank. Please provide valid input.");
            }
            else
            {
                // If the Author already exists in our List of Authors then we won't change the Guid. If a new Author is specified
                // then a new Guid is assigned. This is done through the different constructors in the Author class.
                Author auth;
                // Looks through the List of all Authors to see if there's a matching name for the one being added.
                Author tAuthor = lib.GetAllAuthors().Find(a => a.Name == tbAddBookAuthor.Text);
                if (!(tAuthor is null))
                {
                    // Not a new Author so we reuse the ID.
                    auth = new Author(tAuthor.ID, tbAddBookAuthor.Text);
                }
                else
                {
                    auth = new Author(tbAddBookAuthor.Text);
                    // It's a new Author so we add it to the List of Authors.
                    lib.AddAuthor(auth);
                }
                // If the Publisher already exists in our List of Publishers then we won't change the Guid. If a new Publisher is specified
                // then a new Guid is assigned. This is done through the different constructors in the Publisher class.               
                Publisher pub;
                // Looks through the List of all Publishers to see if there's a matching name for the one being added.
                Publisher tPub = lib.GetAllPublishers().Find(p => p.Name == tbAddBookPublisher.Text);
                if (!(tPub is null))
                {
                    // Not a new Publisher so we reuse the ID.
                    pub = new Publisher(tPub.ID, tbAddBookPublisher.Text);
                }
                else
                {
                    pub = new Publisher(tbAddBookPublisher.Text);
                    // It's a new Publisher so we add it to the List of Publishers.
                    lib.AddPublisher(pub);
                }
                Book book = new Book(tbAddBookTitle.Text, auth, pub);
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
        /// textbox as argument to get a List of all Books with that Author. That is then passed to the dgvUpdate method to update the DataGridView.
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
        /// the Book as argument in order to update the Book. If unsuccessful whether the input is invalid or the Guid is not found
        /// the user is informed of this through a MessageBox. If the new Author or Publisher already exists in their respective
        /// Lists then their Guid will be retained.
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
            else if (tbUpdateTitle.Text == "" || tbUpdateAuthor.Text == "" || tbUpdatePublisher.Text == "")
            {
                MessageBox.Show("Either title, author, publisher or multiple fields are blank. Please provide valid input.");
            }
            else
            {
                // If the Author already exists in our List of Authors then we won't change the Guid. If a new Author is specified
                // a new Guid is assigned for it.
                Author auth;
                Author tAuthor = lib.GetAllAuthors().Find(a => a.Name == tbUpdateAuthor.Text);
                if (!(tAuthor is null))
                {
                    // Not a new Author so we reuse the ID.
                    auth = new Author(tAuthor.ID, tbUpdateAuthor.Text);
                }
                else
                {
                    auth = new Author(tbUpdateAuthor.Text);
                    // It's a new Author so we add it to the List of Authors.
                    lib.AddAuthor(auth);
                }
                Publisher pub;
                Publisher tPub = lib.GetAllPublishers().Find(p => p.Name == tbUpdatePublisher.Text);
                // If the Publisher already exists in our List of Publishers then we won't change the Guid. If a new Publisher is specified
                // a new Guid is assigned for it.
                if (!(tPub is null))
                {
                    // Not a new Publisher so we reuse the ID.
                    pub = new Publisher(tPub.ID, tbUpdatePublisher.Text);
                }
                else
                {
                    pub = new Publisher(tbUpdatePublisher.Text);
                    // It's a new Publisher so we add it to the List of Publishers.
                    lib.AddPublisher(pub);
                }
                if (lib.UpdateBook(new Book(tempID, tbUpdateTitle.Text, auth, pub)))
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

        /// <summary>
        /// Event listener for clicks on the Find by publisher button. Checks if any input is given. If not it displays a MessageBox
        /// with an error. Otherwise it uses the FindBooksByPublisher method from the Library class with the input from the 
        /// tbFindByPublisher textbox as argument to get a List of all Books with that Publisher. That is then passed to the dgvUpdate 
        /// method to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindByPublisher_Click(object sender, EventArgs e)
        {
            if (tbFindByPublisher.Text == "")
            {
                MessageBox.Show("Please provide some input and try again.");
            }
            else
            {
                dgvUpdate(lib.FindBooksByPublisher(tbFindByPublisher.Text));
            }
        }

        /// <summary>
        /// Event listener for clicks on the Add author button. Checks if any input is given. If not it displays a MessageBox with
        /// an error. Otherwise it uses the GetAllAuthors method from the Library class to get a List of all Authors, then checks 
        /// if the Author exists in that List. If the Author already exists a MessageBox will be displayed with an error. 
        /// Otherwise the Author is added to the List of Authors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (tbAddAuthor.Text == "")
            {
                MessageBox.Show("Please provide some input and try again.");
            }
            else
            {
                List<Author> tempAuthorList = lib.GetAllAuthors();
                // Checking if the Author already exists by using a Lambda expression with the Find method of the List of all
                // Authors. If the result is null then nothing was found and thus the Author doesn't already exist.
                if (tempAuthorList.Find(a => a.Name == tbAddAuthor.Text) is null)
                {
                    lib.AddAuthor(new Author(tbAddAuthor.Text));
                }
                else
                {
                    MessageBox.Show("Author already exists and won't be added.");
                }
            }
        }

        /// <summary>
        /// Event listener for clicks on the Add publisher button. Checks if any input is given. If not it displays a MessageBox with
        /// an error. Otherwise it uses the GetAllPublishers method from the Library class to get a List of all Publishers, then checks 
        /// if the Publisher exists in that List. If the Publisher already exists a MessageBox will be displayed with an error. 
        /// Otherwise the Publisher is added to the List of Publisher.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            if (tbAddPublisher.Text == "")
            {
                MessageBox.Show("Please provide some input and try again.");
            }
            else
            {
                List<Publisher> tempPublisherList = lib.GetAllPublishers();
                // Checking if the Publisher already exists by using a Lambda expression with the Find method of the List of all
                // Publishers. If the result is null then nothing was found and thus the Publisher doesn't already exist.
                if (tempPublisherList.Find(p => p.Name == tbAddPublisher.Text) is null)
                {
                    lib.AddPublisher(new Publisher(tbAddPublisher.Text));
                }
                else
                {
                    MessageBox.Show("Publisher already exists and won't be added.");
                }
            }
        }

        /// <summary>
        /// Event listener for clicks on the Show authors button. Uses the GetAllAuthors method of the Library class
        /// to get a List of all Authors and then calls dgvUpdate with that List to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAuthors_Click(object sender, EventArgs e)
        {
            dgvUpdate(lib.GetAllAuthors());
        }

        /// <summary>
        /// Event listener for clicks on the Show publishers button. Uses the GetAllPublishers method of the Library class
        /// to get a List of all Publishers and then calls dgvUpdate with that List to update the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowPublishers_Click(object sender, EventArgs e)
        {
            dgvUpdate(lib.GetAllPublishers());
        }
    }
}
