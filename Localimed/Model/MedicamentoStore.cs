using System.Collections.ObjectModel;

namespace Localimed.Model;

public sealed class MedicamentoStore
{
    private static readonly Lazy<MedicamentoStore> _instance =
        new(() => new MedicamentoStore());

    public static MedicamentoStore Instance => _instance.Value;

    public ObservableCollection<Medicamento> Medicamentos { get; }

    private MedicamentoStore()
    {
        Medicamentos = new ObservableCollection<Medicamento>
        {
            new()
            {
                NomeMedicamento = "ALBENDAZOL 40 MG/ML - SUSPENSAO - FRASCO C/ 10 ML",
                QuantidadeMedicamento = 10,
                NumeroLoteMedicamento = 1001,
                TipoMedicamento = "Asma",
                ExigeTermo = false
            },
            new()
            {
                NomeMedicamento = "AMITRIPTILINA, CLORIDRATO 25 MG - COMPRIMIDO",
                QuantidadeMedicamento = 525,
                NumeroLoteMedicamento = 1002,
                TipoMedicamento = "Depressão",
                ExigeTermo = false
            },
            new()
            {
                NomeMedicamento = "CARBAMAZEPINA 100 MG/5 ML - SUSPENSAO ORAL - FRASCO C/ 100 ML",
                QuantidadeMedicamento = 31,
                NumeroLoteMedicamento = 1003,
                TipoMedicamento = "Neurológico",
                ExigeTermo = false
            },
            new()
            {
                NomeMedicamento = "DIAZEPAM 5 MG - COMPRIMIDO",
                QuantidadeMedicamento = 210,
                NumeroLoteMedicamento = 1004,
                TipoMedicamento = "Controlado",
                ExigeTermo = true
            },
            new()
            {
                NomeMedicamento = "DIPIRONA 500 MG - COMPRIMIDO",
                QuantidadeMedicamento = 10,
                NumeroLoteMedicamento = 1005,
                TipoMedicamento = "Dor",
                ExigeTermo = false
            },
            new()
            {
                NomeMedicamento = "FENITOINA 100 MG - COMPRIMIDO",
                QuantidadeMedicamento = 1887,
                NumeroLoteMedicamento = 1006,
                TipoMedicamento = "Controlado",
                ExigeTermo = true
            },
            new()
            {
                NomeMedicamento = "IBUPROFENO 300 MG - COMPRIMIDO",
                QuantidadeMedicamento = 51,
                NumeroLoteMedicamento = 1007,
                TipoMedicamento = "Dor",
                ExigeTermo = false
            }
        };
    }

    public void Add(Medicamento medicamento) => Medicamentos.Add(medicamento);

    public void Remove(Medicamento medicamento)
    {
        if (Medicamentos.Contains(medicamento))
            Medicamentos.Remove(medicamento);
    }
}
