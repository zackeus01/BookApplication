namespace FinalProject_BookApplication.Forms
{
    partial class BookEdit
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
            btnChangeCover = new Button();
            txtTitle = new TextBox();
            txtDesc = new RichTextBox();
            imgCover = new PictureBox();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pnlDesktop.SuspendLayout();
            pnlFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCover).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlFlowLayout);
            pnlDesktop.Location = new Point(1, 1);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(755, 504);
            pnlDesktop.TabIndex = 4;
            // 
            // pnlFlowLayout
            // 
            pnlFlowLayout.Controls.Add(btnChangeCover);
            pnlFlowLayout.Controls.Add(txtTitle);
            pnlFlowLayout.Controls.Add(txtDesc);
            pnlFlowLayout.Controls.Add(imgCover);
            pnlFlowLayout.Controls.Add(pnlButtons);
            pnlFlowLayout.Controls.Add(label2);
            pnlFlowLayout.Controls.Add(label3);
            pnlFlowLayout.Location = new Point(27, 12);
            pnlFlowLayout.Name = "pnlFlowLayout";
            pnlFlowLayout.Size = new Size(705, 489);
            pnlFlowLayout.TabIndex = 2;
            // 
            // btnChangeCover
            // 
            btnChangeCover.Location = new Point(55, 374);
            btnChangeCover.Margin = new Padding(3, 2, 3, 2);
            btnChangeCover.Name = "btnChangeCover";
            btnChangeCover.Size = new Size(149, 22);
            btnChangeCover.TabIndex = 58;
            btnChangeCover.Text = "Change Book Cover";
            btnChangeCover.UseVisualStyleBackColor = true;
            btnChangeCover.Click += btnChangeCover_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(306, 43);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(379, 54);
            txtTitle.TabIndex = 15;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = SystemColors.ScrollBar;
            txtDesc.Location = new Point(306, 142);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(379, 277);
            txtDesc.TabIndex = 14;
            txtDesc.Text = "";
            // 
            // imgCover
            // 
            imgCover.Location = new Point(13, 15);
            imgCover.Name = "imgCover";
            imgCover.Size = new Size(246, 344);
            imgCover.SizeMode = PictureBoxSizeMode.Zoom;
            imgCover.TabIndex = 3;
            imgCover.TabStop = false;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Location = new Point(0, 449);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(702, 37);
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
            btnSave.Text = "Save Book";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(306, 16);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 10;
            label2.Text = "Book TItle:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(306, 108);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 12;
            label3.Text = "Description:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BookEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 504);
            Controls.Add(pnlDesktop);
            Name = "BookEdit";
            Text = "BookEdit";
            Load += BookEdit_Load;
            pnlDesktop.ResumeLayout(false);
            pnlFlowLayout.ResumeLayout(false);
            pnlFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCover).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesktop;
        private Panel pnlFlowLayout;
        private Panel pnlButtons;
        private Button btnCancel;
        private Button btnSave;
        private PictureBox imgCover;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private RichTextBox txtDesc;
        private Button btnChangeCover;
        private OpenFileDialog openFileDialog1;
    }
}