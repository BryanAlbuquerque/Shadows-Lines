using ShadowLines.Models;
using ShadowLines.Views;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

public class LoginVM : INotifyPropertyChanged
{
    private string _name;
    private string _id;

    public string Name
    {
        get => _name;
        set { _name = value; OnPropertyChanged(nameof(Name)); }
    }

    public string Id  
    {
        get => _id;
        set { _id = value; OnPropertyChanged(nameof(Id)); }
    }

    public ICommand LoginCommand { get; }

    public LoginVM()
    {
        LoginCommand = new RelayCommand(ExecutarLogin, PodeExecutarLogin);
    }

    private bool PodeExecutarLogin(object parameter) =>
        !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Id);

    private void ExecutarLogin(object parameter)
    {
        if (!int.TryParse(Id, out int id))
        {
            MessageBox.Show("Erro: ID inválido!");
            return;
        }

        int nivel = Users.Authenticate(Name, id);

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
