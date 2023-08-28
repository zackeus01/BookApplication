using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_BookApplication.Models;

namespace FinalProject_BookApplication.Forms
{
    public partial class ChapterRead : Form
    {
        private int chapterId;
        private Chapter currentChapter;
        private bool edit = false;
        private Form motherForm;

        BookAppDBContext context = new BookAppDBContext();

        public ChapterRead()
        {
            InitializeComponent();
        }

        public ChapterRead(int id)
        {
            InitializeComponent();
            chapterId = id;
            motherForm = null;
        }

        public ChapterRead(int id, bool xedit)
        {
            InitializeComponent();
            chapterId = id;
            this.edit = xedit;
            motherForm = null;
        }

        public ChapterRead(int id, bool xedit, Form mother)
        {
            InitializeComponent();
            chapterId = id;
            this.edit = xedit;
            motherForm = mother;
        }

        private void ChapterRead_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            currentChapter = context.Chapters.SingleOrDefault(x => x.ChapterId == chapterId);
            string chapterNumber = "Chapter " + currentChapter.ChapterNumber;
            lblChapterNumber.Text = chapterNumber.ToUpper();
            lblTitle.Text = currentChapter.Title;
            txtContent.Text = currentChapter.Content;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int bookId = (int)currentChapter.BookId;
            pnlDesktop.Controls.Clear();
            Form childForm = new Form();
            if (edit)
            {
                childForm = new MyBookDetail(bookId);
            }
            else if (motherForm != null)
            {
                childForm = motherForm;
            }
            else
            {
                childForm = new BookDetail(bookId);
            }
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
