using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agriculture_Subsidy_System
{
    public partial class logInForm : Form
    {
        private readonly Form1 signupForm;
        public logInForm(Form1 form1)
        {
            InitializeComponent();
            signupLink.Cursor = Cursors.Hand;
            LoginBtn.Cursor = Cursors.Hand;

            HideEye1.Cursor = Cursors.Hand;
            openEye1.Cursor = Cursors.Hand;

            HideEye2.Cursor = Cursors.Hand;
            openEye2.Cursor = Cursors.Hand;

            openEye1.Hide();
            openEye2.Hide();

            signupForm = form1;

            signupLink.MouseEnter += signupLink_MouseEnter;
            signupLink.MouseLeave += signupLink_MouseLeave;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signup = new Form1();
            signup.Show(); // Show the login form as a modal dialog
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                HideEye1.Cursor = Cursors.Hand;
                HideEye1.Show();
            }
        }

        private void HideEye1_Click(object sender, EventArgs e)
        {
            signupForm.HidePassword(HideEye1, openEye1, passwordTxt);
        }

        private void openEye1_Click(object sender, EventArgs e)
        {
            signupForm.ShowPassword(HideEye1,openEye1, passwordTxt);
        }

        private void openEye2_Click(object sender, EventArgs e)
        {
            signupForm.ShowPassword(HideEye2, openEye2, passwordConfirmTxt);
        }

        private void HideEye2_Click(object sender, EventArgs e)
        {
            signupForm.HidePassword(HideEye2, openEye2, passwordConfirmTxt);
        }

        private void passwordConfirmTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                HideEye2.Cursor = Cursors.Hand;
                HideEye2.Show();
            }
        }

        private void signupLink_MouseEnter(object sender, EventArgs e)
        {
            signupLink.ForeColor = Color.OliveDrab;
        }

        private void signupLink_MouseLeave(object sender, EventArgs e)
        {
            signupLink.ForeColor = Color.Green;
    }
        }
}
