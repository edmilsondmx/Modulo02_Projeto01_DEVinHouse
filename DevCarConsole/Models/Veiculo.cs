namespace DevCarConsole.Models;

public class Veiculo
{
    public string? NumChassi { get; set; }
    public DateTime DataFabricacao { get; set; }
    public string? Nome { get; set; }
    public string? Placa { get; set; }
    public decimal Valor { get; set; }
    public string? CpfComprador { get; set; }
    public string? Cor { get; set; }

    public Veiculo()
    {
    }

    public Veiculo(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor)
    {
        NumChassi = Guid.NewGuid().ToString().Substring(0,18);
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
        CpfComprador = "0";
        Cor = cor;
    }

    public void VenderVeículo(string? cpfComprador, decimal valor)
    {
        CpfComprador = cpfComprador;
        Valor = valor;
    }

    public void ListarInformacoes()
    {

    }
    public void AlterarInformacoes(decimal valor, string? cor)
    {
        Valor = valor;
        Cor = cor;
    }
    
}