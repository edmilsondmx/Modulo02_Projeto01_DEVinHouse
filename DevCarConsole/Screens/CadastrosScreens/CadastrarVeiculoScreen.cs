using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Screens.CadastrosScreens;

namespace DevCarConsole.Screens;

public static class CadastrarVeiculoScreen
{
    public static void Iniciar(IList<Veiculo> repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: CadastrarMotoScreen.MotoTriciclo(repository); break;
            case 2: CadastrarCarroScreen.CarroPasseio(repository); break;
            case 3: CadastrarCaminhoneteScreen.Caminhonete(repository); break;
            case 0: MenuScreen.Iniciar(repository); break;
            default: break;
        }

        

    }

    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Qual Veículo Deseja Cadastrar?");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==============================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Moto / Triciclo");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Carro Passeio");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Caminhonete");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("0 - Voltar ao Menu Principal");

        Console.SetCursorPosition(2, 12);
        System.Console.Write("Digite a opção: ");

    }

}