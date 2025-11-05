using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Localimed.Views;


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

        //Permitindo que INotifyPropertyChanged seja utilizado no projeto
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
