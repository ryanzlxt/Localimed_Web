namespace Localimed.Views;

public partial class LogPage : ContentPage
{
	public LogPage()
	{
		InitializeComponent();
	}

    private async void OnContinuarClicked(object sender, EventArgs e) //Conex�o das p�ginas assim que o bot�o Continuar for clicado, redirecionando o usu�rio para a HomePage.xamlW
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}