using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Localimed.Views;

namespace Localimed.ModelView
{
    public class VisualizarEstoqueViewModel : INotifyPropertyChanged
    {


        /*
        ========================================
            LÓGICA PARA OS BOTÕES
        ========================================
        */
        public ICommand BotaoInserirMedicamentos { get; }
        public ICommand BotaoRemoverMedicamento { get; }
        public ICommand BotaoVisualizarEstoque { get; }
        public VisualizarEstoqueViewModel()
        {
            BotaoInserirMedicamentos = new Command(OnBotaoInserirMedicamentosClicked);
            BotaoRemoverMedicamento = new Command(OnBotaoRemoverMedicamentosClicked);
          

        }

        public async void OnBotaoInserirMedicamentosClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.InserirMedicamentos());
        }

        public async void OnBotaoRemoverMedicamentosClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.RemoverMedicamentos());
        }



        //Permitindo que INotifyPropertyChanged seja utilizado no projeto
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
