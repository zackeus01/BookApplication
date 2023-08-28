namespace FinalProject_BookApplication.Forms
{
    partial class MyBookDetail
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
            pnlDesktop = new Panel();
            pnlFlowLayout = new Panel();
            linkDeleteBook = new LinkLabel();
            panel1 = new Panel();
            linkEditBook = new LinkLabel();
            pictureBox1 = new PictureBox();
            pnlButtons = new Panel();
            btnDelete = new Button();
            btnRead = new Button();
            btnEdit = new Button();
            btnReturn = new Button();
            btnAddChapter = new Button();
            dgChapter = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ChapterNumber = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            UpdatedDate = new DataGridViewTextBoxColumn();
            Bookmark = new DataGridViewCheckBoxColumn();
            bookItem = new listItem();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgChapter).BeginInit();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(0, 1);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 4;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.Controls.Add(linkDeleteBook);
            pnlFlowLayout.Controls.Add(panel1);
            pnlFlowLayout.Controls.Add(pnlButtons);
            pnlFlowLayout.Controls.Add(dgChapter);
            pnlFlowLayout.Controls.Add(bookItem);
            pnlFlowLayout.Location = new Point(27, 3);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(705, 498);
            pnlFlowLayout.TabIndex = 2;
            // 
            // linkDeleteBook
            // 
            linkDeleteBook.ActiveLinkColor = Color.DarkSlateGray;
            linkDeleteBook.AutoSize = true;
            linkDeleteBook.LinkColor = Color.Brown;
            linkDeleteBook.Location = new Point(613, 150);
            linkDeleteBook.Name = "linkDeleteBook";
            linkDeleteBook.Size = new Size(70, 15);
            linkDeleteBook.TabIndex = 4;
            linkDeleteBook.TabStop = true;
            linkDeleteBook.Text = "Delete Book";
            linkDeleteBook.LinkClicked += linkDeleteBook_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(linkEditBook);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(592, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(107, 116);
            panel1.TabIndex = 3;
            // 
            // linkEditBook
            // 
            linkEditBook.ActiveLinkColor = Color.DarkSlateGray;
            linkEditBook.AutoSize = true;
            linkEditBook.Location = new Point(26, 93);
            linkEditBook.Name = "linkEditBook";
            linkEditBook.Size = new Size(57, 15);
            linkEditBook.TabIndex = 1;
            linkEditBook.TabStop = true;
            linkEditBook.Text = "Edit Book";
            linkEditBook.LinkClicked += linkEditBook_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book_writting_icon;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnRead);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnReturn);
            pnlButtons.Controls.Add(btnAddChapter);
            pnlButtons.Location = new Point(19, 453);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(683, 37);
            pnlButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(400, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.DarkSlateGray;
            btnRead.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(180, 0);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(104, 37);
            btnRead.TabIndex = 4;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkSlateGray;
            btnEdit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(290, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 37);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SteelBlue;
            btnReturn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(0, 0);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(145, 37);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddChapter
            // 
            btnAddChapter.BackColor = Color.Brown;
            btnAddChapter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddChapter.ForeColor = Color.White;
            btnAddChapter.Location = new Point(510, 0);
            btnAddChapter.Name = "btnAddChapter";
            btnAddChapter.Size = new Size(176, 37);
            btnAddChapter.TabIndex = 1;
            btnAddChapter.Text = "Add New Chapter";
            btnAddChapter.UseVisualStyleBackColor = false;
            btnAddChapter.Click += btnAddChapter_Click;
            // 
            // dgChapter
            // 
            dgChapter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChapter.Columns.AddRange(new DataGridViewColumn[] { id, ChapterNumber, Title, CreatedDate, UpdatedDate, Bookmark });
            dgChapter.Location = new Point(19, 202);
            dgChapter.Name = "dgChapter";
            dgChapter.RowHeadersWidth = 51;
            dgChapter.RowTemplate.Height = 25;
            dgChapter.Size = new Size(696, 245);
            dgChapter.TabIndex = 1;
            dgChapter.CellContentClick += dgChapter_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "ChapterID";
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // ChapterNumber
            // 
            ChapterNumber.DataPropertyName = "ChapterNumber";
            ChapterNumber.HeaderText = "Chapter";
            ChapterNumber.Name = "ChapterNumber";
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "Created Date";
            CreatedDate.Name = "CreatedDate";
            // 
            // UpdatedDate
            // 
            UpdatedDate.DataPropertyName = "UpdatedDate";
            UpdatedDate.HeaderText = "Last Update";
            UpdatedDate.Name = "UpdatedDate";
            // 
            // Bookmark
            // 
            Bookmark.DataPropertyName = "Bookmark";
            Bookmark.HeaderText = "Bookmark";
            Bookmark.Name = "Bookmark";
            // 
            // bookItem
            // 
            bookItem.AutoSize = true;
            bookItem.Location = new Point(3, 4);
            bookItem.Name = "bookItem";
            bookItem.PropAuthor = "Jk.Rowling";
            bookItem.PropCover = Properties.Resources.default_book_cover_2015;
            bookItem.PropDateCreated = new DateTime(2023, 7, 21, 19, 3, 41, 0);
            bookItem.PropDateUpdated = new DateTime(2023, 7, 21, 19, 3, 44, 0);
            bookItem.PropDesc = "U re a wizard Harry";
            bookItem.PropTitle = "Harry Potter and The Sorcerer Stone";
            bookItem.Size = new Size(583, 192);
            bookItem.TabIndex = 0;
            // 
            // MyBookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 506);
            Controls.Add(pnlDesktop);
            Name = "MyBookDetail";
            Text = "MyBookDetail";
            Load += MyBookDetail_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            pnlFlowLayout.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgChapter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private Panel panel1;
        private LinkLabel linkEditBook;
        private PictureBox pictureBox1;
        private Panel pnlButtons;
        private Button btnReturn;
        private Button btnAddChapter;
        private DataGridView dgChapter;
        private listItem bookItem;
        private Button btnRead;
        private Button btnEdit;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ChapterNumber;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedDate;
        private DataGridViewCheckBoxColumn Bookmark;
        private Button btnDelete;
        private LinkLabel linkDeleteBook;
    }
}