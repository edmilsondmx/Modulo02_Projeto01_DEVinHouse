namespace DevCarConsole.Models;

public class Caminhonete : Veiculo
{
    public string? TotalPortas { get; set; }
    public string? CapacidadeCacamba { get; set; } // Em Litros
    public string? Potencia { get; set; } //Cavalos
    public string? Combustivel { get; set; }//Gasolina ou Disel
    public Caminhonete()
    {
    }

    public Caminhonete(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? totalPortas, string? capacidadeCacamba, string? potencia, string? combustivel) : base(dataFabricacao, nome, placa, valor)
    {
        Categoria = "Caminhonete";
        Cor = "Roxa";
        TotalPortas = totalPortas;
        CapacidadeCacamba = capacidadeCacamba;
        Potencia = potencia;
        Combustivel = combustivel;
    }

    public override void AlterarInformacoes(decimal valor, string? cor)
    {
        if(cor != "roxo")
            System.Console.WriteLine("Fabricamos apenas caminhonetes na cor Roxa");
        Cor = "Roxo";
        Valor = valor;
    }

    public override string ListarInformacoes()
    {
        Console.ForegroundColor = ConsoleColor.White;

        return $@"Veículo: {Nome?.ToUpper()} | Cor: {char.ToUpper(Cor![0]) + Cor.Substring(1)} | Placa: {Placa?.ToUpper()} | Valor: {Valor.ToString("c")} | Data Fabricação: {DataFabricacao.ToString("d")} 
Chassi: {NumChassi?.ToUpper()} | Potencia: {Potencia}cv | Quantidade de Portas: {TotalPortas} | Litragem Caçamba: {CapacidadeCacamba}lt | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)}";
    }
}