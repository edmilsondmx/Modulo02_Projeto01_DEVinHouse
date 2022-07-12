namespace DevCarConsole.Models;

public class Veiculo
{
    private protected string? NumChassi { get; set; }
    public DateTime DataFabricacao { get; set; }
    public string? Nome { get; set; }
    public string? Placa { get; set; }
    public decimal Valor { get; set; }
    private protected int? CpfComprador { get; set; }
    public string? Cor { get; set; }
    public decimal ValorVenda { get; set; }

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
        Cor = cor;
    }
    public Veiculo(DateTime dataFabricacao, string? nome, string? placa, decimal valor)
    {
        NumChassi = Guid.NewGuid().ToString().Substring(0,18);
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
    }

    public void VenderVeículo(int cpfComprador, decimal valorVenda)
    {
        CpfComprador = cpfComprador;
        ValorVenda = valorVenda;
    }

    public string ListarInformacoes()
    {
        return "";
    }
    public virtual void AlterarInformacoes(decimal valor, string? cor)
    {
        Valor = valor;
        Cor = cor;
    }
    
}