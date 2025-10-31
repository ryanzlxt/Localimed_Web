using System.Threading.Tasks;
using Localimed.ViewModel;

namespace Localimed.Views;

public partial class LogPage : ContentPage
{
	public LogPage()
	{
		InitializeComponent();

		//Realizando a conexão do BindingContext!!! Sem isso não roda nada!
		BindingContext = new LogPageViewModel();
	}

   
}