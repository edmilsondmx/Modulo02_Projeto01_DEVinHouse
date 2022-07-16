using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Screens.ListagensScreens;
using DevCarConsole.Validacoes;

namespace DevCarConsole.Screens;

public static class MenuScreen
{
    public static void Iniciar(IList<Veiculo> repository)
    {
        Console.Clear();
        Bordas();
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
            case 1: CadastrarVeiculoScreen.Iniciar(repository); break;
            case 2: AlterarInformacoesScreen.Iniciar(repository); break;
            case 3: ListarVeiculosScreen.Iniciar(repository); break;
            case 4: VenderVeiculoScreen.Iniciar(repository); break;
            case 5: ListarDisponiveisScreen.Iniciar(repository); break;
            case 6: ListarVendidosScreen.Iniciar(repository); break;
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

        Animacao();

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Cadastrar Veículo");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Alterar Informações do Veículo");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Listar Todos os Veículos");

        Console.SetCursorPosition(2, 7);
        System.Console.WriteLine("4 - Vender Veículo");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("5 - Veículos Disponíveis");

        Console.SetCursorPosition(2, 9);
        System.Console.WriteLine("6 - Histórico de transferências");

        Console.SetCursorPosition(2, 10);
        System.Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(2, 12);
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

    public static void Animacao()
    {
        Console.SetCursorPosition(40, 1);
        System.Console.WriteLine(@"                  _________________");
        Console.SetCursorPosition(40, 2);
        System.Console.WriteLine(@"              _.-'_____  _________ _`.");
        Console.SetCursorPosition(40, 3);
        System.Console.WriteLine(@"            .` ,'      ||         | `.`.");
        Console.SetCursorPosition(40, 4);
        System.Console.WriteLine(@"          .` ,'        ||         |   `.`.");
        Console.SetCursorPosition(40, 5);
        System.Console.WriteLine(@"        .`  /          ||         |  ,' ] `....___");
        Console.SetCursorPosition(40, 6);
        System.Console.WriteLine(@"      _`__.'''''''''''''''''''''''`''''''''|..___ `-.._");
        Console.SetCursorPosition(40, 7);
        System.Console.WriteLine(@"    .'                  [='                '     `'-.._`.");
        Console.SetCursorPosition(40, 8);
        System.Console.WriteLine(@" ,:/.'''''''''''''''''''|''''''''''''''''''|'''''''''''\'\");
        Console.SetCursorPosition(40, 9);
        System.Console.WriteLine(@"  //||    _..._         |                  '    _..._  |)|");
        Console.SetCursorPosition(40, 10);
        System.Console.WriteLine(@" /|//   ,',---.`.       |                  |  .',---.`.\>|");
        Console.SetCursorPosition(40, 11);
        System.Console.WriteLine(@"(':/   //' .-. `\\      \_________________/  '/' .-. `\\|_)");
        Console.SetCursorPosition(40, 12);
        System.Console.WriteLine(@" `-...'||  '-'  ||________,,,,,,,,,,,,,,,__.'||  '-'  ||-'");
        Console.SetCursorPosition(40, 13);
        System.Console.WriteLine(@"       '.'.___.','                           '.'.___.','");
        Console.SetCursorPosition(40, 14);
        System.Console.WriteLine(@"  DMX    '-.m.-'   DEVinHouse - Turma NDD      '-.m.-'");
    }
}