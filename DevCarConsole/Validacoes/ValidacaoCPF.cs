using DevCarConsole.Repositories;
using DevCarConsole.Screens;

namespace DevCarConsole.Validacoes;

public static class ValidacaoCPF
{
    public static void ValidarCPF(ulong numCpf, VeiculoRepository repository)

    {
        if (numCpf > 99999999999 || numCpf < 11111111111)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine("CPF inválido!");
            Console.SetCursorPosition(2, 11);
            System.Console.WriteLine("Digite apenas os números!(11 dígitos)");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 13);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            MenuScreen.Iniciar(repository);
        }

    }
}