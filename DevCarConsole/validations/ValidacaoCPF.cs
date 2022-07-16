using DevCarConsole.Models;
using DevCarConsole.Screens;

namespace DevCarConsole.Validations;

public static class ValidacaoCPF
{
    public static void ValidarCPF(string numCpf, IList<Veiculo> repository)

    {
        if (numCpf.Length != 11)
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
        try
        {
            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
            {
                numeros[i] = int.Parse(numCpf[i].ToString());
                
            }
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine(Environment.NewLine);
            throw new Exception($"Formato inválido, apenas número. {ex.Message}");
        }
        
    }
}