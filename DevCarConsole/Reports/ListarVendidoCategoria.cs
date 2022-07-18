using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;
using DevCarConsole.Validations;

namespace DevCarConsole.Reports;

public static class ListarVendidoCategoria
{
    public static void ListarMotosVendidas(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Todas Motos / Triciclos Vendidos");
        System.Console.WriteLine("================================");
        System.Console.Write(Environment.NewLine);

        var motos = repository.Where(veiculo => veiculo.Categoria == "Moto / Triciclo").ToList();
        ValidarVendido.ValidarTodosVeiculosVendidos(motos);

        var vendidosOrdem = motos.OrderBy(veiculo => veiculo.DataVenda).DefaultIfEmpty();

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
    public static void ListarCarrosVendidos(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Todos Carros de Passeio Vendidos");
        System.Console.WriteLine("================================");
        System.Console.Write(Environment.NewLine);

        var carrosPasseio = repository.Where(veiculo => veiculo.Categoria == "Carro Passeio").ToList();
        ValidarVendido.ValidarTodosVeiculosVendidos(carrosPasseio);

        var vendidosOrdem = carrosPasseio.OrderBy(veiculo => veiculo.DataVenda).DefaultIfEmpty();

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
    public static void ListarCaminhonetesVendidas(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Todas Caminhonetes Vendidas");
        System.Console.WriteLine("===========================");
        System.Console.Write(Environment.NewLine);

        var caminhonetes = repository.Where(veiculo => veiculo.Categoria == "Caminhonete").ToList();
        ValidarVendido.ValidarTodosVeiculosVendidos(caminhonetes);

        var vendidosOrdem = caminhonetes.OrderBy(veiculo => veiculo.DataVenda).DefaultIfEmpty();

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