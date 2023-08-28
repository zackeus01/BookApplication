using BookApplication_FinalProject_Giang;
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
using System.ComponentModel.DataAnnotations;

namespace FinalProject_BookApplication.Forms
{
    public partial class MyProfileForm : Form
    {
        BookAppDBContext context = new BookAppDBContext();

        public MyProfileForm()
        {
            InitializeComponent();
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
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

            txtUsername.Text = u.Username;
            txtPassword.Text = u.Password;
            txtEmail.Text = u.Email;
            txtFirstname.Text = u.Firstname;
            txtLastname.Text = u.Lastname;
            if ((bool)u.Gender)
            {
                btnMale.Checked = true;
                btnFemale.Checked = false;
            }
            else
            {
                btnFemale.Checked = true;
                btnMale.Checked = false;
            }
            dateDob.Value = (DateTime)u.DateOfBirth;

            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFirstname.ReadOnly = true;
            txtLastname.ReadOnly = true;
            btnMale.Enabled = false;
            btnFemale.Enabled = false;
            dateDob.Enabled = false;
            txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;

            pnlButtons.Controls.Clear();

            Button btnEdit = new Button()
            {
                Name = "btnEdit",
                Location = new Point(0, 0),
                Size = new Size(173, 37),
                Text = "Edit Profile",
                BackColor = Color.DarkSeaGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11.25f, FontStyle.Bold)
            };
            btnEdit.Click += btnEditProfile_Click;

            pnlButtons.Controls.Add(btnEdit);
        }


        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFirstname.ReadOnly = false;
            txtLastname.ReadOnly = false;
            btnMale.Enabled = true;
            btnFemale.Enabled = true;
            dateDob.Enabled = true;
            pnlButtons.Controls.Clear();

            Button btnSave = new Button()
            {
                Name = "btnSave",
                Location = new Point(0, 0),
                Size = new Size(173, 37),
                Text = "Save",
                BackColor = Color.DarkSeaGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11.25f, FontStyle.Bold)
            };
            btnSave.Click += btnSave_Click;

            Button btnCancel = new Button()
            {
                Name = "btnCancel",
                Location = new Point(0, 43),
                Size = new Size(173, 37),
                Text = "Cancel",
                BackColor = Color.DarkSlateGray,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11.25f, FontStyle.Bold)
            };
            btnCancel.Click += btnCancel_Click;

            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnCancel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User u = context.Users.FirstOrDefault(u => u.Uid == LoginForm.loginUid);

            try
            {
                if (u != null)
                {
                    bool gen = true;
                    if (btnFemale.Checked)
                    {
                        gen = false;
                    }

                    u.Username = txtUsername.Text;
                    u.Password = txtPassword.Text;
                    u.Email = txtEmail.Text;
                    u.DateOfBirth = dateDob.Value;
                    u.Gender = gen;
                    u.Firstname = txtFirstname.Text;
                    u.Lastname = txtLastname.Text;

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

                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update success");
                        loadData();
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
                loadData();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadData();
        }

        //private async void btnChangeAvt_Click(object sender, EventArgs e)
        //{
        //    User user = new User();

        //    openFileDialog1.Filter = "Select image(*.jpg; *.png)|*.jpg; *.png";
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        // Get the local file path of the selected image
        //        string imagePath = openFileDialog1.FileName;

        //        // Load the image into the PictureBox
        //        imgAvatar.Image = Image.FromFile(imagePath);

        //        try
        //        {
        //            // Prepare the HTTP client
        //            using (HttpClient client = new HttpClient())
        //            {
        //                // Create a multi-part form content to send the image as a file
        //                using (var content = new MultipartFormDataContent())
        //                {
        //                    // Read the image file and add it to the content
        //                    byte[] imageBytes = File.ReadAllBytes(imagePath);
        //                    content.Add(new ByteArrayContent(imageBytes), "imageFile", Path.GetFileName(imagePath));

        //                    // Make the API call to the server to upload the image
        //                    HttpResponseMessage response = await client.PostAsync("http://localhost:7057/api/ImageUpload", content);

        //                    // Check if the API call was successful
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        // Get the URL of the uploaded image from the response
        //                        string imageUrl = await response.Content.ReadAsStringAsync();

        //                        // Do whatever you need to do with the imageUrl, such as saving it to the database.
        //                        // Note that imageUrl now contains the URL of the uploaded image on the server.
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Image upload failed.");
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred: " + ex.Message);
        //        }
        //    }
        //}

        private void btnChangeAvt_Click(object sender, EventArgs e)
        {
            User user = new User();

            openFileDialog1.Filter = "Select image(*.jpg; *.png)|*.jpg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSaveAvt_Click(object sender, EventArgs e)
        {
            User u = context.Users.FirstOrDefault(u => u.Uid == LoginForm.loginUid);

            try
            {
                if (u != null)
                {
                    bool gen = true;
                    if (btnFemale.Checked)
                    {
                        gen = false;
                    }

                    u.Avatar = openFileDialog1.FileName;

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

                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update success");
                        loadData();
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
                loadData();
            }

        }
    }
}
