using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_Management_System.Library;

namespace Library_Management_System
{
    
    public partial class Login : Form
    {
        private Library library;

        public Login()
        {
            InitializeComponent();
            library = new Library();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            bool isAuthenticated = library.Login(username, password);

            if (isAuthenticated)
            {
                var loggedInMember = Member.LoggedInMember; 
                MessageBox.Show($"Welcome, {loggedInMember.Username}!");


      
                this.Hide();
                new Members().Show();
            }
            else
            {
                MessageBox.Show("Invalid login details");
            }
        }

    }

}



