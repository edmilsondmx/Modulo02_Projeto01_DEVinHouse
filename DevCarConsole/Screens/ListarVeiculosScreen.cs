using DevCarConsole.Models;
using DevCarConsole.Repositories;
namespace DevCarConsole.Screens;

public class ListarVeiculosScreen
{
    public static void Iniciar(VeiculoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: ListarMotoTriciclo(repository); break;
            case 2: ListarCarroPasseio(repository); break;
            case 3: ListarCaminhonete(repository); break;
            case 4: ListarTodosVeiculos(repository);  break;
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

    public static void ListarMotoTriciclo(VeiculoRepository repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Motos / Triciclos Cadastrados");
        System.Console.WriteLine("======================================");
        System.Console.Write(Environment.NewLine);

        

        if(repository.ListaDeVeiculos.Count == 0)
        {
            System.Console.WriteLine("Não há Motos / Triciclo na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        else
        {
            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                if(veiculo.Categoria == "Moto / Triciclo")
                {
                    System.Console.WriteLine(veiculo.ListarInformacoes());

                    Console.ForegroundColor = ConsoleColor.Green;

                    System.Console.WriteLine("=======================================================================================================================");
                }
            }
        }
        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        ListarVeiculosScreen.Iniciar(repository);
        
    }
    public static void ListarCarroPasseio(VeiculoRepository repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Carros de passeio Cadastrados");
        System.Console.WriteLine("======================================");
        System.Console.Write(Environment.NewLine);

        if(repository.ListaDeVeiculos.Count == 0)
        {
            System.Console.WriteLine("Não há Carros na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        else
        {
            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                if(veiculo.Categoria == "Carro Passeio")
                {
                    System.Console.WriteLine(veiculo.ListarInformacoes());

                    Console.ForegroundColor = ConsoleColor.Green;

                    System.Console.WriteLine("=======================================================================================================================");
                }
            }
        }
        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        ListarVeiculosScreen.Iniciar(repository);
        
    }
    public static void ListarCaminhonete(VeiculoRepository repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Caminhotetes Cadastradas");
        System.Console.WriteLine("======================================");
        System.Console.Write(Environment.NewLine);

        if(repository.ListaDeVeiculos.Count == 0)
        {
            System.Console.WriteLine("Não há Camihonetes na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        else
        {
            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                if(veiculo.Categoria == "Caminhonete")
                {
                    System.Console.WriteLine(veiculo.ListarInformacoes());

                    Console.ForegroundColor = ConsoleColor.Green;

                    System.Console.WriteLine("=======================================================================================================================");
                }
            }
        }
        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        ListarVeiculosScreen.Iniciar(repository);
        
    }

    static void ListarTodosVeiculos(VeiculoRepository repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Todos Veículos Cadastrados");
        System.Console.WriteLine("===================================");
        System.Console.Write(Environment.NewLine);

        if (repository.ListaDeVeiculos.Count == 0)
        {
            System.Console.WriteLine("Não há Veículos na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        else
        {
            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                System.Console.WriteLine(veiculo.ListarInformacoes());

                Console.ForegroundColor = ConsoleColor.Green;

                System.Console.WriteLine("=======================================================================================================================");
                
            }
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
    }
}