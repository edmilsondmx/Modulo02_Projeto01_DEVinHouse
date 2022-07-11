namespace DevCarConsole.Models;

public class MotoTriciclo : Veiculo
{
    public string? Categoria { get; set; }
    public string? Potencia { get; set; }
    public string? QuantidadeRodas { get; set; }
    public MotoTriciclo()
    {
    }

    public MotoTriciclo(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor, string? potencia, string? qtdRodas) : base(dataFabricacao, nome, placa, valor, cor)
    {
        Categoria = "Moto / Triciclo";
        Potencia = potencia;
        QuantidadeRodas = qtdRodas;
    }
}