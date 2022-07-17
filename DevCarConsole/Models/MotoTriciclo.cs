namespace DevCarConsole.Models;

public class MotoTriciclo : Veiculo
{
    public string Potencia { get; private set; }
    public string QuantidadeRodas { get; private set; }

    public MotoTriciclo(DateTime dataFabricacao, string nome, string placa, decimal valor, string cor, string potencia, string qtdRodas) : base(dataFabricacao, nome, placa, valor, cor)
    {
        Categoria = "Moto / Triciclo";
        Potencia = potencia;
        QuantidadeRodas = qtdRodas;
    }

    public override string ListarInformacoes()
    {
        return $@"{base.ListarInformacoes()} | Potencia: {Potencia}cc
Quantidade de Rodas: {QuantidadeRodas}";
    }

}