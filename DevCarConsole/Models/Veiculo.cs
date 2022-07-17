namespace DevCarConsole.Models;

public class Veiculo
{
    public string? Categoria { get; set; }
    private protected string NumChassi = Guid.NewGuid().ToString().Substring(0,20);
    public DateTime DataFabricacao { get; private set; }
    public string Nome { get; private set; }
    public string Placa { get; private set; }
    public decimal Valor { get; set; }
    public string CpfComprador { get; set; } = null!;
    public string? Cor { get; set; }
    public decimal ValorVenda = 0;

    public DateTime DataVenda { get; private set; }


    public Veiculo(DateTime dataFabricacao, string nome, string placa, decimal valor, string cor)
    {
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
        Cor = cor;
    }
    public Veiculo(DateTime dataFabricacao, string nome, string placa, decimal valor)
    {
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
    }

    public void VenderVeiculo(string cpfComprador, decimal valorVenda)
    {
        DataVenda = DateTime.Now;
        CpfComprador = cpfComprador;
        ValorVenda = valorVenda;
    }

    public virtual void AlterarInformacoes(decimal valor, string cor)
    {
        Valor = valor;
        Cor = cor;
    }

    public virtual string ListarInformacoes()
    {
        Console.ForegroundColor = ConsoleColor.White;

        return $@"Veículo: {Nome.ToUpper()} | Cor: {char.ToUpper(Cor![0]) + Cor.Substring(1)} | Placa: {Placa.ToUpper()} | Valor Estoque: {Valor.ToString("c")}
Data Fabricação: {DataFabricacao.ToString("d")} | Chassi: {NumChassi.ToUpper()}";
    }
       
}