using ShadowLines.Models;
using ShadowLines.Views;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace ShadowLines.ViewModels
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string _username;
        private string _passwordID;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string PasswordID
        {
            get => _passwordID;
            set { _passwordID = value; OnPropertyChanged(nameof(PasswordID)); }
        }

        public ICommand LoginCommand { get; }

        private readonly Users _users = new Users();

        public LoginVM()
        {
            LoginCommand = new RelayCommand(ExecutarLogin, PodeExecutarLogin);
        }

        private bool PodeExecutarLogin(object parameter) =>
            !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(PasswordID);

        private void ExecutarLogin(object parameter)
        {
            int nivel = _users.AuthenticateUser(Username, PasswordID);

            switch (nivel)
            {
                case 1:
                    new Menu01().Show();
                    Application.Current.Windows[0]?.Hide();
                    break;
                case 2:
                    new Menu02().Show();
                    Application.Current.Windows[0]?.Hide();
                    break;
                case 3:
                    new Menu03().Show();
                    Application.Current.Windows[0]?.Hide();
                    break;
                default:
                    MessageBox.Show("Usuário ou senha inválidos!");
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
