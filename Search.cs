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
    public partial class Search : Form
    {
        private Library library;
        public Search()
        {
            InitializeComponent();
            library = new Library();

            Criteria.Items.AddRange(new[] { "Title", "Author/Publisher", "Genre/Category", "Id" });
            Criteria.SelectedIndex = 0; 
        }


        private void Search2_Click(object sender, EventArgs e)
        {
            string criteria = Criteria.SelectedItem.ToString();
            string searchTerm = Search1.Text.Trim();

         
            var results = library.SearchBooks(criteria, searchTerm); 

      
            Display.Rows.Clear();
            foreach (var item in results)
            {
                if (item is Book book)
                {
                    Display.Rows.Add(book.Id, book.Type, book.Title, book.Author, book.Genre, book.AvailableCopies, book.TotalCopies);
                }
                else if (item is Magazine magazine)
                {
                    Display.Rows.Add(magazine.Id, magazine.Type, magazine.Title, magazine.Publisher, magazine.Category, magazine.AvailableCopies, magazine.TotalCopies);
                }
            }

            if (!results.Any())
            {
                MessageBox.Show("No results found.");
            }
        }



        private void borrow_Click(object sender, EventArgs e)
        {
            if (Display.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(Display.SelectedRows[0].Cells[0].Value);

               
                var item = library.GetItemById(itemId);

                if (item == null)
                {
                    MessageBox.Show("Item not found.");
                    return;
                }

  
                var currentMember = Member.LoggedInMember; 
                if (currentMember == null)
                {
                    MessageBox.Show("Please log in first.");
                    return;
                }

                if (currentMember.BorrowItem(item)) 
                {
                    Search2_Click(sender, e); 
                }
                else
                {
                    MessageBox.Show("Unable to borrow item ");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to borrow.");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            if (Display.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(Display.SelectedRows[0].Cells[0].Value);


                var item = library.GetItemById(itemId);

                if (item == null)
                {
                    MessageBox.Show("Item not found.");
                    return;
                }

                var currentMember = Member.LoggedInMember; 
                if (currentMember == null)
                {
                    MessageBox.Show("Please log in first");
                    return;
                }

                if (currentMember.ReturnItem(item)) 
                {
                    MessageBox.Show("Item returned successfully");
                    Search2_Click(sender, e); 
                }
                else
                {
                    MessageBox.Show("Unable to return the item Check the total copies");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to return.");
            }


        }

    }

}

