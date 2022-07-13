namespace DevCarConsole.Models;

public class MotoTriciclo : Veiculo
{
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

    public override string ListarInformacoes()
    {
        Console.ForegroundColor = ConsoleColor.White;
        
        return $@"Veículo: {Nome?.ToUpper()} | Cor: {char.ToUpper(Cor![0]) + Cor.Substring(1)} | Placa: {Placa?.ToUpper()} | Valor: {Valor.ToString("c")}
Data Fabricação: {DataFabricacao.ToString("d")} | Chassi: {NumChassi?.ToUpper()} | Potencia: {Potencia}cv | Quantidade de rodas: {QuantidadeRodas}";
    }

}