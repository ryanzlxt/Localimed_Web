using Localimed.ViewModel;

namespace Localimed.Views;

public partial class LogPage : ContentPage
{
    public LogPage()
    {
        InitializeComponent();
        BindingContext = new LogPageViewModel();
    }
}
