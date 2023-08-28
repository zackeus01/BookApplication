using BookApplication_FinalProject_Giang;
using FinalProject_BookApplication.Models;
using FinalProject_BookApplication.Forms;
using FinalProject_BookApplication.Additional;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Threading;

namespace FinalProject_BookApplication.Forms
{
    public partial class ExploreForm : Form
    {
        BookAppDBContext context = new BookAppDBContext();
        public static int setIdValue = 0;
        public static List<Book> listOfAllBooks = new List<Book>();
        public static Boolean edit = false;

        public ExploreForm()
        {
            InitializeComponent();
        }

        public ExploreForm(Boolean xedit)
        {
            InitializeComponent();
            edit = xedit;
        }

        private void ExploreForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            if (edit)
            {
                User u = context.Users.SingleOrDefault(x => x.Uid == LoginForm.loginUid);
                listOfAllBooks = context.Books.Where(x => x.Author == u.Uid).Select(item => new Book
                {
                    BookId = item.BookId,
                    Title = item.Title,
                    Author = item.Author,
                    Description = item.Description,
                    Cover = item.Cover,
                    CreatedDate = item.CreatedDate,
                    UpdatedDate = item.UpdatedDate,
                }).ToList();

                Button btnAddBook = new()
                {
                    BackColor = Color.Brown,
                    Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Location = new Point(540, 460),
                    Name = "btnAddBook",
                    Size = new Size(176, 37),
                    TabIndex = 2,
                    Text = "Add New Book",
                };
                btnAddBook.Click += BtnAddBook_Click;
                pnlDesktop.Controls.Add(btnAddBook);
            }
            else
            {
                listOfAllBooks = context.Books.Select(item => new Book
                {
                    BookId = item.BookId,
                    Title = item.Title,
                    Author = item.Author,
                    Description = item.Description,
                    Cover = item.Cover,
                    CreatedDate = item.CreatedDate,
                    UpdatedDate = item.UpdatedDate,
                }).ToList();
            }
            populateItems(listOfAllBooks);
        }

        private void BtnAddBook_Click(object? sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            BookEdit childForm = new BookEdit(false);
            formLoad(childForm);
        }

        private void populateItems(List<Book> bookList)
        {
            int size = bookList.Count;
            listItem[] itemList = new listItem[size];
            imageURL url = new imageURL();
            int buttonLoc = 188;

            //loop thru each item
            if (pnlFlowLayout.Controls.Count > 0)
            {
                pnlFlowLayout.Controls.Clear();
            }
            for (int i = 0; i < size; i++)
            {
                var bookID = bookList[i].BookId;
                var authorID = bookList[i].Author;
                User author = context.Users.SingleOrDefault(x => x.Uid == authorID);
                string fullname = "Unknown Author";
                if (author != null)
                {
                    fullname = author.Firstname + " " + author.Lastname;
                }
                itemList[i] = new listItem();
                itemList[i].Location = new Point(0, i * 232);
                itemList[i].PropTitle = bookList[i].Title;
                itemList[i].PropAuthor = fullname;
                itemList[i].PropDateCreated = DateTime.Now;
                itemList[i].PropDateUpdated = DateTime.Now;
                itemList[i].PropDesc = bookList[i].Description;
                if (bookList[i].Cover != null)
                {
                    itemList[i].PropCover = Image.FromFile(bookList[i].Cover);
                }
                else
                {
                    itemList[i].PropCover = Image.FromFile("\"D:\\Zack\\FPTU\\Courses\\SEM_5\\PRN211\\Giang-FinalProject\\FinalProject-BookApplication\\FinalProject-BookApplication\\Resources\\default_book_cover_2015.jpg\"");
                }

                Button btnDetail = new()
                {
                    Name = $"{bookID}",
                    Text = "View",
                    BackColor = Color.DarkSlateGray,
                    ForeColor = Color.White,
                    Location = new Point(10, buttonLoc),
                    Size = new Size(126, 23),
                };
                btnDetail.Click += btnDetail_Click;

                buttonLoc += 232;
                //add to flowlayout
                pnlFlowLayout.Controls.Add(itemList[i]);
                pnlFlowLayout.Controls.Add(btnDetail);
            }

        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            String index = ((Button)sender).Name;
            int bookId = int.Parse(index);
            pnlFlowLayout.Controls.Clear();
            Form childForm = new Form();
            if (edit)
            {
                childForm = new MyBookDetail(bookId);
            }
            else
            {
                childForm = new BookDetail(bookId);
            }
            formLoad(childForm);

        }

        private void formLoad(Form childForm)
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

        private void listItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
