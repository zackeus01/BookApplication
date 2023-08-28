namespace FinalProject_BookApplication.Forms
{
    partial class ChapterRead
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
            btnReturn = new Button();
            pnlFlowLayout = new Panel();
            txtContent = new RichTextBox();
            lblTitle = new Label();
            lblChapterNumber = new Label();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(btnReturn);
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(-2, 0);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 4;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DarkSlateGray;
            btnReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(452, 459);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(273, 32);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return to Chapter Navigtion";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.AutoScroll = true;
            pnlFlowLayout.BackColor = SystemColors.ScrollBar;
            pnlFlowLayout.Controls.Add(txtContent);
            pnlFlowLayout.Controls.Add(lblTitle);
            pnlFlowLayout.Controls.Add(lblChapterNumber);
            pnlFlowLayout.Location = new Point(27, 12);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(698, 441);
            pnlFlowLayout.TabIndex = 3;
            // 
            // txtContent
            // 
            txtContent.BackColor = SystemColors.ScrollBar;
            txtContent.Location = new Point(16, 88);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(679, 336);
            txtContent.TabIndex = 2;
            txtContent.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(109, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "The boy who lived";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblChapterNumber
            // 
            lblChapterNumber.Font = new Font("Montserrat ExtraBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChapterNumber.ForeColor = Color.DarkSlateGray;
            lblChapterNumber.Location = new Point(232, 10);
            lblChapterNumber.Name = "lblChapterNumber";
            lblChapterNumber.Size = new Size(191, 29);
            lblChapterNumber.TabIndex = 0;
            lblChapterNumber.Text = "Chapter 1";
            lblChapterNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChapterRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 503);
            Controls.Add(pnlDesktop);
            Name = "ChapterRead";
            Text = "ChapterRead";
            Load += ChapterRead_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private Button btnReturn;
        private Label lblContent;
        private Label lblTitle;
        private Label lblChapterNumber;
        private RichTextBox txtContent;
    }
}