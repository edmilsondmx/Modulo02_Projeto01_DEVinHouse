using DevCarConsole.Models;
using DevCarConsole.Reports;

namespace DevCarConsole.Screens.ListagensScreens;

public class ListarVeiculosScreen
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
            case 1: ListarMotosScreen.ListarMotoTriciclo(repository); break;
            case 2: ListarCarrosScreen.ListarCarroPasseio(repository); break;
            case 3: ListarCaminhonetesScreen.ListarCaminhonete(repository); break;
            case 4: ListarTodosScreen.ListarTodosVeiculos(repository);  break;
            case 0: MenuScreen.Iniciar(repository); break;
            default: break;
        }

        

    }

    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Quais veículos deseja listar?");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("=============================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Moto / Triciclo");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Carro Passeio");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Caminhonete");

        Console.SetCursorPosition(2, 7);
        System.Console.WriteLine("4 - Todos");

        Console.SetCursorPosition(2, 9);
        System.Console.WriteLine("0 - Voltar ao Menu Principal");

        Console.SetCursorPosition(2, 12);
        System.Console.Write("Digite a opção: ");

    }

}