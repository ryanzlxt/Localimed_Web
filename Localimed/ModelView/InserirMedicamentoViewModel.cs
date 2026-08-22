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

        private string _numeroLote;
        private string _nomeMedicamento;
        private string _quantidadeMedicamento;
        private string _tipoMedicamento;
        private DateTime _dataMedicamento;


        public DateTime DataMedicamento
        {
            get => _dataMedicamento;
            set
            {
                if (_dataMedicamento != value)
                {
                    _dataMedicamento = value;
                    OnPropertyChanged(nameof(DataMedicamento));
                }
            }
        }

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

        public string NumeroLote
        {
            get => _numeroLote;
            set
            {
                if (_numeroLote != value)
                {
                    _numeroLote = value;
                    OnPropertyChanged(nameof(NumeroLote));
                }
            }
        }

        public string QuantidadeMedicamento
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
            set
            {
                if (_tipoMedicamento != value)
                {
                    _tipoMedicamento = value;
                    OnPropertyChanged(nameof(TipoMedicamento));
                }
            }
        }

        public ICommand BotaoConfirmar { get; }
        public ICommand BotaoVoltar { get; }

        public InserirMedicamentoViewModel()
        {
            DataMedicamento = DateTime.Today;
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


            if (!int.TryParse(QuantidadeMedicamento, out int quantidade))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Digite apenas números na quantidade.",
                    "OK");

                return;
            }

            if (quantidade <= 0)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "A quantidade de medicamentos não pode ser menor ou igual a 0.",
                    "OK");

                return;
            }

            if (string.IsNullOrWhiteSpace(TipoMedicamento))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Selecione um tipo de medicamento.",
                    "OK");

                return;
            }

            if (string.IsNullOrWhiteSpace(NomeMedicamento))
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Erro",
                   "O Nome do Medicamento está vazio!",
                   "Ok");

                return;
            }

            if (!int.TryParse(NumeroLote, out _))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "O número do lote deve conter apenas números.",
                    "OK");

                return;
            }

            if (DataMedicamento == default)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Selecione uma data.",
                    "OK");

                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                 "Cadastro Realizado",
                 $"Medicamento '{NomeMedicamento}' cadastrado com sucesso.\n\n" +
                 $"Quantidade: {QuantidadeMedicamento}\n" +
                 $"Lote: {NumeroLote}\n" +
                 $"Tipo: {TipoMedicamento}",
                 "OK");
                NomeMedicamento = string.Empty;
                QuantidadeMedicamento = string.Empty;
                NumeroLote = string.Empty;
                TipoMedicamento = string.Empty;
                DataMedicamento = DateTime.Today;
        }


        public async void OnBotaoVoltarClicked()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }


        //Permitindo que INotifyPropertyChanged seja utilizado no projeto
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

