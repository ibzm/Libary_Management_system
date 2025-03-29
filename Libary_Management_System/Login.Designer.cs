namespace Library_Management_System
{
    partial class Login
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
            Password = new TextBox();
            Username = new TextBox();
            Confirm = new Button();
            SuspendLayout();
            // 
            // Password
            // 
            Password.Location = new Point(12, 102);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 0;
            // 
            // Username
            // 
            Username.Location = new Point(12, 56);
            Username.Name = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 1;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(26, 145);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(75, 23);
            Confirm.TabIndex = 2;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Confirm);
            Controls.Add(Username);
            Controls.Add(Password);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Password;
        private TextBox Username;
        private Button Confirm;
    }
}