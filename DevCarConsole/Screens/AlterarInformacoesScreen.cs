using DevCarConsole.Repositories;
namespace DevCarConsole.Screens;

public class AlterarInformacoesScreen
{
    public static void Iniciar(VeiculoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        string opcoes = Console.ReadLine()!;

        if(opcoes == "0")
        {
            MenuScreen.Iniciar(repository);
        }


    }
    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Qual a placa do veiculo que deseja alterar?");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==============================");


        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("0 - Voltar ao Menu Principal");

        Console.SetCursorPosition(2, 12);
        System.Console.Write("Digite a opção: ");

    }
}