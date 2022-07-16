using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;

namespace DevCarConsole.Reports;

public static class ListarTodosScreen
{
    public static void ListarTodosVeiculos(IList<Veiculo> repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Todos Veículos Cadastrados");
        System.Console.WriteLine("===================================");
        System.Console.Write(Environment.NewLine);

        if (repository.Count == 0)
        {
            System.Console.WriteLine("Não há Veículos na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }

        foreach (var veiculo in repository)
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