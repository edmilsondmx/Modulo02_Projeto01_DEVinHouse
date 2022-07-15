namespace DevCarConsole.Models;

public class Caminhonete : Veiculo
{
    public string? TotalPortas { get; set; }
    public string? CapacidadeCacamba { get; set; }
    public string? Combustivel { get; set; }
    public Caminhonete()
    {
    }

    public Caminhonete(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? potencia, string? totalPortas, string? capacidadeCacamba,  string? combustivel) : base(dataFabricacao, nome, placa, valor, potencia)
    {
        Categoria = "Caminhonete";
        Cor = "Roxa";
        TotalPortas = totalPortas;
        CapacidadeCacamba = capacidadeCacamba;
        Combustivel = combustivel;
    }

    public override void AlterarInformacoes(decimal valor, string? cor)
    {
        if(cor?.ToLower() == "roxa" || cor == null)
        {
            Cor = "Roxa";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine(@"Fabricamos apenas caminhonetes 
    na cor Roxa");
        }
        Valor = valor;
    }

    public override string ListarInformacoes()
    {
        Console.ForegroundColor = ConsoleColor.White;

        return $@"Veículo: {Nome?.ToUpper()} | Cor: {char.ToUpper(Cor![0]) + Cor.Substring(1)} | Placa: {Placa?.ToUpper()} | Valor: {Valor.ToString("c")} | Data Fabricação: {DataFabricacao.ToString("d")} 
Chassi: {NumChassi?.ToUpper()} | Potencia: {Potencia}cv | Quantidade de Portas: {TotalPortas} | Litragem Caçamba: {CapacidadeCacamba}lt | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)}";
    }
}