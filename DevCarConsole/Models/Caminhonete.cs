namespace DevCarConsole.Models;

public class Caminhonete : Veiculo
{
    public string? Categoria { get; set; }
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
}