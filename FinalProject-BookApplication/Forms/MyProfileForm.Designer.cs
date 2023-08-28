namespace FinalProject_BookApplication.Forms
{
    partial class MyProfileForm
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
            pnlDesktop = new Panel();
            pnlFlowLayout = new Panel();
            panel1 = new Panel();
            btnChangeAvt = new Button();
            btnSaveAvt = new Button();
            panelRegister = new Panel();
            txtEmail = new TextBox();
            label8 = new Label();
            dateDob = new DateTimePicker();
            txtLastname = new TextBox();
            label7 = new Label();
            btnFemale = new RadioButton();
            btnMale = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtFirstname = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            imgAvatar = new RashiUI.RashiCircularPictureBox();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnEditProfile = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            panel1.SuspendLayout();
            panelRegister.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAvatar).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.BackgroundImage = Properties.Resources.library_book_bookshelf_read;
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(1, 1);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 5;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.BackColor = Color.Transparent;
            pnlFlowLayout.Controls.Add(panel1);
            pnlFlowLayout.Controls.Add(panelRegister);
            pnlFlowLayout.Controls.Add(imgAvatar);
            pnlFlowLayout.Controls.Add(pnlButtons);
            pnlFlowLayout.Location = new Point(27, 12);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(705, 489);
            pnlFlowLayout.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChangeAvt);
            panel1.Controls.Add(btnSaveAvt);
            panel1.Location = new Point(531, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(123, 56);
            panel1.TabIndex = 57;
            // 
            // btnChangeAvt
            // 
            btnChangeAvt.Location = new Point(0, 2);
            btnChangeAvt.Margin = new Padding(3, 2, 3, 2);
            btnChangeAvt.Name = "btnChangeAvt";
            btnChangeAvt.Size = new Size(122, 22);
            btnChangeAvt.TabIndex = 57;
            btnChangeAvt.Text = "Choose Avatar";
            btnChangeAvt.UseVisualStyleBackColor = true;
            btnChangeAvt.Click += btnChangeAvt_Click;
            // 
            // btnSaveAvt
            // 
            btnSaveAvt.Location = new Point(0, 29);
            btnSaveAvt.Name = "btnSaveAvt";
            btnSaveAvt.Size = new Size(122, 23);
            btnSaveAvt.TabIndex = 58;
            btnSaveAvt.Text = "Save Avatar";
            btnSaveAvt.UseVisualStyleBackColor = true;
            btnSaveAvt.Click += btnSaveAvt_Click;
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.Gainsboro;
            panelRegister.Controls.Add(txtEmail);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(dateDob);
            panelRegister.Controls.Add(txtLastname);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(btnFemale);
            panelRegister.Controls.Add(btnMale);
            panelRegister.Controls.Add(label6);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(txtFirstname);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(txtPassword);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(panel2);
            panelRegister.Controls.Add(txtUsername);
            panelRegister.Controls.Add(label2);
            panelRegister.Location = new Point(29, 17);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(408, 415);
            panelRegister.TabIndex = 10;
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
            // txtLastname
            // 
            txtLastname.Location = new Point(118, 214);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(249, 23);
            txtLastname.TabIndex = 9;
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
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 56);
            panel2.TabIndex = 3;
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
            // imgAvatar
            // 
            imgAvatar.Border = 2;
            imgAvatar.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            imgAvatar.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            imgAvatar.ColorBorder = Color.SteelBlue;
            imgAvatar.ColorBorder2 = Color.MediumSeaGreen;
            imgAvatar.Gradiant = 50F;
            imgAvatar.Location = new Point(501, 17);
            imgAvatar.Name = "imgAvatar";
            imgAvatar.Size = new Size(173, 173);
            imgAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAvatar.TabIndex = 9;
            imgAvatar.TabStop = false;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnEditProfile);
            pnlButtons.Location = new Point(501, 257);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(173, 80);
            pnlButtons.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSlateGray;
            btnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 43);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 37);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.DarkSeaGreen;
            btnEditProfile.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(0, 0);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(173, 37);
            btnEditProfile.TabIndex = 12;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 506);
            Controls.Add(pnlDesktop);
            Name = "MyProfileForm";
            Text = "MyProfileForm";
            Load += MyProfileForm_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgAvatar).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private RashiUI.RashiCircularPictureBox imgAvatar;
        private Panel panelRegister;
        private TextBox txtEmail;
        private Label label8;
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
        private Label label3;
        private Panel panel2;
        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private Panel pnlButtons;
        private Button btnCancel;
        private Button btnEditProfile;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button btnChangeAvt;
        private Button btnSaveAvt;
    }
}