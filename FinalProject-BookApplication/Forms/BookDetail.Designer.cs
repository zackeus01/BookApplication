namespace FinalProject_BookApplication.Forms
{
    partial class BookDetail
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
            pnlButtons = new Panel();
            btnReturn = new Button();
            btnSelectChapter = new Button();
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
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgChapter).BeginInit();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(-2, 0);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 3;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.Controls.Add(pnlButtons);
            pnlFlowLayout.Controls.Add(dgChapter);
            pnlFlowLayout.Controls.Add(bookItem);
            pnlFlowLayout.Location = new Point(27, 12);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(705, 489);
            pnlFlowLayout.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnReturn);
            pnlButtons.Controls.Add(btnSelectChapter);
            pnlButtons.Location = new Point(0, 449);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(702, 37);
            pnlButtons.TabIndex = 2;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SteelBlue;
            btnReturn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(0, 0);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(336, 37);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSelectChapter
            // 
            btnSelectChapter.BackColor = Color.DarkSlateGray;
            btnSelectChapter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectChapter.ForeColor = Color.White;
            btnSelectChapter.Location = new Point(360, 0);
            btnSelectChapter.Name = "btnSelectChapter";
            btnSelectChapter.Size = new Size(342, 37);
            btnSelectChapter.TabIndex = 1;
            btnSelectChapter.Text = "Read Selected Chapter";
            btnSelectChapter.UseVisualStyleBackColor = false;
            btnSelectChapter.Click += btnSelectChapter_Click;
            // 
            // dgChapter
            // 
            dgChapter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChapter.Columns.AddRange(new DataGridViewColumn[] { id, ChapterNumber, Title, CreatedDate, UpdatedDate, Bookmark });
            dgChapter.Location = new Point(3, 198);
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
            bookItem.Location = new Point(0, 0);
            bookItem.Name = "bookItem";
            bookItem.PropAuthor = "Jk.Rowling";
            bookItem.PropCover = Properties.Resources.default_book_cover_2015;
            bookItem.PropDateCreated = new DateTime(2023, 7, 21, 19, 3, 41, 0);
            bookItem.PropDateUpdated = new DateTime(2023, 7, 21, 19, 3, 44, 0);
            bookItem.PropDesc = "U re a wizard Harry";
            bookItem.PropTitle = "Harry Potter and The Sorcerer Stone";
            bookItem.Size = new Size(684, 192);
            bookItem.TabIndex = 0;
            // 
            // BookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 503);
            Controls.Add(pnlDesktop);
            Name = "BookDetail";
            Text = "BookDetail";
            Load += BookDetail_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            pnlFlowLayout.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgChapter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private Panel pnlButtons;
        private Button btnReturn;
        private Button btnSelectChapter;
        private DataGridView dgChapter;
        private listItem listItem1;
        private listItem bookItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ChapterNumber;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedDate;
        private DataGridViewCheckBoxColumn Bookmark;
    }
}