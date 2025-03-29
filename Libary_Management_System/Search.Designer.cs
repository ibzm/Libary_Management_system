namespace Library_Management_System
{
    partial class Search
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
            Display = new DataGridView();
            Search2 = new Button();
            Search1 = new TextBox();
            Criteria = new ComboBox();
            borrow = new Button();
            Return = new Button();
            Id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            AvailableCopies = new DataGridViewTextBoxColumn();
            TotalCopies = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Display).BeginInit();
            SuspendLayout();
            // 
            // Display
            // 
            Display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Display.Columns.AddRange(new DataGridViewColumn[] { Id, Type, Title, Author, Genre, AvailableCopies, TotalCopies });
            Display.Location = new Point(2, 70);
            Display.Name = "Display";
            Display.Size = new Size(757, 241);
            Display.TabIndex = 0;
            // 
            // Search2
            // 
            Search2.Location = new Point(155, 41);
            Search2.Name = "Search2";
            Search2.Size = new Size(75, 23);
            Search2.TabIndex = 1;
            Search2.Text = "Search";
            Search2.UseVisualStyleBackColor = true;
            Search2.Click += Search2_Click;
            // 
            // Search1
            // 
            Search1.Location = new Point(12, 12);
            Search1.Name = "Search1";
            Search1.Size = new Size(100, 23);
            Search1.TabIndex = 2;
            // 
            // Criteria
            // 
            Criteria.FormattingEnabled = true;
            Criteria.Location = new Point(12, 41);
            Criteria.Name = "Criteria";
            Criteria.Size = new Size(121, 23);
            Criteria.TabIndex = 3;
            // 
            // borrow
            // 
            borrow.Location = new Point(60, 333);
            borrow.Name = "borrow";
            borrow.Size = new Size(75, 23);
            borrow.TabIndex = 4;
            borrow.Text = "borrow";
            borrow.UseVisualStyleBackColor = true;
            borrow.Click += borrow_Click;
            // 
            // Return
            // 
            Return.Location = new Point(159, 338);
            Return.Name = "Return";
            Return.Size = new Size(75, 23);
            Return.TabIndex = 5;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // Author
            // 
            Author.HeaderText = "Author/Publisher";
            Author.Name = "Author";
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre/Category";
            Genre.Name = "Genre";
            // 
            // AvailableCopies
            // 
            AvailableCopies.HeaderText = "Available Copies";
            AvailableCopies.Name = "AvailableCopies";
            // 
            // TotalCopies
            // 
            TotalCopies.HeaderText = "TotalCopies";
            TotalCopies.Name = "TotalCopies";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Return);
            Controls.Add(borrow);
            Controls.Add(Criteria);
            Controls.Add(Search1);
            Controls.Add(Search2);
            Controls.Add(Display);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)Display).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Display;
        private Button Search2;
        private TextBox Search1;
        private ComboBox Criteria;
        private Button borrow;
        private Button Return;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn AvailableCopies;
        private DataGridViewTextBoxColumn TotalCopies;
    }
}