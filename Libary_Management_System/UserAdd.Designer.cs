namespace Library_Management_System
{
    partial class UserAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new TextBox();
            Author = new TextBox();
            AvailableCopies = new NumericUpDown();
            TotalCopies = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            Id = new TextBox();
            Genre = new TextBox();
            option = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)AvailableCopies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalCopies).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(245, 38);
            Title.Name = "Title";
            Title.Size = new Size(100, 23);
            Title.TabIndex = 1;
            Title.Text = "Title";
            // 
            // Author
            // 
            Author.Location = new Point(445, 38);
            Author.Name = "Author";
            Author.Size = new Size(100, 23);
            Author.TabIndex = 2;
            Author.Text = "Author";
            // 
            // AvailableCopies
            // 
            AvailableCopies.Location = new Point(551, 36);
            AvailableCopies.Name = "AvailableCopies";
            AvailableCopies.Size = new Size(120, 23);
            AvailableCopies.TabIndex = 4;
            // 
            // TotalCopies
            // 
            TotalCopies.Location = new Point(677, 36);
            TotalCopies.Name = "TotalCopies";
            TotalCopies.Size = new Size(120, 23);
            TotalCopies.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(713, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "AddBook";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(713, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            Id.Location = new Point(12, 36);
            Id.Name = "Id";
            Id.Size = new Size(100, 23);
            Id.TabIndex = 10;
            Id.Text = "id";
            // 
            // Genre
            // 
            Genre.Location = new Point(351, 38);
            Genre.Name = "Genre";
            Genre.Size = new Size(100, 23);
            Genre.TabIndex = 12;
            Genre.Text = "Genre";
            // 
            // option
            // 
            option.FormattingEnabled = true;
            option.Location = new Point(118, 36);
            option.Name = "option";
            option.Size = new Size(121, 23);
            option.TabIndex = 13;
            option.Text = "type";
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(option);
            Controls.Add(Genre);
            Controls.Add(Id);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(TotalCopies);
            Controls.Add(AvailableCopies);
            Controls.Add(Author);
            Controls.Add(Title);
            Name = "UserAdd";
            Text = "UserAdd";
            ((System.ComponentModel.ISupportInitialize)AvailableCopies).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Title;
        private TextBox Author;
        private NumericUpDown AvailableCopies;
        private NumericUpDown TotalCopies;
        private Button btnSave;
        private Button btnCancel;
        private TextBox Id;
        private TextBox Genre;
        private ComboBox option;
    }
}