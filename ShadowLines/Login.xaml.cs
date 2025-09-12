using System;
using System.Windows;
using ShadowLines.Classes;
using ShadowLines.Menus;


namespace ShadowLines
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNome.Text;
            int id = int.Parse(txtID.Text);

            if (Users.Authenticate01(name, id))
            {
                Menu01 tela = new Menu01();
                tela.Show();
                this.Hide();s
            }
            else if (Users.Authenticate02(name, id))
            {
                Menu02 tela = new Menu02();
                tela.Show();
                this.Hide();
            }
            else if (Users.Autenticate03(name, id))
            { 
                Menu03 tela = new Menu03();
                tela.Show();
                this.Hide();
            }
        }
    }
}
