using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;
using DevCarConsole.Validations;

namespace DevCarConsole.Reports;

public static class ListarVendidoMaiorValor
{
    public static void ListarVeiculoVendidoMaiorValor(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Veículo Vendido com Maior Valor");
        System.Console.WriteLine("===============================");
        System.Console.Write(Environment.NewLine);

        decimal? maiorValor = repository.Where(veiculo => veiculo.CpfComprador != null).ToList().DefaultIfEmpty().Max(veiculo => veiculo?.ValorVenda);

        ValidarVendido.ValidarSeExisteMaiorOuMenorValor(maiorValor, repository);

        foreach (var veiculo in repository)
        {
            if(veiculo.ValorVenda == maiorValor)
            {
                ListarVendidosScreen.MostrarInformacoes(veiculo);
            }
        }

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        ListarVendidosScreen.Iniciar(repository);
    }
}