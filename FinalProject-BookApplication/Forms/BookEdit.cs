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
    public partial class BookEdit : Form
    {
        private bool edit = false;
        private int bookId;
        BookAppDBContext context = new BookAppDBContext();

        public BookEdit()
        {
            InitializeComponent();
        }

        public BookEdit(bool xedit)
        {
            InitializeComponent();
            bookId = MyBookDetail.sBookId;
            edit = xedit;
        }

        public BookEdit(int id)
        {
            InitializeComponent();
            bookId = id;
        }

        public BookEdit(int id, bool xedit)
        {
            InitializeComponent();
            bookId = id;
            edit = xedit;
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            if (edit)
            {
                imageURL url = new imageURL();
                Book bookToRead = context.Books.SingleOrDefault(x => x.BookId == bookId);
                var authorID = bookToRead.Author;
                User author = context.Users.SingleOrDefault(x => x.Uid == authorID);
                string fullname = "Unknown Author";
                if (author != null)
                {
                    fullname = author.Firstname + " " + author.Lastname;
                }
                txtTitle.Text = bookToRead.Title;
                txtDesc.Text = bookToRead.Description;
                if (bookToRead.Cover != null)
                {
                    Image originalImage = Image.FromFile(bookToRead.Cover);

                    // Resize the image to 246x344 pixels
                    Image resizedImage = originalImage.GetThumbnailImage(246, 344, null, IntPtr.Zero);

                    imgCover.Image = resizedImage;
                }
                else
                {
                    // Load the default image and resize it to 246x344 pixels
                    Image defaultImage = Image.FromFile("D:\\Zack\\FPTU\\Courses\\SEM_5\\PRN211\\Giang-FinalProject\\FinalProject-BookApplication\\FinalProject-BookApplication\\Resources\\default_book_cover_2015.jpg");
                    Image resizedDefaultImage = defaultImage.GetThumbnailImage(246, 344, null, IntPtr.Zero);

                    imgCover.Image = resizedDefaultImage;
                }
            }
        }

        private void btnChangeCover_Click(object sender, EventArgs e)
        {
            User user = new User();

            openFileDialog1.Filter = "Select image(*.jpg; *.png)|*.jpg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgCover.Image = Image.FromFile(openFileDialog1.FileName);
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
                updateBook();
            }
            else
            {
                addBook();
            }
        }

        private void updateBook()
        {
            Book b = context.Books.FirstOrDefault(b => b.BookId == bookId);

            try
            {
                if (b != null)
                {
                    b.Title = txtTitle.Text;
                    b.Description = txtDesc.Text;
                    b.UpdatedDate = DateTime.Now;
                    b.Cover = openFileDialog1.FileName;

                    if (b != null)
                    {
                        ValidationContext validationContext = new ValidationContext(b, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(b, validationContext, errors, true))
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

        private void addBook()
        {
            try
            {
                int id = LoginForm.loginUid;

                Book b = new Book
                {
                    Title = txtTitle.Text,
                    Description = txtDesc.Text,
                    Author = LoginForm.loginUid,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Cover = openFileDialog1.FileName,
                };

                if (b != null)
                {
                    ValidationContext validationContext = new ValidationContext(b, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(b, validationContext, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                context.Books.Add(b);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add Success " + id);
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
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.InnerException.Message + "ID: ");
            }
        }
    }
}
