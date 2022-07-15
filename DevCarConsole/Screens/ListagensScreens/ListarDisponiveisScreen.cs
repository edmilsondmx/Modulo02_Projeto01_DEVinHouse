using DevCarConsole.Repositories;
using DevCarConsole.Validacoes;

namespace DevCarConsole.Screens.ListagensScreens;

public static class ListarDisponiveisScreen
{
    public static void Iniciar(VeiculoRepository repository)
    {
        Console.Clear();
        System.Console.WriteLine("Veiculos Disponíveis");
        System.Console.WriteLine("====================");
        System.Console.Write(Environment.NewLine);

        ValidarVendido.ValidarCarrosDisponiveis(repository);

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
        Console.ReadLine();
        MenuScreen.Iniciar(repository);
    }
}