using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;
using DevCarConsole.Validations;

namespace DevCarConsole.Reports;

public static class ListarVendidoMenorValor
{
    public static void ListarVeiculoVendidoMenorValor(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Veiculo Vendido com Menor Valor");
        System.Console.WriteLine("===============================");
        System.Console.Write(Environment.NewLine);

        
        decimal? menorValor = repository.Where(veiculo => veiculo.CpfComprador != null).ToList().DefaultIfEmpty().Min(veiculo => veiculo?.ValorVenda);

        ValidarVendido.ValidarSeExisteMaiorOuMenorValor(menorValor, repository);

        foreach (var veiculo in repository)
        {
            if(veiculo.ValorVenda == menorValor)
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