namespace DevCarConsole.Models;

public class MotoTriciclo : Veiculo
{
    public string? QuantidadeRodas { get; set; }
    public MotoTriciclo()
    {
    }

    public MotoTriciclo(DateTime dataFabricacao, string? nome, string? placa, decimal valor, string? cor, string? potencia, string? qtdRodas) : base(dataFabricacao, nome, placa, valor, cor, potencia)
    {
        Categoria = "Moto / Triciclo";
        QuantidadeRodas = qtdRodas;
    }

    public override string ListarInformacoes()
    {
        return $"{base.ListarInformacoes()} | Quantidade de Rodas: {QuantidadeRodas}";
    }

}