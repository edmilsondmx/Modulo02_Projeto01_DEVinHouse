namespace DevCarConsole.Screens;

public class MenuScreen
{
    public static void Iniciar()
    {
        Console.Clear();
        Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: CadastrarVeiculoScreen.Iniciar(); break;
            case 2: break;
            case 3: break;
            case 4: break;
            case 5: break;
            case 6: break;
            case 7: break;
            case 8: break;
            case 0: Console.Clear(); Environment.Exit(0); break;
            default: break;
        }

    }

    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Seja bem vindo ao DevCar v1.0");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("=============================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Cadastrar Veículo");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Consultar Veículo");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Alterar Veículo");

        Console.SetCursorPosition(2, 7);
        System.Console.WriteLine("4 - Listar Todos os Veículos");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("5 - Carros Disponíveis");

        Console.SetCursorPosition(2, 9);
        System.Console.WriteLine("6 - Carros Vendidos");

        Console.SetCursorPosition(2, 10);
        System.Console.WriteLine("7 - Carro vendido com o maior preço");

        Console.SetCursorPosition(2, 11);
        System.Console.WriteLine("8 - Carro vendido com o menor preço");

        Console.SetCursorPosition(2, 12);
        System.Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(2, 14);
        System.Console.Write("Digite a opção: ");
    }

    public static void Bordas()
    {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        LinhaHoriziontal();
        for (int i = 0; i < 14; i++)
        {
        Console.Write("|");
        for (int line = 0; line <= 40; line++)
            Console.Write(" ");
            
        Console.Write("|");
        Console.Write(Environment.NewLine);
        }
        LinhaHoriziontal(); 
    }
    static void LinhaHoriziontal()
    {
        Console.Write("+");
        for (int i = 0; i <= 40; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }
}