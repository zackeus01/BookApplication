using BookApplication_FinalProject_Giang;
using FinalProject_BookApplication.Additional;
using FinalProject_BookApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_BookApplication.Forms
{
    public partial class MyBookDetail : Form
    {
        public static int sBookId;
        BookAppDBContext context = new BookAppDBContext();

        public MyBookDetail()
        {
            InitializeComponent();
        }

        public MyBookDetail(int id)
        {
            InitializeComponent();
            sBookId = id;
        }

        private void MyBookDetail_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            loadBookItem();
            loadChapter();
        }

        private void loadBookItem()
        {
            imageURL url = new imageURL();
            Book bookToRead = context.Books.SingleOrDefault(x => x.BookId == sBookId);
            var authorID = bookToRead.Author;
            User author = context.Users.SingleOrDefault(x => x.Uid == authorID);
            string fullname = "Unknown Author";
            if (author != null)
            {
                fullname = author.Firstname + " " + author.Lastname;
            }
            bookItem.PropTitle = bookToRead.Title;
            bookItem.PropAuthor = fullname;
            bookItem.PropDateCreated = DateTime.Now;
            bookItem.PropDateUpdated = DateTime.Now;
            bookItem.PropDesc = bookToRead.Description;
            if (bookToRead.Cover != null)
            {
                bookItem.PropCover = Image.FromFile(bookToRead.Cover);
            }
            else
            {
                bookItem.PropCover = Image.FromFile("\"D:\\Zack\\FPTU\\Courses\\SEM_5\\PRN211\\Giang-FinalProject\\FinalProject-BookApplication\\FinalProject-BookApplication\\Resources\\default_book_cover_2015.jpg\"");
            }

        }

        private void loadChapter()
        {
            var data = context.Chapters.Where(item => item.BookId == sBookId).Select(item => new
            {
                ChapterID = item.ChapterId,
                ChapterNumber = item.ChapterNumber,
                Title = item.Title,
                CreatedDate = item.CreatedDate,
                UpdatedDate = item.UpdatedDate,
                Bookmark = item.Bookmark,
            }).OrderBy(item => item.ChapterNumber).ToList();
            dgChapter.DataSource = data;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlFlowLayout.Controls.Clear();
            ExploreForm childForm = new ExploreForm(true);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Clear();
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dgChapter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgChapter.Rows[e.RowIndex];

            viewRow.Cells["Bookmark"].Value = Convert.ToBoolean(viewRow.Cells["Bookmark"].EditedFormattedValue);
            //int row = dgDiary.CurrentCell.RowIndex;
            int id = Int32.Parse(viewRow.Cells[0].FormattedValue.ToString());
            Chapter c = context.Chapters.FirstOrDefault(item => item.ChapterId == id);
            bool bm = Boolean.Parse(viewRow.Cells[5].FormattedValue.ToString());

            try
            {
                if (c != null)
                {
                    if (bm == false)
                    {
                        c.Bookmark = true;
                        context.Chapters.Update(c);
                        if (context.SaveChanges() > 0)
                        {
                            addBookmark(c);
                            loadData();
                        }
                    }
                    else
                    {
                        c.Bookmark = false;
                        context.Chapters.Update(c);
                        if (context.SaveChanges() > 0)
                        {
                            removeBookmark(c);
                            loadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void removeBookmark(Chapter c)
        {
            try
            {
                int id = LoginForm.loginUid;
                Bookmark bm = context.Bookmarks.FirstOrDefault(item => item.UserId == id && item.ChapterId == c.ChapterId);

                if (bm != null)
                {
                    context.Bookmarks.Remove(bm);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Chapter Unmarked Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error");
            }
        }

        private void addBookmark(Chapter c)
        {
            try
            {
                int id = LoginForm.loginUid;

                Bookmark bm = new Bookmark
                {
                    UserId = id,
                    ChapterId = c.ChapterId,
                };

                if (bm != null)
                {
                    ValidationContext validationContext = new ValidationContext(bm, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(bm, validationContext, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                context.Bookmarks.Add(bm);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Chapter Marked Successfully");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.InnerException.Message + "ID: ");
            }
        }


        private void btnAddChapter_Click(object sender, EventArgs e)
        {
            pnlFlowLayout.Controls.Clear();
            ChapterEdit childForm = new ChapterEdit(false);
            loadForm(childForm);

        }

        private void loadForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Clear();
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgChapter.CurrentCell.RowIndex;
                int id = Int32.Parse(dgChapter.Rows[row].Cells[0].FormattedValue.ToString());

                Chapter c = context.Chapters.FirstOrDefault(item => item.ChapterId == id);

                if (c != null)
                {
                    context.Chapters.Remove(c);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Delete success!");
                        loadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int row = dgChapter.CurrentCell.RowIndex;
            int id = Int32.Parse(dgChapter.Rows[row].Cells[0].FormattedValue.ToString());

            pnlFlowLayout.Controls.Clear();
            ChapterEdit chapterEdit = new ChapterEdit(id, true);
            loadForm(chapterEdit);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int row = dgChapter.CurrentCell.RowIndex;
            int id = Int32.Parse(dgChapter.Rows[row].Cells[0].FormattedValue.ToString());

            pnlFlowLayout.Controls.Clear();
            ChapterRead childForm = new ChapterRead(id, true);
            loadForm(childForm);
        }

        private void linkEditBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlFlowLayout.Controls.Clear();
            BookEdit childForm = new BookEdit(true);
            loadForm(childForm);
        }

        private void linkDeleteBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Book b = context.Books.FirstOrDefault(item => item.BookId == sBookId);

                if (b != null)
                {
                    context.Books.Remove(b);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Delete success!");
                        pnlFlowLayout.Controls.Clear();
                        ExploreForm childForm = new ExploreForm(true);
                        childForm.TopLevel = false;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        childForm.Dock = DockStyle.Fill;
                        this.pnlDesktop.Controls.Clear();
                        this.pnlDesktop.Controls.Add(childForm);
                        this.pnlDesktop.Tag = childForm;
                        childForm.BringToFront();
                        childForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error");
            }
        }
    }
}
