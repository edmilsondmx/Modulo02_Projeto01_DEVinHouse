using System.Linq;
using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Validacoes;

namespace DevCarConsole.Screens.ListagensScreens;

public class ListarVendidosScreen
{
    public static void Iniciar(IList<Veiculo> repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: ListartodosVendidos(repository); break;
            case 2: ListarVendidoMaiorValor(repository); break;
            case 3: ListarVendidoMenorValor(repository); break;
            case 0: MenuScreen.Iniciar(repository); break;
            default: break;
        }

    }
    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Qual das listas a seguir deseja?");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("================================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Todos veículos vendidos");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Veículo vendido com maior preço");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Veículo vendido com menor preço");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("0 - Voltar ao Menu Principal");

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Digite a opção: ");

    }

    static void ListartodosVendidos(IList<Veiculo> repository)
    {
        Console.Clear();
        System.Console.WriteLine("Todos Veiculos Vendidos");
        System.Console.WriteLine("=======================");
        System.Console.Write(Environment.NewLine);

        ValidarVendido.ValidarTodosVeiculosVendidos(repository);

        var vendidosOrdem = repository.OrderBy(veiculo => veiculo?.DataVenda).DefaultIfEmpty();

        foreach (var veiculo in vendidosOrdem)
        {
            if(veiculo?.CpfComprador != null)
            {
                MostrarInformacoes(veiculo);
            }
        }

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        Iniciar(repository);
    }
    static void ListarVendidoMaiorValor(IList<Veiculo> repository)
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
                MostrarInformacoes(veiculo);
            }
        }

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        Iniciar(repository);
    }
    static void ListarVendidoMenorValor(IList<Veiculo> repository)
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
                MostrarInformacoes(veiculo);
            }
        }
        
        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        Iniciar(repository);
    }

    private protected static void MostrarInformacoes(Veiculo veiculo)
    {
        System.Console.WriteLine(veiculo.ListarInformacoes());

        System.Console.WriteLine($"Valor de Venda: {veiculo.ValorVenda.ToString("c")} | CPF do Comprador: {veiculo.CpfComprador}");
        System.Console.WriteLine($"Data e hora da venda: {veiculo.DataVenda}");

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=======================================================================================================================");
    }
}