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
        Console.ForegroundColor = ConsoleColor.White;
        
        return $@"Veículo: {Nome?.ToUpper()} | Cor: {char.ToUpper(Cor![0]) + Cor.Substring(1)} | Placa: {Placa?.ToUpper()} | Valor: {Valor.ToString("c")} | Data Fabricação: {DataFabricacao.ToString("d")} 
Chassi: {NumChassi?.ToUpper()} | Potencia: {Potencia}cv | Quantidade de Portas: {TotalPortas} | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)}";
    }
}