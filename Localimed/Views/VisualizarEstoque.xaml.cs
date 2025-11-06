using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Localimed.ModelView;

namespace Localimed.Views;

public partial class VisualizarEstoque : ContentPage
{


    public VisualizarEstoque()
    {
        InitializeComponent();
        BindingContext = new VisualizarEstoqueViewModel();
    }
}

