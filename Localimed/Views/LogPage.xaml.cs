namespace Localimed.Views;

public partial class LogPage : ContentPage
{
	public LogPage()
	{
		InitializeComponent();
	}

    private async void OnContinuarClicked(object sender, EventArgs e) //Conexão das páginas assim que o botão Continuar for clicado, redirecionando o usuário para a HomePage.xamlW
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}