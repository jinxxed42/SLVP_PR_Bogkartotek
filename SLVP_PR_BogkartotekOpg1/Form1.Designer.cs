namespace SLVP_PR_BogkartotekOpg1
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
            this.tbAddBookTitle.Location = new System.Drawing.Point(274, 307);
            this.tbAddBookTitle.Name = "tbAddBookTitle";
            this.tbAddBookTitle.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookTitle.TabIndex = 1;
            this.tbAddBookTitle.Text = "Title";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(274, 359);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tbAddBookAuthor
            // 
            this.tbAddBookAuthor.Location = new System.Drawing.Point(274, 333);
            this.tbAddBookAuthor.Name = "tbAddBookAuthor";
            this.tbAddBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAddBookAuthor.TabIndex = 2;
            this.tbAddBookAuthor.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

