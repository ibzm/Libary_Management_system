using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Members : Form
    {
        public Library library;
        public Members()
        {
            library = new Library();
            InitializeComponent();

            var items = library.Reading(); 
            dataGridView1.Rows.Clear(); 

            foreach (var item in items)
            {
                if (item is Book book)
                {
                  
                    dataGridView1.Rows.Add(
                        book.Id,
                        "Book",  
                        book.Title,
                        book.Author,
                        book.Genre,
                        book.AvailableCopies,
                        book.TotalCopies
                    );
                }
                else if (item is Magazine magazine)
                {
                   
                    dataGridView1.Rows.Add(
                        magazine.Id,
                        "Magazine",  
                        magazine.Title,
                        magazine.Publisher,
                        magazine.Category,
                        magazine.AvailableCopies,
                        magazine.TotalCopies
                    );
                }
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Show();
        }
    }
}
