using Localimed.ModelView;

namespace Localimed.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		BindingContext = new HomePageViewModel();
	}

	
}