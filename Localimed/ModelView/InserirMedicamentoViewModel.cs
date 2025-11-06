using Localimed.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;



namespace Localimed.ModelView
{
    public class InserirMedicamentoViewModel : INotifyPropertyChanged
    {


        private string _nomeMedicamento;
        private int _quantidadeMedicamento;
        private string _tipoMedicamento;
        private DateTime _dataMedicamento;


        public string NomeMedicamento
        {
            get => _nomeMedicamento;
            set
            {
                if (_nomeMedicamento != value)
                {
                    _nomeMedicamento = value;
                    OnPropertyChanged(nameof(NomeMedicamento));
                }
            }
        }

        public int QuantidadeMedicamento
        {
            get => _quantidadeMedicamento;
            set
            {
                if (_quantidadeMedicamento != value)
                {
                    _quantidadeMedicamento = value;
                    OnPropertyChanged(nameof(QuantidadeMedicamento));
                }

            }
        }

        public string TipoMedicamento
        {

            get => _tipoMedicamento;
        }

        public ICommand BotaoConfirmar { get; }
        public ICommand BotaoVoltar { get; }

        public InserirMedicamentoViewModel()
        {

            BotaoConfirmar = new Command(async () => OnConfirmarClicked());
            BotaoVoltar = new Command(OnBotaoVoltarClicked);

            /* 
             
                async () => await OnVoltarClicked() cria uma função anônima que chama o método assíncrono OnVoltarClicked
                quando o comando é executado.

                Isso é necessário porque o Command não suporta diretamente métodos async Task. 
                Ele espera um método void ou uma função anônima.
             */

        }

        public async Task OnConfirmarClicked()
        {


            if (_quantidadeMedicamento <= 0)
            {
                Application.Current.MainPage.DisplayAlert("Erro",
                   "A quantidade de medicamentos não pode ser menor ou 0!",
                   "Ok");

                return;
            }

            if (string.IsNullOrWhiteSpace(NomeMedicamento))
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Erro",
                   "O Nome do Medicamento está vazio!",
                   "Ok"
                   );
                return;
            }
        }
        public async void OnBotaoVoltarClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.HomePage());
        }


        //Permitindo que INotifyPropertyChanged seja utilizado no projeto
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

