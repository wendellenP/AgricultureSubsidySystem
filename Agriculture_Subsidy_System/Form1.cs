using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Agriculture_Subsidy_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogInLink.Cursor = Cursors.Hand;
            signUpBtn.Cursor = Cursors.Hand;
            BirthDatePicker.Cursor = Cursors.Hand;

            openEye1.Hide();
            openEye1.Cursor = Cursors.Hand;
            closeEye1.Cursor = Cursors.Hand;

            openEye2.Hide();
            openEye2.Cursor = Cursors.Hand;
            closeEye2.Cursor = Cursors.Hand;

            LogInLink.MouseEnter += LogInLink_MouseEnter;
            LogInLink.MouseLeave += LogInLink_MouseLeave;
        }

        private void LogInLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInForm login = new logInForm(this);
            login.ShowDialog(); // Show the login form as a modal dialog
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                closeEye1.Cursor = Cursors.Hand;
                closeEye1.Show();
            }
        }

        private void closeEye1_Click(object sender, EventArgs e)
        {
            HidePassword(closeEye1,openEye1,passwordTxt);
        }

        private void openEye1_Click(object sender, EventArgs e)
        {
            ShowPassword(closeEye1,openEye1,passwordTxt);
        }

        private void passwordConfirmTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordConfirmTxt.Text))
            {
                closeEye2.Cursor = Cursors.Hand;
                closeEye2.Show();
            }
        }

        private void closeEye2_Click(object sender, EventArgs e)
        {
            HidePassword(closeEye2,openEye2,passwordConfirmTxt);
        }

        private void openEye2_Click(object sender, EventArgs e)
        {
            ShowPassword(closeEye2 ,openEye2,passwordConfirmTxt);
        }

        public void HidePassword(PictureBox hideEye, PictureBox showEye, Guna2TextBox password)
        {
            if (password.PasswordChar == '•' && password.Text != "")
            {
                password.PasswordChar = '\0'; // Unmask
                showEye.Show();
            }
            else
            {
                password.PasswordChar = '•';
                hideEye.Show();
            }
        }

        public void ShowPassword(PictureBox showEye, PictureBox hideEye, Guna2TextBox password)
        {
            if (password.PasswordChar == '\0')
            {
                password.PasswordChar = '•';
                hideEye.Hide();
            }
            else
            {
                showEye.Show();
            }
        }

        private void LogInLink_MouseEnter(object sender, EventArgs e)
        {
            LogInLink.ForeColor = Color.OliveDrab;
        }

        private void LogInLink_MouseLeave(object sender, EventArgs e)
        {
            LogInLink.ForeColor = Color.Green;
        }
    }
}
