namespace DevCarConsole.Models;

public class Veiculo
{
    public string? Categoria { get; set; }
    private protected string NumChassi = Guid.NewGuid().ToString().Substring(0,18);
    public DateTime DataFabricacao { get; set; }
    public string? Nome { get; set; }
    public string? Placa { get; set; }
    public decimal Valor { get; set; }
    public string? CpfComprador = null;
    public string? Cor { get; set; }
    public decimal ValorVenda = 0;

    public Veiculo()
    {
    }

    public Veiculo(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor)
    {
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
        Cor = cor;
    }
    public Veiculo(DateTime dataFabricacao, string? nome, string? placa, decimal valor)
    {
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
    }

    public void VenderVeículo(string cpfComprador, decimal valorVenda)
    {
        CpfComprador = cpfComprador;
        ValorVenda = valorVenda;
    }

    public virtual string ListarInformacoes()
    {
        return "";
    }
    public virtual void AlterarInformacoes(decimal valor, string? cor)
    {
        Valor = valor;
        Cor = cor;
    }
    
}