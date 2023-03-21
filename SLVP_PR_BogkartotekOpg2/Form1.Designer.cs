namespace SLVP_PR_BogkartotekOpg2
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
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(77, 63);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.Size = new System.Drawing.Size(621, 150);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.TabStop = false;
            // 
            // tbAddBookTitle
            // 
            this.tbAddBookTitle.Location = new System.Drawing.Point(178, 306);
            this.tbAddBookTitle.Name = "tbAddBookTitle";
            this.tbAddBookTitle.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookTitle.TabIndex = 1;
            this.tbAddBookTitle.Text = "Title";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(178, 359);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tbAddBookAuthor
            // 
            this.tbAddBookAuthor.Location = new System.Drawing.Point(178, 333);
            this.tbAddBookAuthor.Name = "tbAddBookAuthor";
            this.tbAddBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookAuthor.TabIndex = 2;
            this.tbAddBookAuthor.Text = "Author";
            // 
            // tbFindByTitle
            // 
            this.tbFindByTitle.Location = new System.Drawing.Point(315, 332);
            this.tbFindByTitle.Name = "tbFindByTitle";
            this.tbFindByTitle.Size = new System.Drawing.Size(100, 20);
            this.tbFindByTitle.TabIndex = 4;
            // 
            // btnFindByTitle
            // 
            this.btnFindByTitle.Location = new System.Drawing.Point(315, 358);
            this.btnFindByTitle.Name = "btnFindByTitle";
            this.btnFindByTitle.Size = new System.Drawing.Size(100, 23);
            this.btnFindByTitle.TabIndex = 5;
            this.btnFindByTitle.Text = "Find by title";
            this.btnFindByTitle.UseVisualStyleBackColor = true;
            this.btnFindByTitle.Click += new System.EventHandler(this.btnFindByTitle_Click);
            // 
            // tbFindByAuthor
            // 
            this.tbFindByAuthor.Location = new System.Drawing.Point(456, 333);
            this.tbFindByAuthor.Name = "tbFindByAuthor";
            this.tbFindByAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbFindByAuthor.TabIndex = 6;
            // 
            // btnFindByAuthor
            // 
            this.btnFindByAuthor.Location = new System.Drawing.Point(456, 358);
            this.btnFindByAuthor.Name = "btnFindByAuthor";
            this.btnFindByAuthor.Size = new System.Drawing.Size(100, 23);
            this.btnFindByAuthor.TabIndex = 7;
            this.btnFindByAuthor.Text = "Find by author";
            this.btnFindByAuthor.UseVisualStyleBackColor = true;
            this.btnFindByAuthor.Click += new System.EventHandler(this.btnFindByAuthor_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.Location = new System.Drawing.Point(315, 413);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(100, 23);
            this.btnShowAllBooks.TabIndex = 8;
            this.btnShowAllBooks.Text = "Show all books";
            this.btnShowAllBooks.UseVisualStyleBackColor = true;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnFindByAuthor);
            this.Controls.Add(this.tbFindByAuthor);
            this.Controls.Add(this.btnFindByTitle);
            this.Controls.Add(this.tbFindByTitle);
            this.Controls.Add(this.tbAddBookAuthor);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tbAddBookTitle);
            this.Controls.Add(this.dgvBookList);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnShowAllBooks;
    }
}

