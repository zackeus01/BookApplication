using BookApplication_FinalProject_Giang;
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
using System.Xml.Linq;

namespace FinalProject_BookApplication.Forms
{
    public partial class ChapterEdit : Form
    {
        private int chapterId;
        private Chapter currentChapter;
        private bool edit = false;
        BookAppDBContext context = new BookAppDBContext();

        public ChapterEdit()
        {
            InitializeComponent();
        }

        public ChapterEdit(int id)
        {
            InitializeComponent();
            this.chapterId = id;
        }
        public ChapterEdit(int id, bool xedit)
        {
            InitializeComponent();
            this.chapterId = id;
            this.edit = xedit;
        }

        public ChapterEdit(bool xedit)
        {
            InitializeComponent();
            this.edit = xedit;
        }

        private void ChapterEdit_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            if (edit)
            {
                currentChapter = context.Chapters.SingleOrDefault(x => x.ChapterId == chapterId);
                int chapterNumber = (int)currentChapter.ChapterNumber;
                lblChapterId.Text = currentChapter.ChapterId.ToString();
                numChapterNumber.Value = (decimal)chapterNumber;
                txtTitle.Text = currentChapter.Title;
                txtContent.Text = currentChapter.Content;
            }
            else
            {
                lblChapterId.Text = "TBA";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int bookId = (int)MyBookDetail.sBookId;
            pnlDesktop.Controls.Clear();
            MyBookDetail childForm = new MyBookDetail(bookId);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Clear();
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                updateChapter();
            }
            else
            {
                addChapter();
            }
        }

        private void updateChapter()
        {
            Chapter c = context.Chapters.FirstOrDefault(c => c.ChapterId == chapterId);

            try
            {
                if (c != null)
                {
                    c.Title = txtTitle.Text;
                    c.Content = txtContent.Text;
                    c.ChapterNumber = (int)numChapterNumber.Value;
                    c.UpdatedDate = DateTime.Now;

                    if (c != null)
                    {
                        ValidationContext validationContext = new ValidationContext(c, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(c, validationContext, errors, true))
                        {
                            foreach (ValidationResult result in errors)
                            {
                                MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update success");
                    }
                }
                else
                {
                    MessageBox.Show("Update fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addChapter()
        {
            try
            {

                int id = LoginForm.loginUid;

                Chapter c = new Chapter
                {
                    ChapterNumber = (int)numChapterNumber.Value,
                    Title = txtTitle.Text,
                    BookId = MyBookDetail.sBookId,
                    Content = txtContent.Text,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Bookmark = false,
                };

                if (c != null)
                {
                    ValidationContext validationContext = new ValidationContext(c, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(c, validationContext, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                context.Chapters.Add(c);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add Success " + id);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.InnerException.Message + "ID: ");
            }
        }
    }
}
