using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;

namespace DevCarConsole.Reports;

public static class ListarCaminhonetesScreen
{
    public static void ListarCaminhonete(IList<Veiculo> repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Caminhotetes Cadastradas");
        System.Console.WriteLine("======================================");
        System.Console.Write(Environment.NewLine);

        var caminhonetes = repository.Where(w => w.Categoria == "Caminhonete").ToList();
        if(caminhonetes == null)
        {
            System.Console.WriteLine("Não há Camihonetes na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        foreach (var veiculo in caminhonetes!)
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