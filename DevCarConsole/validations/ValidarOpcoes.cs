using DevCarConsole.Repositories;
using DevCarConsole.Screens;

namespace DevCarConsole.Validations;

public static class ValidarOpcoes
{
    public static ushort ValidarOpcoesMenus(int qtdOpcoes)
    {
        
        try
        {
            ushort opcoes = ushort.Parse(Console.ReadLine()!);
            for (int i = 0; i < qtdOpcoes; i++)
            {
                if(opcoes == i)
                    return opcoes;
            }
            return ushort.Parse(null!);
        }
        catch
        {
            Console.Clear();
            MenuScreen.Bordas();
            Console.SetCursorPosition(2, 2);
            System.Console.WriteLine("DevCar Informa");
            Console.SetCursorPosition(2, 3);
            System.Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2, 5);
            System.Console.WriteLine("Formato de dado inválido.");
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine("Escolha uma das opções do Menu.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Pressione ENTER para");
            Console.SetCursorPosition(2, 9);
            System.Console.WriteLine("voltar ao menu Principal!");
            Console.ReadLine();
            MenuScreen.Iniciar(VeiculoRepository.ListaDeVeiculos);
            return ushort.Parse(null!);
        }
        
    }
}