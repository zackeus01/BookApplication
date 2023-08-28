namespace FinalProject_BookApplication.Forms
{
    partial class MyBookmarkForm
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
            label1 = new Label();
            pnlButtons = new Panel();
            btnSelectChapter = new Button();
            dgBookmark = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ChapterNumber = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            UpdatedDate = new DataGridViewTextBoxColumn();
            Bookmark = new DataGridViewCheckBoxColumn();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBookmark).BeginInit();
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
            pnlFlowLayout.Controls.Add(label1);
            pnlFlowLayout.Controls.Add(pnlButtons);
            pnlFlowLayout.Controls.Add(dgBookmark);
            pnlFlowLayout.Location = new Point(27, 12);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(705, 489);
            pnlFlowLayout.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(237, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 33);
            label1.TabIndex = 3;
            label1.Text = "My Bookmarks";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSelectChapter);
            pnlButtons.Location = new Point(0, 449);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(702, 37);
            pnlButtons.TabIndex = 2;
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
            // dgBookmark
            // 
            dgBookmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBookmark.Columns.AddRange(new DataGridViewColumn[] { id, ChapterNumber, Title, CreatedDate, UpdatedDate, Bookmark });
            dgBookmark.Location = new Point(3, 45);
            dgBookmark.Name = "dgBookmark";
            dgBookmark.RowHeadersWidth = 51;
            dgBookmark.RowTemplate.Height = 25;
            dgBookmark.Size = new Size(696, 398);
            dgBookmark.TabIndex = 1;
            dgBookmark.CellContentClick += dgBookmark_CellContentClick;
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
            // MyBookmarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 507);
            Controls.Add(pnlDesktop);
            Name = "MyBookmarkForm";
            Text = "MyBookmarkForm";
            Load += MyBookMarkForm_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            pnlFlowLayout.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgBookmark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private DataGridView dgChapter;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ChapterNumber;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedDate;
        private DataGridViewCheckBoxColumn Bookmark;
        private Label label1;
        private Panel pnlButtons;
        private Button btnSelectChapter;
        private DataGridView dgBookmark;
    }
}