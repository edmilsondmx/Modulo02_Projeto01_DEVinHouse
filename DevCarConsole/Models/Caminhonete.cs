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
        return $@"{base.ListarInformacoes()}
Quantidade de Portas: {TotalPortas} | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)} | Capacidade Caçamba: {CapacidadeCacamba}lt";;
    }
}