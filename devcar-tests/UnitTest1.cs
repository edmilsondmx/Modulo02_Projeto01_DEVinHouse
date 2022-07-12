using DevCarConsole.Models;
namespace devcar_tests;

public class UnitTest1
{
    [Theory]
    [InlineData("Roxo")]
    public void Validar_Cor_Caminhonete_Sucesso(string? cor)
    {
        Veiculo novaCaminhonete = new Caminhonete();
        novaCaminhonete.AlterarInformacoes(190000m, cor);

        string condição = "Roxo";
        Assert.Equal(condição, novaCaminhonete.Cor);
    }

    [Theory]
    [InlineData("azul")]
    public void Validar_Cor_Caminhonete_Erro(string? cor)
    {
        Caminhonete novaCaminhonete1 = new Caminhonete();
        novaCaminhonete1.Cor = cor;

        string expectativa = "Roxo";
        Assert.NotEqual(expectativa, novaCaminhonete1.Cor);
    }
}