using FinalProject_BookApplication.Models;
using FinalProject_BookApplication.Additional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_BookApplication.Forms;
using System.Xml.Linq;
using System.Net;

namespace BookApplication_FinalProject_Giang
{
    public partial class HomeForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        private string username;
        BookAppDBContext context = new BookAppDBContext();

        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            imageURL url = new imageURL();
            User u = context.Users.FirstOrDefault(u => u.Uid == LoginForm.loginUid);

            if (u.Avatar != null)
            {
                imgAvatar.Image = Image.FromFile(u.Avatar);
            }
            else
            {
                imgAvatar.Image = Image.FromFile("\"D:\\Zack\\FPTU\\Courses\\SEM_5\\PRN211\\Giang-FinalProject\\FinalProject-BookApplication\\FinalProject-BookApplication\\Resources\\user-icon.png\"");
            }

            lblFullname.Text = u.Firstname + " " + u.Lastname;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.AliceBlue;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.DarkSlateGray;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkSlateGray;
                    previousBtn.ForeColor = Color.White;
                    //previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinalProject_BookApplication.Forms.MyProfileForm(), sender);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinalProject_BookApplication.Forms.ExploreForm(false), sender);
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinalProject_BookApplication.Forms.ExploreForm(true), sender);
        }

        private void btnMyBookmarks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinalProject_BookApplication.Forms.MyBookmarkForm(), sender);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (MessageBox.Show(this, "Do you want to sign out?", "Sign Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                loginForm.Show();
                this.Hide();
            }
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

    }
}
