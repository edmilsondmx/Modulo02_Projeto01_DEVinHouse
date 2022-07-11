namespace DevCarConsole.Models;

public class Carro : Veiculo
{
    public string? Categoria { get; set; }
    public string? TotalPortas { get; set; }
    public string? Combustivel { get; set; }
    public string? Potencia { get; set; }
    public Carro()
    {
    }

    public Carro(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor,string? totalPortas, string? combustivel, string? potencia) : base(dataFabricacao, nome, placa, valor, cor)
    {
        Categoria = "Carro Passeio";
        TotalPortas = totalPortas;
        Combustivel = combustivel;
        Potencia = potencia;
    }
}