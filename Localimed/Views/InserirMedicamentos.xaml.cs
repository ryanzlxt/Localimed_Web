using Localimed.ModelView;

namespace Localimed.Views;

public partial class InserirMedicamentos : ContentPage
{
    public InserirMedicamentos()
    {
        InitializeComponent();
        BindingContext = new InserirMedicamentoViewModel();

        tipoMedicamentoPicker.ItemsSource = new[]
        {
            "Asma",
            "Diabetes",
            "Hipertensão",
            "Osteoporose",
            "Glaucoma",
            "Dor",
            "Neurológico",
            "Depressão",
            "Controlado"
        };
    }
}
