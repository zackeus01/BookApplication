namespace FinalProject_BookApplication.Forms
{
    partial class ExploreForm
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
            listItem2 = new listItem();
            button2 = new Button();
            listItem1 = new listItem();
            button1 = new Button();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(-3, -1);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 1;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.AutoScroll = true;
            pnlFlowLayout.Controls.Add(listItem2);
            pnlFlowLayout.Controls.Add(button2);
            pnlFlowLayout.Controls.Add(listItem1);
            pnlFlowLayout.Controls.Add(button1);
            pnlFlowLayout.Location = new Point(27, 13);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(689, 441);
            pnlFlowLayout.TabIndex = 1;
            // 
            // listItem2
            // 
            listItem2.AutoSize = true;
            listItem2.Location = new Point(0, 232);
            listItem2.Name = "listItem2";
            listItem2.PropAuthor = null;
            listItem2.PropCover = Properties.Resources.default_book_cover_2015;
            listItem2.PropDateCreated = new DateTime(0L);
            listItem2.PropDateUpdated = new DateTime(0L);
            listItem2.PropDesc = null;
            listItem2.PropTitle = null;
            listItem2.Size = new Size(583, 186);
            listItem2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 418);
            button2.Name = "button2";
            button2.Size = new Size(126, 23);
            button2.TabIndex = 4;
            button2.Text = "Read Now";
            button2.UseVisualStyleBackColor = false;
            // 
            // listItem1
            // 
            listItem1.AutoSize = true;
            listItem1.Location = new Point(0, 0);
            listItem1.Name = "listItem1";
            listItem1.PropAuthor = null;
            listItem1.PropCover = Properties.Resources.default_book_cover_2015;
            listItem1.PropDateCreated = new DateTime(0L);
            listItem1.PropDateUpdated = new DateTime(0L);
            listItem1.PropDesc = null;
            listItem1.PropTitle = null;
            listItem1.Size = new Size(583, 186);
            listItem1.TabIndex = 3;
            listItem1.Load += listItem1_Load;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 188);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 2;
            button1.Text = "Read Now";
            button1.UseVisualStyleBackColor = false;
            // 
            // ExploreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 503);
            Controls.Add(pnlDesktop);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExploreForm";
            Text = "ExploreForm";
            Load += ExploreForm_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            pnlFlowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private listItem listItem2;
        private Button button2;
        private listItem listItem1;
        private Button button1;
    }
}