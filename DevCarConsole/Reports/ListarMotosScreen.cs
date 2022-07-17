using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;

namespace DevCarConsole.Reports;

public static class ListarMotosScreen
{
    public static void ListarMotoTriciclo(IList<Veiculo> repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Motos / Triciclos Cadastrados");
        System.Console.WriteLine("======================================");
        System.Console.Write(Environment.NewLine);

        var motos = repository.Where(w => w.Categoria == "Moto / Triciclo").ToList();

        if(motos.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Não há Motos / Triciclo na Lista!");

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        foreach (var veiculo in motos!)
        {
            System.Console.WriteLine(veiculo.ListarInformacoes());

            Console.ForegroundColor = ConsoleColor.Green;

            System.Console.WriteLine("==================================================================================");
        }
        
        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        ListarVeiculosScreen.Iniciar(repository);
        
    }
}