using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Screens;

namespace DevCarConsole.Validacoes;

public static class ValidacaoValor
{
    public static void ValidarValorVendaMaiorQueZero(decimal valorVenda, IList<Veiculo> repository)
    {
        if(valorVenda <= 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine("Valor Inválido");
            Console.SetCursorPosition(2, 11);
            System.Console.WriteLine("Favor digitar valor correto!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 13);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            MenuScreen.Iniciar(repository);
        }
        return;
    }
    public static void ValidarValorCadastroMaiorQueZero(decimal valor, IList<Veiculo> repository)
    {
        if(valor <= 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine("Valor Inválido");
            Console.SetCursorPosition(2, 11);
            System.Console.WriteLine("Favor digitar valor correto!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 13);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            CadastrarVeiculoScreen.Iniciar(repository);
        }
        return;
    }
}