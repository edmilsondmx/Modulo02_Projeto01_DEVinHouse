namespace DevCarConsole.Models;

public class Carro : Veiculo
{
    public string? TotalPortas { get; set; }
    public string? Combustivel { get; set; }
    public Carro()
    {
    }

    public Carro(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor, string? potencia, string? totalPortas, string? combustivel) : base(dataFabricacao, nome, placa, valor, cor, potencia)
    {
        Categoria = "Carro Passeio";
        TotalPortas = totalPortas;
        Combustivel = combustivel;
    }

    public override string ListarInformacoes()
    {
        return $@"{base.ListarInformacoes()}
Quantidade de Portas: {TotalPortas} | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)}";
    }
}