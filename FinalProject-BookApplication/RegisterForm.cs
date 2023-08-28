using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FinalProject_BookApplication.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookApplication_FinalProject_Giang
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        BookAppDBContext context = new BookAppDBContext();
        DataProvider d = new DataProvider();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                bool gen = true;
                if (btnFemale.Checked)
                {
                    gen = false;
                }
                User u = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Firstname = txtFirstname.Text,
                    Lastname = txtLastname.Text,
                    DateOfBirth = dateDob.Value,
                    Gender = gen,
                    Email = txtEmail.Text
                };
                if (u != null)
                {
                    ValidationContext validationContext = new ValidationContext(u, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(u, validationContext, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                // string username = "";
                string strSelect = "select * from [User] where Username = '" + txtUsername.Text + "'";
                DataTable dt = d.executeQuery(strSelect);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already existed");
                }
                else
                {
                    context.Users.Add(u);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Register Success!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoginForm l = new LoginForm();
                l.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }

}
