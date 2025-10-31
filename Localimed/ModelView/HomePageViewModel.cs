using Localimed.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Localimed.ModelView
{
    public class HomePageViewModel : INotifyPropertyChanged
    {



        /*
        ========================================
            LÓGICA PARA OS BOTÕES
        ========================================
        */
        public ICommand BotaoInserirMedicamentos { get; }
        public ICommand BotaoRemoverMedicamento { get; }
        public ICommand BotaoVisualizarEstoque { get; }
        public HomePageViewModel()
        {
            BotaoInserirMedicamentos = new Command(OnBotaoInserirMedicamentosClicked);
            BotaoRemoverMedicamento = new Command(OnBotaoRemoverMedicamentosClicked);
            BotaoVisualizarEstoque = new Command(OnBotaoVisualizarEstoqueClicked);

        }

        public async void OnBotaoInserirMedicamentosClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.InserirMedicamentos());
        }

        public async void OnBotaoRemoverMedicamentosClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.RemoverMedicamentos());
        }

        public async void OnBotaoVisualizarEstoqueClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.VisualizarEstoque());
        }

      

        //Implementando a nossa INotifyPropertyChanged, principal método da biblioteca MVVM
        //Nos permite realizar conexões, sermos alertados de eventos e a manipulação dos mesmos!

        //public event PropertyChangedEventHandler: 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
