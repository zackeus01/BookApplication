using FinalProject_BookApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication_FinalProject_Giang
{
    public partial class LoginForm : Form
    {
        //public static string setValueUser = "";
        public static int loginUid = 0;

        public LoginForm()
        {
            InitializeComponent();
            loginUid = 0;
        }
        BookAppDBContext context = new BookAppDBContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (context.Users.Where(u => u.Username == txtBoxUsername.Text
                                         && u.Password == txtBoxPassword.Text).Count() > 0)
                {
                    MessageBox.Show("Login Successfully!");
                    //setValueUser = txtBoxUsername.Text;
                    loginUid = context.Users.FirstOrDefault(u => u.Username == txtBoxUsername.Text && u.Password == txtBoxPassword.Text).Uid;
                    HomeForm hf = new HomeForm();
                    hf.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or password is incorrect. Please try again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RegisterForm form = new RegisterForm();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}