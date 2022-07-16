using DevCarConsole.Models;
using DevCarConsole.Screens.ListagensScreens;

namespace DevCarConsole.Reports;

public static class ListarCarrosScreen
{
    public static void ListarCarroPasseio(IList<Veiculo> repository)
    {
        Console.Clear();

        System.Console.WriteLine("Lista de Carros de passeio Cadastrados");
        System.Console.WriteLine("======================================");
        System.Console.Write(Environment.NewLine);

        var carros = repository.Where(w => w.Categoria == "Carro Passeio").ToList();

        if(carros == null)
        {
            System.Console.WriteLine("Não há Carros na Lista!");
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            ListarVeiculosScreen.Iniciar(repository);
        }
        foreach (var veiculo in carros!)
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