using System.Windows.Input;

namespace Localimed.ModelView;

public class HomePageViewModel
{
    public ICommand BotaoInserirMedicamentos { get; }
    public ICommand BotaoRemoverMedicamento { get; }
    public ICommand BotaoVisualizarEstoque { get; }

    public HomePageViewModel()
    {
        BotaoInserirMedicamentos = new Command(async () =>
            await Application.Current!.MainPage!.Navigation.PushAsync(
                new Localimed.Views.InserirMedicamentos()));

        BotaoRemoverMedicamento = new Command(async () =>
            await Application.Current!.MainPage!.Navigation.PushAsync(
                new Localimed.Views.RemoverMedicamentos()));

        BotaoVisualizarEstoque = new Command(async () =>
            await Application.Current!.MainPage!.Navigation.PushAsync(
                new Localimed.Views.VisualizarEstoque()));
    }
}
