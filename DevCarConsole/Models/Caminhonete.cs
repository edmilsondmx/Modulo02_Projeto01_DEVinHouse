namespace DevCarConsole.Models;

public class Caminhonete : Veiculo
{
    public string Potencia { get; private set; }
    public string TotalPortas { get; private set; }
    public string CapacidadeCacamba { get; private set; }
    public string Combustivel { get; private set; }

    public Caminhonete(DateTime dataFabricacao, string nome, string placa, decimal valor, string potencia, string totalPortas, string capacidadeCacamba,  string combustivel) : base(dataFabricacao, nome, placa, valor)
    {
        Categoria = "Caminhonete";
        Cor = "Roxa";
        Potencia = potencia;
        TotalPortas = totalPortas;
        CapacidadeCacamba = capacidadeCacamba;
        Combustivel = combustivel;
        
    }

    public override void AlterarInformacoes(decimal valor, string cor)
    {
        if(cor == null || cor.ToLower() == "roxa")
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
        return $@"{base.ListarInformacoes()} | Potencia: {Potencia}cv
Quantidade de Portas: {TotalPortas} | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)} | Capacidade Caçamba: {CapacidadeCacamba}lt";;
    }
}