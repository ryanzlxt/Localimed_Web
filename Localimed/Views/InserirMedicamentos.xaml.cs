using Localimed.ModelView;

namespace Localimed.Views;

public partial class InserirMedicamentos : ContentPage
{
    public InserirMedicamentos()
    {
        InitializeComponent();
        BindingContext = new InserirMedicamentoViewModel();

        tipoMedicamentoPicker.Items.Add("Asma");
        tipoMedicamentoPicker.Items.Add("Diabetes");
        tipoMedicamentoPicker.Items.Add("Hipertensão");
        tipoMedicamentoPicker.Items.Add("Osteoporose");
        tipoMedicamentoPicker.Items.Add("Glaucoma");
    }
}