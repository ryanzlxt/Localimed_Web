namespace Localimed.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	//Redireciona até a tela de inserir medicamentos da nossa view
	private async void OnInserirMedicamentosClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///InserirMedicamentos");
	}

    //Redireciona até a tela de remover medicamentos da nossa view
    private async void OnRemoverMedicamentosClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///RemoverMedicamentos");
	}

	private async void OnVisualizarEstoqueClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///VisualizarEstoque");
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }
}