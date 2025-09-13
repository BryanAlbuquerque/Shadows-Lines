using ShadowLines.Classes;
using ShadowLines.Menus;
using ShadowLines.ViewModels;
using System;
using System.DirectoryServices.ActiveDirectory;
using System.Windows;


namespace ShadowLines
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
    }
}
