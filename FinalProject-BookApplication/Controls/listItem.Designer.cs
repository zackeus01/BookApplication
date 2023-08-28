namespace FinalProject_BookApplication
{
    partial class listItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imgCover = new PictureBox();
            lblTitle = new Label();
            panel1 = new Panel();
            lblDateUpdated = new Label();
            label7 = new Label();
            lblDesc = new Label();
            label8 = new Label();
            lblDateCreated = new Label();
            label5 = new Label();
            lblAuthor = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCover).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imgCover
            // 
            imgCover.Location = new Point(10, 11);
            imgCover.Name = "imgCover";
            imgCover.Size = new Size(123, 172);
            imgCover.TabIndex = 0;
            imgCover.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(163, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(417, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "BookTitle";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDateUpdated);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblDateCreated);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblAuthor);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(163, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 123);
            panel1.TabIndex = 2;
            // 
            // lblDateUpdated
            // 
            lblDateUpdated.Location = new Point(306, 22);
            lblDateUpdated.Name = "lblDateUpdated";
            lblDateUpdated.Size = new Size(108, 15);
            lblDateUpdated.TabIndex = 15;
            lblDateUpdated.Text = "Author name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(206, 22);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 14;
            label7.Text = "Lastest Updated:";
            // 
            // lblDesc
            // 
            lblDesc.Location = new Point(45, 41);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(369, 73);
            lblDesc.TabIndex = 13;
            lblDesc.Text = "Insert Book's descroption here";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(3, 41);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 12;
            label8.Text = "Desc:";
            // 
            // lblDateCreated
            // 
            lblDateCreated.Location = new Point(84, 22);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(116, 15);
            lblDateCreated.TabIndex = 9;
            lblDateCreated.Text = "Author name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 8;
            label5.Text = "Date Created:";
            // 
            // lblAuthor
            // 
            lblAuthor.Location = new Point(64, 4);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(350, 20);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "Author:";
            // 
            // listItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(imgCover);
            Name = "listItem";
            Size = new Size(612, 193);
            ((System.ComponentModel.ISupportInitialize)imgCover).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgCover;
        private Label lblTitle;
        private Panel panel1;
        private Label lblDateUpdated;
        private Label label7;
        private Label lblDesc;
        private Label label8;
        private Label lblDateCreated;
        private Label label5;
        private Label lblAuthor;
        private Label label2;
    }
}
