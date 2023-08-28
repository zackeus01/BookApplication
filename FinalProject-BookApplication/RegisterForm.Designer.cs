namespace BookApplication_FinalProject_Giang
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateDob = new DateTimePicker();
            label7 = new Label();
            btnFemale = new RadioButton();
            btnMale = new RadioButton();
            label6 = new Label();
            txtLastname = new TextBox();
            label5 = new Label();
            txtFirstname = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            label2 = new Label();
            panelRegister = new Panel();
            linkLabel1 = new LinkLabel();
            btnRegister = new Button();
            txtEmail = new TextBox();
            label8 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateDob
            // 
            dateDob.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateDob.CustomFormat = "dd/MM/yyyy";
            dateDob.Format = DateTimePickerFormat.Custom;
            dateDob.Location = new Point(167, 304);
            dateDob.MaxDate = new DateTime(2023, 7, 21, 0, 0, 0, 0);
            dateDob.Name = "dateDob";
            dateDob.Size = new Size(200, 23);
            dateDob.TabIndex = 14;
            dateDob.Value = new DateTime(2023, 7, 21, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(28, 304);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 13;
            label7.Text = "Date Of Birth:";
            // 
            // btnFemale
            // 
            btnFemale.AutoSize = true;
            btnFemale.Location = new Point(193, 264);
            btnFemale.Name = "btnFemale";
            btnFemale.Size = new Size(63, 19);
            btnFemale.TabIndex = 12;
            btnFemale.TabStop = true;
            btnFemale.Text = "Female";
            btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            btnMale.AutoSize = true;
            btnMale.Location = new Point(119, 264);
            btnMale.Name = "btnMale";
            btnMale.Size = new Size(51, 19);
            btnMale.TabIndex = 11;
            btnMale.TabStop = true;
            btnMale.Text = "Male";
            btnMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(28, 261);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 10;
            label6.Text = "Gender:";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(118, 211);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(249, 23);
            txtLastname.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(28, 212);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 8;
            label5.Text = "Last Name:";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(118, 165);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(249, 23);
            txtFirstname.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(28, 166);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 6;
            label4.Text = "First Name:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(118, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 23);
            txtPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 16);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 0;
            label1.Text = "Register Your Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 56);
            panel2.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(118, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(linkLabel1);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(txtEmail);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(dateDob);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(btnFemale);
            panelRegister.Controls.Add(btnMale);
            panelRegister.Controls.Add(label6);
            panelRegister.Controls.Add(txtLastname);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(txtFirstname);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(txtPassword);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(panel2);
            panelRegister.Controls.Add(txtUsername);
            panelRegister.Controls.Add(label2);
            panelRegister.Location = new Point(48, 12);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(408, 462);
            panelRegister.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Cyan;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.DarkSlateGray;
            linkLabel1.Location = new Point(145, 429);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Return to Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkSlateGray;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(28, 391);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(339, 35);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 23);
            txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(28, 348);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 15;
            label8.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FinalProject_BookApplication.Properties.Resources.book_library_with_open_textbook;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(panelRegister);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            Text = "SignUp";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateDob;
        private Label label7;
        private RadioButton btnFemale;
        private RadioButton btnMale;
        private Label label6;
        private TextBox txtLastname;
        private Label label5;
        private TextBox txtFirstname;
        private Label label4;
        private TextBox txtPassword;
        private Label label1;
        private Panel panel2;
        private TextBox txtUsername;
        private Label label2;
        private Panel panelRegister;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnRegister;
        private TextBox txtEmail;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}