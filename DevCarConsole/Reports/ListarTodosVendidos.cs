using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;
using DevCarConsole.Validations;

namespace DevCarConsole.Reports;

public static class ListarTodosVendidos
{
    public static void ListarTodosVeiculosVendidos(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Todos Veiculos Vendidos");
        System.Console.WriteLine("=======================");
        System.Console.Write(Environment.NewLine);

        ValidarVendido.ValidarTodosVeiculosVendidos(repository);

        var vendidosOrdem = repository.OrderBy(veiculo => veiculo.DataVenda).DefaultIfEmpty();

        foreach (var veiculo in vendidosOrdem)
        {
            if(veiculo?.CpfComprador != null)
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