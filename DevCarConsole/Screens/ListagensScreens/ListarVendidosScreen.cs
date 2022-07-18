using System.Linq;
using DevCarConsole.Models;
using DevCarConsole.Reports;
using DevCarConsole.Validations;

namespace DevCarConsole.Screens.ListagensScreens;

public class ListarVendidosScreen
{
    public static void Iniciar(IList<Veiculo> repository)
    {
        var veiculosVendidos = repository.Where(veiculo => veiculo.CpfComprador != null).ToList();
        if(veiculosVendidos.Count == 0)
        {
            Console.Clear();
            System.Console.WriteLine("ATENÇÂO");
            System.Console.WriteLine("=======");

            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Não há Veículos Vendidos na Lista!");
            
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            MenuScreen.Iniciar(repository);
        }

        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        int qtdOpcoes = 7;
        ushort opcoes = ValidarOpcoes.ValidarOpcoesMenus(qtdOpcoes);
      
        switch (opcoes)
        {
            
            case 1: ListarVendidoCategoria.ListarMotosVendidas(repository); break;
            case 2: ListarVendidoCategoria.ListarCarrosVendidos(repository); break;
            case 3: ListarVendidoCategoria.ListarCaminhonetesVendidas(repository); break;
            case 4: ListarTodosVendidos.ListarTodosVeiculosVendidos(repository); break;
            case 5: ListarVendidoMaiorValor.ListarVeiculoVendidoMaiorValor(repository); break;
            case 6: ListarVendidoMenorValor.ListarVeiculoVendidoMenorValor(repository); break;
            case 0: MenuScreen.Iniciar(repository); break;
            default: break;
        }

    }
    private static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Qual das listas a seguir deseja?");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("================================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Motos / Triciclos vendidos");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Carros de Passeio vendidos");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Caminhonetes vendidas");

        Console.SetCursorPosition(2, 7);
        System.Console.WriteLine("4 - Todos veículos vendidos");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("5 - Veículo vendido com maior Valor");

        Console.SetCursorPosition(2, 9);
        System.Console.WriteLine("6 - Veículo vendido com menor Valor");

        Console.SetCursorPosition(2, 11);
        System.Console.WriteLine("0 - Voltar ao Menu Principal");

        Console.SetCursorPosition(2, 13);
        System.Console.Write("Digite a opção: ");

    }

    public static void MostrarInformacoes(Veiculo veiculo)
    {
        System.Console.WriteLine(veiculo.ListarInformacoes());

        System.Console.WriteLine($"Valor de Venda: {veiculo.ValorVenda.ToString("c")} | CPF do Comprador: {veiculo.CpfComprador}");
        System.Console.WriteLine($"Data e hora da venda: {veiculo.DataVenda}");

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("==================================================================================");
    }
}