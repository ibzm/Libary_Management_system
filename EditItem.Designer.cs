namespace Library_Management_System
{
    partial class EditItem
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
            Title = new TextBox();
            Type = new TextBox();
            AvailableCopies = new TextBox();
            Genre = new TextBox();
            Author = new TextBox();
            TotalCopies = new TextBox();
            Save = new Button();
            Id = new TextBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(240, 42);
            Title.Name = "Title";
            Title.Size = new Size(100, 23);
            Title.TabIndex = 1;
            Title.Text = "Title";
            // 
            // Type
            // 
            Type.Location = new Point(134, 42);
            Type.Name = "Type";
            Type.Size = new Size(100, 23);
            Type.TabIndex = 2;
            Type.Text = "Type";
            // 
            // AvailableCopies
            // 
            AvailableCopies.Location = new Point(134, 80);
            AvailableCopies.Name = "AvailableCopies";
            AvailableCopies.Size = new Size(100, 23);
            AvailableCopies.TabIndex = 3;
            AvailableCopies.Text = "AvailableCopies";
            // 
            // Genre
            // 
            Genre.Location = new Point(28, 80);
            Genre.Name = "Genre";
            Genre.Size = new Size(100, 23);
            Genre.TabIndex = 4;
            Genre.Text = "Genre";
            // 
            // Author
            // 
            Author.Location = new Point(346, 42);
            Author.Name = "Author";
            Author.Size = new Size(100, 23);
            Author.TabIndex = 5;
            Author.Text = "Author";
            // 
            // TotalCopies
            // 
            TotalCopies.Location = new Point(240, 80);
            TotalCopies.Name = "TotalCopies";
            TotalCopies.Size = new Size(100, 23);
            TotalCopies.TabIndex = 6;
            // 
            // Save
            // 
            Save.Location = new Point(563, 200);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 7;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Id
            // 
            Id.Location = new Point(28, 42);
            Id.Name = "Id";
            Id.Size = new Size(100, 23);
            Id.TabIndex = 0;
            Id.Text = "id";
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(TotalCopies);
            Controls.Add(Author);
            Controls.Add(Genre);
            Controls.Add(AvailableCopies);
            Controls.Add(Type);
            Controls.Add(Title);
            Controls.Add(Id);
            Name = "EditItem";
            Text = "EditItemcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Title;
        private TextBox Type;
        private TextBox AvailableCopies;
        private TextBox Genre;
        private TextBox Author;
        private TextBox TotalCopies;
        private Button Save;
        private TextBox Id;
    }
}