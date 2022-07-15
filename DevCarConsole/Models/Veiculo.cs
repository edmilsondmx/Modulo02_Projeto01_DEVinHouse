namespace DevCarConsole.Models;

public class Veiculo
{
    public string? Categoria { get; set; }
    private protected string NumChassi = Guid.NewGuid().ToString().Substring(0,18);//
    public DateTime DataFabricacao { get; set; }//
    public string? Nome { get; set; }//
    public string? Placa { get; set; }//
    public decimal Valor { get; set; }//
    public string? CpfComprador { get; set; }
    public string? Cor { get; set; }//
    public decimal ValorVenda = 0;
    public string? Potencia { get; set; }//

    public DateTime DataVenda { get; set; }

    public Veiculo()
    {
    }

    public Veiculo(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor, string? potencia)
    {
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
        Cor = cor;
        Potencia = potencia;
    }
    public Veiculo(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? potencia)
    {
        DataFabricacao = dataFabricacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
        Potencia = potencia;
    }

    public void VenderVeiculo(string cpfComprador, decimal valorVenda)
    {
        DataVenda = DateTime.Now;
        CpfComprador = cpfComprador;
        ValorVenda = valorVenda;
    }

    public virtual string ListarInformacoes()
    {
        Console.ForegroundColor = ConsoleColor.White;

        return $@"Veículo: {Nome?.ToUpper()} | Cor: {char.ToUpper(Cor![0]) + Cor.Substring(1)} | Placa: {Placa?.ToUpper()} | Valor Estoque: {Valor.ToString("c")}
Data Fabricação: {DataFabricacao.ToString("d")} | Chassi: {NumChassi?.ToUpper()} | Potencia: {Potencia}cv";
    }
    public virtual void AlterarInformacoes(decimal valor, string? cor)
    {
        Valor = valor;
        Cor = cor;
    }
    
}