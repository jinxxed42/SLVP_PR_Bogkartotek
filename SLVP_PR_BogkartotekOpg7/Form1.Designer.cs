namespace SLVP_PR_BogkartotekOpg7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.tbAddBookTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tbAddBookAuthor = new System.Windows.Forms.TextBox();
            this.tbFindByTitle = new System.Windows.Forms.TextBox();
            this.btnFindByTitle = new System.Windows.Forms.Button();
            this.tbFindByAuthor = new System.Windows.Forms.TextBox();
            this.btnFindByAuthor = new System.Windows.Forms.Button();
            this.tbUpdateID = new System.Windows.Forms.TextBox();
            this.tbUpdateTitle = new System.Windows.Forms.TextBox();
            this.tbUpdateAuthor = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbRemoveByID = new System.Windows.Forms.TextBox();
            this.btnRemoveByID = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.tbAddBookPublisher = new System.Windows.Forms.TextBox();
            this.tbFindByPublisher = new System.Windows.Forms.TextBox();
            this.btnFindByPublisher = new System.Windows.Forms.Button();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.tbAddPublisher = new System.Windows.Forms.TextBox();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.tbUpdatePublisher = new System.Windows.Forms.TextBox();
            this.btnShowAuthors = new System.Windows.Forms.Button();
            this.btnShowPublishers = new System.Windows.Forms.Button();
            this.tbBooksByAuthor = new System.Windows.Forms.TextBox();
            this.btnBooksByAuthor = new System.Windows.Forms.Button();
            this.tbBooksByPublisher = new System.Windows.Forms.TextBox();
            this.btnBooksByPublisher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(77, 63);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.Size = new System.Drawing.Size(1011, 150);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.TabStop = false;
            // 
            // tbAddBookTitle
            // 
            this.tbAddBookTitle.Location = new System.Drawing.Point(77, 281);
            this.tbAddBookTitle.Name = "tbAddBookTitle";
            this.tbAddBookTitle.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookTitle.TabIndex = 1;
            this.tbAddBookTitle.Text = "Title";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(77, 359);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tbAddBookAuthor
            // 
            this.tbAddBookAuthor.Location = new System.Drawing.Point(77, 307);
            this.tbAddBookAuthor.Name = "tbAddBookAuthor";
            this.tbAddBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookAuthor.TabIndex = 2;
            this.tbAddBookAuthor.Text = "Author";
            // 
            // tbFindByTitle
            // 
            this.tbFindByTitle.Location = new System.Drawing.Point(183, 333);
            this.tbFindByTitle.Name = "tbFindByTitle";
            this.tbFindByTitle.Size = new System.Drawing.Size(100, 20);
            this.tbFindByTitle.TabIndex = 5;
            // 
            // btnFindByTitle
            // 
            this.btnFindByTitle.Location = new System.Drawing.Point(183, 358);
            this.btnFindByTitle.Name = "btnFindByTitle";
            this.btnFindByTitle.Size = new System.Drawing.Size(100, 23);
            this.btnFindByTitle.TabIndex = 6;
            this.btnFindByTitle.Text = "Find by title";
            this.btnFindByTitle.UseVisualStyleBackColor = true;
            this.btnFindByTitle.Click += new System.EventHandler(this.btnFindByTitle_Click);
            // 
            // tbFindByAuthor
            // 
            this.tbFindByAuthor.Location = new System.Drawing.Point(289, 333);
            this.tbFindByAuthor.Name = "tbFindByAuthor";
            this.tbFindByAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbFindByAuthor.TabIndex = 7;
            // 
            // btnFindByAuthor
            // 
            this.btnFindByAuthor.Location = new System.Drawing.Point(289, 359);
            this.btnFindByAuthor.Name = "btnFindByAuthor";
            this.btnFindByAuthor.Size = new System.Drawing.Size(100, 23);
            this.btnFindByAuthor.TabIndex = 8;
            this.btnFindByAuthor.Text = "Find by author";
            this.btnFindByAuthor.UseVisualStyleBackColor = true;
            this.btnFindByAuthor.Click += new System.EventHandler(this.btnFindByAuthor_Click);
            // 
            // tbUpdateID
            // 
            this.tbUpdateID.Location = new System.Drawing.Point(501, 256);
            this.tbUpdateID.Name = "tbUpdateID";
            this.tbUpdateID.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateID.TabIndex = 11;
            this.tbUpdateID.Text = "Input ID of book";
            // 
            // tbUpdateTitle
            // 
            this.tbUpdateTitle.Location = new System.Drawing.Point(501, 282);
            this.tbUpdateTitle.Name = "tbUpdateTitle";
            this.tbUpdateTitle.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateTitle.TabIndex = 12;
            this.tbUpdateTitle.Text = "New title";
            // 
            // tbUpdateAuthor
            // 
            this.tbUpdateAuthor.Location = new System.Drawing.Point(501, 308);
            this.tbUpdateAuthor.Name = "tbUpdateAuthor";
            this.tbUpdateAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateAuthor.TabIndex = 13;
            this.tbUpdateAuthor.Text = "New author";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbRemoveByID
            // 
            this.tbRemoveByID.Location = new System.Drawing.Point(395, 333);
            this.tbRemoveByID.Name = "tbRemoveByID";
            this.tbRemoveByID.Size = new System.Drawing.Size(100, 20);
            this.tbRemoveByID.TabIndex = 9;
            // 
            // btnRemoveByID
            // 
            this.btnRemoveByID.Location = new System.Drawing.Point(395, 359);
            this.btnRemoveByID.Name = "btnRemoveByID";
            this.btnRemoveByID.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveByID.TabIndex = 10;
            this.btnRemoveByID.Text = "Remove by ID";
            this.btnRemoveByID.UseVisualStyleBackColor = true;
            this.btnRemoveByID.Click += new System.EventHandler(this.btnRemoveByID_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.Location = new System.Drawing.Point(501, 415);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(100, 23);
            this.btnShowAllBooks.TabIndex = 26;
            this.btnShowAllBooks.Text = "Show all books";
            this.btnShowAllBooks.UseVisualStyleBackColor = true;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // tbAddBookPublisher
            // 
            this.tbAddBookPublisher.Location = new System.Drawing.Point(77, 334);
            this.tbAddBookPublisher.Name = "tbAddBookPublisher";
            this.tbAddBookPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookPublisher.TabIndex = 3;
            this.tbAddBookPublisher.Text = "Publisher";
            // 
            // tbFindByPublisher
            // 
            this.tbFindByPublisher.Location = new System.Drawing.Point(608, 333);
            this.tbFindByPublisher.Name = "tbFindByPublisher";
            this.tbFindByPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbFindByPublisher.TabIndex = 16;
            // 
            // btnFindByPublisher
            // 
            this.btnFindByPublisher.Location = new System.Drawing.Point(608, 358);
            this.btnFindByPublisher.Name = "btnFindByPublisher";
            this.btnFindByPublisher.Size = new System.Drawing.Size(100, 23);
            this.btnFindByPublisher.TabIndex = 17;
            this.btnFindByPublisher.Text = "Find by publisher";
            this.btnFindByPublisher.UseVisualStyleBackColor = true;
            this.btnFindByPublisher.Click += new System.EventHandler(this.btnFindByPublisher_Click);
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Location = new System.Drawing.Point(714, 333);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAddAuthor.TabIndex = 18;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(714, 358);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(100, 23);
            this.btnAddAuthor.TabIndex = 19;
            this.btnAddAuthor.Text = "Add author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // tbAddPublisher
            // 
            this.tbAddPublisher.Location = new System.Drawing.Point(820, 333);
            this.tbAddPublisher.Name = "tbAddPublisher";
            this.tbAddPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbAddPublisher.TabIndex = 20;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(820, 358);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(100, 23);
            this.btnAddPublisher.TabIndex = 21;
            this.btnAddPublisher.Text = "Add publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // tbUpdatePublisher
            // 
            this.tbUpdatePublisher.Location = new System.Drawing.Point(501, 334);
            this.tbUpdatePublisher.Name = "tbUpdatePublisher";
            this.tbUpdatePublisher.Size = new System.Drawing.Size(100, 20);
            this.tbUpdatePublisher.TabIndex = 14;
            this.tbUpdatePublisher.Text = "New publisher";
            // 
            // btnShowAuthors
            // 
            this.btnShowAuthors.Location = new System.Drawing.Point(714, 414);
            this.btnShowAuthors.Name = "btnShowAuthors";
            this.btnShowAuthors.Size = new System.Drawing.Size(100, 23);
            this.btnShowAuthors.TabIndex = 27;
            this.btnShowAuthors.Text = "Show authors";
            this.btnShowAuthors.UseVisualStyleBackColor = true;
            this.btnShowAuthors.Click += new System.EventHandler(this.btnShowAuthors_Click);
            // 
            // btnShowPublishers
            // 
            this.btnShowPublishers.Location = new System.Drawing.Point(820, 414);
            this.btnShowPublishers.Name = "btnShowPublishers";
            this.btnShowPublishers.Size = new System.Drawing.Size(100, 23);
            this.btnShowPublishers.TabIndex = 28;
            this.btnShowPublishers.Text = "Show publishers";
            this.btnShowPublishers.UseVisualStyleBackColor = true;
            this.btnShowPublishers.Click += new System.EventHandler(this.btnShowPublishers_Click);
            // 
            // tbBooksByAuthor
            // 
            this.tbBooksByAuthor.Location = new System.Drawing.Point(926, 333);
            this.tbBooksByAuthor.Name = "tbBooksByAuthor";
            this.tbBooksByAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbBooksByAuthor.TabIndex = 22;
            // 
            // btnBooksByAuthor
            // 
            this.btnBooksByAuthor.Location = new System.Drawing.Point(926, 358);
            this.btnBooksByAuthor.Name = "btnBooksByAuthor";
            this.btnBooksByAuthor.Size = new System.Drawing.Size(100, 23);
            this.btnBooksByAuthor.TabIndex = 23;
            this.btnBooksByAuthor.Text = "Books by author";
            this.btnBooksByAuthor.UseVisualStyleBackColor = true;
            this.btnBooksByAuthor.Click += new System.EventHandler(this.btnBooksByAuthor_Click);
            // 
            // tbBooksByPublisher
            // 
            this.tbBooksByPublisher.Location = new System.Drawing.Point(1032, 333);
            this.tbBooksByPublisher.Name = "tbBooksByPublisher";
            this.tbBooksByPublisher.Size = new System.Drawing.Size(107, 20);
            this.tbBooksByPublisher.TabIndex = 24;
            // 
            // btnBooksByPublisher
            // 
            this.btnBooksByPublisher.Location = new System.Drawing.Point(1032, 358);
            this.btnBooksByPublisher.Name = "btnBooksByPublisher";
            this.btnBooksByPublisher.Size = new System.Drawing.Size(107, 23);
            this.btnBooksByPublisher.TabIndex = 25;
            this.btnBooksByPublisher.Text = "Books by publisher";
            this.btnBooksByPublisher.UseVisualStyleBackColor = true;
            this.btnBooksByPublisher.Click += new System.EventHandler(this.btnBooksByPublisher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.btnBooksByPublisher);
            this.Controls.Add(this.tbBooksByPublisher);
            this.Controls.Add(this.btnBooksByAuthor);
            this.Controls.Add(this.tbBooksByAuthor);
            this.Controls.Add(this.btnShowPublishers);
            this.Controls.Add(this.btnShowAuthors);
            this.Controls.Add(this.tbUpdatePublisher);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.tbAddPublisher);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.tbAddAuthor);
            this.Controls.Add(this.btnFindByPublisher);
            this.Controls.Add(this.tbFindByPublisher);
            this.Controls.Add(this.tbAddBookPublisher);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnRemoveByID);
            this.Controls.Add(this.tbRemoveByID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbUpdateAuthor);
            this.Controls.Add(this.tbUpdateTitle);
            this.Controls.Add(this.tbUpdateID);
            this.Controls.Add(this.btnFindByAuthor);
            this.Controls.Add(this.tbFindByAuthor);
            this.Controls.Add(this.btnFindByTitle);
            this.Controls.Add(this.tbFindByTitle);
            this.Controls.Add(this.tbAddBookAuthor);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tbAddBookTitle);
            this.Controls.Add(this.dgvBookList);
            this.Name = "Form1";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.TextBox tbAddBookTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbAddBookAuthor;
        private System.Windows.Forms.TextBox tbFindByTitle;
        private System.Windows.Forms.Button btnFindByTitle;
        private System.Windows.Forms.TextBox tbFindByAuthor;
        private System.Windows.Forms.Button btnFindByAuthor;
        private System.Windows.Forms.TextBox tbUpdateID;
        private System.Windows.Forms.TextBox tbUpdateTitle;
        private System.Windows.Forms.TextBox tbUpdateAuthor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbRemoveByID;
        private System.Windows.Forms.Button btnRemoveByID;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.TextBox tbAddBookPublisher;
        private System.Windows.Forms.TextBox tbFindByPublisher;
        private System.Windows.Forms.Button btnFindByPublisher;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox tbAddPublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.TextBox tbUpdatePublisher;
        private System.Windows.Forms.Button btnShowAuthors;
        private System.Windows.Forms.Button btnShowPublishers;
        private System.Windows.Forms.TextBox tbBooksByAuthor;
        private System.Windows.Forms.Button btnBooksByAuthor;
        private System.Windows.Forms.TextBox tbBooksByPublisher;
        private System.Windows.Forms.Button btnBooksByPublisher;
    }
}

