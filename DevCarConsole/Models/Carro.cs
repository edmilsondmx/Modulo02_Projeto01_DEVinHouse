namespace DevCarConsole.Models;

public class Carro : Veiculo
{
    public string Potencia { get; private set; }
    public string TotalPortas { get; private set; }
    public string Combustivel { get; private set; }

    public Carro(DateTime dataFabricacao, string nome, string placa, decimal valor, string cor, string potencia, string totalPortas, string combustivel) : base(dataFabricacao, nome, placa, valor, cor)
    {
        Categoria = "Carro Passeio";
        Potencia = potencia;
        TotalPortas = totalPortas;
        Combustivel = combustivel;
    }

    public override string ListarInformacoes()
    {
        return $@"{base.ListarInformacoes()} | Potencia: {Potencia}cv
Quantidade de Portas: {TotalPortas} | Combustível: {char.ToUpper(Combustivel![0]) + Combustivel.Substring(1)}";
    }
}