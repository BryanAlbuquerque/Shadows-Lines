using Shadows___Lines.Classes;
using System;
using System.Windows.Forms;

namespace Shadows___Lines
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passwordID = txtPasswordID.Text;

            Users users = new Users();
            if (users.AuthenticateUser(username, passwordID))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
