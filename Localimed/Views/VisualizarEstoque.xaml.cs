using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Localimed.Views;

public partial class VisualizarEstoque : ContentPage
{
    public ObservableCollection<Medicine> Medicines { get; set; }

    public VisualizarEstoque()
    {
        InitializeComponent();

        Medicines = new ObservableCollection<Medicine>
        {
            new Medicine { Name = "ALBENDAZOL 40 MG/ML - SUSPENSAO - FRASCO C/ 10 ML", Quantity = 10, RequiresTerm = " " },
            new Medicine { Name = "AMITRIPTILINA, CLORIDRATO 25 MG - COMPRIMIDO", Quantity = 525, RequiresTerm = " " },
            new Medicine { Name = "CARBAMAZEPINA 100 MG/5 ML - SUSPENSAO ORAL - FRASCO C/ 100 ML", Quantity = 31, RequiresTerm = " " },
            new Medicine { Name = "DIAZEPAM 5 MG - COMPRIMIDO", Quantity = 210, RequiresTerm = " " },
            new Medicine { Name = "DIPIRONA 500 MG - COMPRIMIDO", Quantity = 10, RequiresTerm = " " },
            new Medicine { Name = "FENITOINA 100 MG - COMPRIMIDO", Quantity = 1887, RequiresTerm = " " },
            new Medicine { Name = "IBUPROFENO 300 MG - COMPRIMIDO", Quantity = 51, RequiresTerm = " " }
        };

        BindingContext = this;
    }
}

public class Medicine
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string RequiresTerm { get; set; }
}