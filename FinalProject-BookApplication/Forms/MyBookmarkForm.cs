using BookApplication_FinalProject_Giang;
using FinalProject_BookApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_BookApplication.Forms
{
    public partial class MyBookmarkForm : Form
    {
        BookAppDBContext context = new BookAppDBContext();

        public MyBookmarkForm()
        {
            InitializeComponent();
        }

        private void MyBookMarkForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var data = context.Bookmarks.Include(x => x.Chapter).Select(item => new
            {
                ChapterID = item.Chapter.ChapterId,
                ChapterNumber = item.Chapter.ChapterNumber,
                Title = item.Chapter.Title,
                CreatedDate = item.Chapter.CreatedDate,
                UpdatedDate = item.Chapter.UpdatedDate,
                Bookmark = item.Chapter.Bookmark,
            }).ToList();
            dgBookmark.DataSource = data;
        }

        private void dgBookmark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgBookmark.Rows[e.RowIndex];

            viewRow.Cells["Bookmark"].Value = Convert.ToBoolean(viewRow.Cells["Bookmark"].EditedFormattedValue);
            //int row = dgBookmark.CurrentCell.RowIndex;
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


        private void btnSelectChapter_Click(object sender, EventArgs e)
        {
            int row = dgBookmark.CurrentCell.RowIndex;
            int id = Int32.Parse(dgBookmark.Rows[row].Cells[0].FormattedValue.ToString());

            pnlFlowLayout.Controls.Clear();
            Form motherForm = new MyBookmarkForm();
            ChapterRead childForm = new ChapterRead(id, false, motherForm);
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
