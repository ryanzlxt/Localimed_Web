using Localimed.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Localimed.ModelView;

public class VisualizarEstoqueViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Medicamento> Medicamentos =>
        MedicamentoStore.Instance.Medicamentos;

    public ICommand BotaoInserirMedicamentos { get; }
    public ICommand BotaoRemoverMedicamento { get; }
    public ICommand BotaoVoltar { get; }

    public VisualizarEstoqueViewModel()
    {
        Medicamentos.CollectionChanged += (_, _) => OnPropertyChanged(nameof(Medicamentos));

        BotaoInserirMedicamentos = new Command(async () =>
            await Application.Current!.MainPage!.Navigation.PushAsync(
                new Localimed.Views.InserirMedicamentos()));

        BotaoRemoverMedicamento = new Command(async () =>
            await Application.Current!.MainPage!.Navigation.PushAsync(
                new Localimed.Views.RemoverMedicamentos()));

        BotaoVoltar = new Command(async () =>
        {
            if (Application.Current!.MainPage!.Navigation.NavigationStack.Count > 1)
                await Application.Current!.MainPage!.Navigation.PopAsync();
        });
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
