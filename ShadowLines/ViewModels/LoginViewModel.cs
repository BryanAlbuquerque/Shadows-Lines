using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using ShadowLines.Classes;
using ShadowLines.Menus;

namespace ShadowLines.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string name;
        private string idText;

        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string IdText
        {
            get => idText;
            set { idText = value; OnPropertyChanged(nameof(IdText)); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(ExecutarLogin);
        }

        private void ExecutarLogin(object parameter)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(IdText))
            {
                MessageBox.Show("Erro: existem campos em branco!");
                return;
            }

            if (!int.TryParse(IdText, out int id))
            {
                MessageBox.Show("Erro: ID inválido!");
                return;
            }

            if (Users.Authenticate01(Name, id))
            {
                new Menu01().Show();
                Application.Current.Windows[0]?.Hide();
            }
            else if (Users.Authenticate02(Name, id))
            {
                new Menu02().Show();
                Application.Current.Windows[0]?.Hide();
            }
            else if (Users.Autenticate03(Name, id))
            {
                new Menu03().Show();
                Application.Current.Windows[0]?.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
