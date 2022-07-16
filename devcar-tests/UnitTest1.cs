using DevCarConsole.Models;
namespace devcar_tests;

public class UnitTest1
{
    [Theory]
    [InlineData("roxa")]
    public void Validar_Cor_Caminhonete_Sucesso(string cor)
    {
        Veiculo novaCaminhonete = new Caminhonete(new DateTime(2022, 04, 15), "Ford Ranger", "UIU8597", 180800m, "300", "4", "300", "Diesel");
        novaCaminhonete.AlterarInformacoes(190000m, cor);

        string condição = "Roxa";
        Assert.Equal(condição, novaCaminhonete.Cor);
    }

    [Theory]
    [InlineData("azul")]
    public void Validar_Cor_Caminhonete_Erro(string cor)
    {
        Caminhonete novaCaminhonete1 = new Caminhonete(new DateTime(2022, 04, 15), "Ford Ranger", "UIU8597", 180800m, "300", "4", "300", "Diesel");
        novaCaminhonete1.Cor = cor;

        string expectativa = "roxa";
        Assert.NotEqual(expectativa, novaCaminhonete1.Cor);
    } 
}