using DevCarConsole.Repositories;

namespace DevCarConsole.Screens;

public class VendidosScreen
{
    public static void Iniciar(VeiculoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: break;
            case 2: break;
            case 3: break;
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
}