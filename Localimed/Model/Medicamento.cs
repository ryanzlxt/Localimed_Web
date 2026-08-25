namespace Localimed.Model;

public class Medicamento
{
    public string IdMedicamento { get; set; } = Guid.NewGuid().ToString();
    public string NomeMedicamento { get; set; } = string.Empty;
    public float DosagemMedicamento { get; set; }
    public int QuantidadeMedicamento { get; set; }
    public int NumeroLoteMedicamento { get; set; }
    public DateTime DataMedicamento { get; set; } = DateTime.Today;
    public string TipoMedicamento { get; set; } = string.Empty;
    public bool ExigeTermo { get; set; }

    public string ExigeTermoTexto => ExigeTermo ? "Sim" : "Não";
}
