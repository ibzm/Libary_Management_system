namespace Library_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            searchToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Available_copies = new DataGridViewTextBoxColumn();
            Total_Copies = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            Delete = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { searchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Type, Title, Author, Genre, Available_copies, Total_Copies });
            dataGridView1.Location = new Point(0, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(788, 209);
            dataGridView1.TabIndex = 2;
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
            // Available_copies
            // 
            Available_copies.HeaderText = "Available copies";
            Available_copies.Name = "Available_copies";
            // 
            // Total_Copies
            // 
            Total_Copies.HeaderText = "Total Copies";
            Total_Copies.Name = "Total_Copies";
            // 
            // button1
            // 
            button1.Location = new Point(549, 270);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(647, 270);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(468, 270);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Delete);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem searchToolStripMenuItem;
        private Button Delete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Available_copies;
        private DataGridViewTextBoxColumn Total_Copies;
    }
}
