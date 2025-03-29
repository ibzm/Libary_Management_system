namespace Library_Management_System
{
    using System;
    using System.Windows.Forms;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && args[0].ToLower() == "librarian")
            {
                Application.Run(new Form1());
            }
            else if (args.Length > 0 && args[0].ToLower() == "member")
            {
         
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}

  
