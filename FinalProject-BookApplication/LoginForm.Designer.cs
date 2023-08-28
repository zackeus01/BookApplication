namespace BookApplication_FinalProject_Giang
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userIcon = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxUsername = new TextBox();
            label3 = new Label();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            linkRegister = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userIcon
            // 
            userIcon.Image = FinalProject_BookApplication.Properties.Resources.user_icon;
            userIcon.Location = new Point(71, 3);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(116, 78);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 0;
            userIcon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(47, 84);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 1;
            label1.Text = "Login to Your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(13, 115);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(13, 133);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(229, 23);
            txtBoxUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(13, 169);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(13, 187);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(229, 23);
            txtBoxPassword.TabIndex = 5;
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(13, 251);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(229, 27);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(59, 224);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 7;
            label4.Text = "Do not have an account?";
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.Cyan;
            linkRegister.AutoSize = true;
            linkRegister.LinkColor = Color.CadetBlue;
            linkRegister.Location = new Point(193, 224);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(49, 15);
            linkRegister.TabIndex = 8;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userIcon);
            panel1.Location = new Point(246, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 291);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FinalProject_BookApplication.Properties.Resources.Book_bg;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 342);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userIcon;
        private Label label1;
        private Label label2;
        private TextBox txtBoxUsername;
        private Label label3;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private Label label4;
        private LinkLabel linkRegister;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}