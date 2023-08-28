namespace FinalProject_BookApplication.Forms
{
    partial class ChapterEdit
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
            lblChapterId = new Label();
            label5 = new Label();
            txtContent = new RichTextBox();
            label4 = new Label();
            numChapterNumber = new NumericUpDown();
            txtTitle = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numChapterNumber).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(2, 1);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 4;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.Controls.Add(lblChapterId);
            pnlFlowLayout.Controls.Add(label5);
            pnlFlowLayout.Controls.Add(txtContent);
            pnlFlowLayout.Controls.Add(label4);
            pnlFlowLayout.Controls.Add(numChapterNumber);
            pnlFlowLayout.Controls.Add(txtTitle);
            pnlFlowLayout.Controls.Add(label3);
            pnlFlowLayout.Controls.Add(label1);
            pnlFlowLayout.Controls.Add(pnlButtons);
            pnlFlowLayout.Location = new Point(27, 12);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(705, 489);
            pnlFlowLayout.TabIndex = 2;
            // 
            // lblChapterId
            // 
            lblChapterId.AutoSize = true;
            lblChapterId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChapterId.ForeColor = Color.DarkSlateGray;
            lblChapterId.Location = new Point(88, 10);
            lblChapterId.Name = "lblChapterId";
            lblChapterId.Size = new Size(12, 15);
            lblChapterId.TabIndex = 14;
            lblChapterId.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(15, 10);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "ChapterID:";
            // 
            // txtContent
            // 
            txtContent.BackColor = SystemColors.ScrollBar;
            txtContent.Location = new Point(15, 99);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(687, 336);
            txtContent.TabIndex = 11;
            txtContent.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(15, 81);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Content:";
            // 
            // numChapterNumber
            // 
            numChapterNumber.Location = new Point(124, 41);
            numChapterNumber.Name = "numChapterNumber";
            numChapterNumber.Size = new Size(79, 23);
            numChapterNumber.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(262, 41);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(430, 23);
            txtTitle.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(221, 44);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Chapter Number:";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Location = new Point(15, 449);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(677, 37);
            pnlButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SteelBlue;
            btnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(336, 37);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(360, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(342, 37);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ChapterEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 503);
            Controls.Add(pnlDesktop);
            Name = "ChapterEdit";
            Text = "ChapterEdit";
            Load += ChapterEdit_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            pnlFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numChapterNumber).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private Panel pnlButtons;
        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private NumericUpDown numChapterNumber;
        private TextBox txtTitle;
        private Label label3;
        private Label label1;
        private RichTextBox txtContent;
        private Label lblChapterId;
        private Label label5;
    }
}