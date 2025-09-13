using System;
using System.Windows;


namespace ShadowLines.Menus
{
    public partial class Menu03 : Window
    {
        public Menu03()
        {
            InitializeComponent();
            DataContext = new Menu03ViewModel();
        }
    }
}
