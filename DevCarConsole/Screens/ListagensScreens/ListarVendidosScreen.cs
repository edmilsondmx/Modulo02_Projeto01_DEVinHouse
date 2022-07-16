using System.Linq;
using DevCarConsole.Models;
using DevCarConsole.Reports;

namespace DevCarConsole.Screens.ListagensScreens;

public class ListarVendidosScreen
{
    public static void Iniciar(IList<Veiculo> repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        ushort opcoes;
        try
        {
            opcoes = ushort.Parse(Console.ReadLine()!);
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(Environment.NewLine);
            throw new Exception($"Formato de dado inválido. Escolha uma das opções.{ex.Message}");
        }
        switch (opcoes)
        {
            case 1: ListarTodosVendidos.ListarTodosVeiculosVendidos(repository); break;
            case 2: ListarVendidoMaiorValor.ListarVeiculoVendidoMaiorValor(repository); break;
            case 3: ListarVendidoMenorValor.ListarVeiculoVendidoMenorValor(repository); break;
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

    public static void MostrarInformacoes(Veiculo veiculo)
    {
        System.Console.WriteLine(veiculo.ListarInformacoes());

        System.Console.WriteLine($"Valor de Venda: {veiculo.ValorVenda.ToString("c")} | CPF do Comprador: {veiculo.CpfComprador}");
        System.Console.WriteLine($"Data e hora da venda: {veiculo.DataVenda}");

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=======================================================================================================================");
    }
}