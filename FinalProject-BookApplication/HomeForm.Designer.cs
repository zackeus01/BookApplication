namespace BookApplication_FinalProject_Giang
{
    partial class HomeForm
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
            panelMenu = new Panel();
            linkRefresh = new LinkLabel();
            imgAvatar = new RashiUI.RashiCircularPictureBox();
            btnSignOut = new Button();
            btnMyBookmarks = new Button();
            btnExplore = new Button();
            btnMyBooks = new Button();
            button1 = new Button();
            btnProfile = new Button();
            lblFullname = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAvatar).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateGray;
            panelMenu.Controls.Add(linkRefresh);
            panelMenu.Controls.Add(imgAvatar);
            panelMenu.Controls.Add(btnSignOut);
            panelMenu.Controls.Add(btnMyBookmarks);
            panelMenu.Controls.Add(btnExplore);
            panelMenu.Controls.Add(btnMyBooks);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(lblFullname);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(191, 501);
            panelMenu.TabIndex = 0;
            // 
            // linkRefresh
            // 
            linkRefresh.ActiveLinkColor = Color.Orange;
            linkRefresh.AutoSize = true;
            linkRefresh.LinkColor = Color.LightGreen;
            linkRefresh.Location = new Point(67, 152);
            linkRefresh.Name = "linkRefresh";
            linkRefresh.Size = new Size(46, 15);
            linkRefresh.TabIndex = 9;
            linkRefresh.TabStop = true;
            linkRefresh.Text = "Refresh";
            linkRefresh.LinkClicked += linkRefresh_LinkClicked;
            // 
            // imgAvatar
            // 
            imgAvatar.Border = 2;
            imgAvatar.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            imgAvatar.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            imgAvatar.ColorBorder = Color.SteelBlue;
            imgAvatar.ColorBorder2 = Color.MediumSeaGreen;
            imgAvatar.Gradiant = 50F;
            imgAvatar.Location = new Point(39, 12);
            imgAvatar.Name = "imgAvatar";
            imgAvatar.Size = new Size(116, 116);
            imgAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAvatar.TabIndex = 8;
            imgAvatar.TabStop = false;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.DarkSeaGreen;
            btnSignOut.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignOut.Location = new Point(10, 458);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(166, 32);
            btnSignOut.TabIndex = 7;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnMyBookmarks
            // 
            btnMyBookmarks.BackColor = Color.DarkSlateGray;
            btnMyBookmarks.FlatAppearance.BorderColor = Color.White;
            btnMyBookmarks.FlatStyle = FlatStyle.Flat;
            btnMyBookmarks.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyBookmarks.ForeColor = Color.White;
            btnMyBookmarks.Location = new Point(0, 321);
            btnMyBookmarks.Name = "btnMyBookmarks";
            btnMyBookmarks.Size = new Size(191, 50);
            btnMyBookmarks.TabIndex = 6;
            btnMyBookmarks.Text = "My Bookmarks";
            btnMyBookmarks.UseVisualStyleBackColor = true;
            btnMyBookmarks.Click += btnMyBookmarks_Click;
            // 
            // btnExplore
            // 
            btnExplore.BackColor = Color.DarkSlateGray;
            btnExplore.FlatAppearance.BorderColor = Color.White;
            btnExplore.FlatStyle = FlatStyle.Flat;
            btnExplore.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnExplore.ForeColor = Color.White;
            btnExplore.Location = new Point(0, 224);
            btnExplore.Name = "btnExplore";
            btnExplore.Size = new Size(191, 50);
            btnExplore.TabIndex = 5;
            btnExplore.Text = "Explore";
            btnExplore.UseVisualStyleBackColor = true;
            btnExplore.Click += btnExplore_Click;
            // 
            // btnMyBooks
            // 
            btnMyBooks.BackColor = Color.DarkSlateGray;
            btnMyBooks.FlatAppearance.BorderColor = Color.White;
            btnMyBooks.FlatStyle = FlatStyle.Flat;
            btnMyBooks.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyBooks.ForeColor = Color.White;
            btnMyBooks.Location = new Point(0, 272);
            btnMyBooks.Name = "btnMyBooks";
            btnMyBooks.Size = new Size(191, 50);
            btnMyBooks.TabIndex = 4;
            btnMyBooks.Text = "My Books";
            btnMyBooks.UseVisualStyleBackColor = true;
            btnMyBooks.Click += btnMyBooks_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 224);
            button1.Name = "button1";
            button1.Size = new Size(191, 50);
            button1.TabIndex = 3;
            button1.Text = "Explore";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.DarkSlateGray;
            btnProfile.FlatAppearance.BorderColor = Color.White;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(0, 177);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(191, 50);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullname.ForeColor = Color.White;
            lblFullname.Location = new Point(58, 131);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(82, 21);
            lblFullname.TabIndex = 1;
            lblFullname.Text = "Full Name";
            // 
            // panelDesktop
            // 
            panelDesktop.Location = new Point(191, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(755, 504);
            panelDesktop.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnProfile;
        private Label lblFullname;
        private Button btnMyBookmarks;
        private Button btnExplore;
        private Button btnMyBooks;
        private Button button1;
        private Button btnSignOut;
        private Panel panelDesktop;
        private RashiUI.RashiCircularPictureBox imgAvatar;
        private LinkLabel linkRefresh;
    }
}