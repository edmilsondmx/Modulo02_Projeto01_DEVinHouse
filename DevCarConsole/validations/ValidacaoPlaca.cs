using System.Text.RegularExpressions;
using DevCarConsole.Models;
using DevCarConsole.Screens;

namespace DevCarConsole.Validations;

public static class ValidacaoPlaca
{
    public static void ValidarPlaca(string placa, IList<Veiculo> repository)
    {
        string placaTrim = Regex.Replace(placa, @"\s", "");
        if(placaTrim.Length != 7)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Placa inválida!");
            Console.SetCursorPosition(2, 9);
            System.Console.WriteLine("Somente letras e números!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 11);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            CadastrarVeiculoScreen.Iniciar(repository);
        }

        var notFound = repository.Where(veiculo => veiculo.Placa == placaTrim).FirstOrDefault();
        if(notFound != null)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Placa já Cadastrada no sistema!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            CadastrarVeiculoScreen.Iniciar(repository);
        }            
    }
    public static void ValidarFormatoPlaca(string placa, IList<Veiculo> repository)
    {
        string placaTrim = Regex.Replace(placa, @"\s", "");
        if(placaTrim.Length != 7)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Placa inválida!");
            Console.SetCursorPosition(2, 9);
            System.Console.WriteLine("Somente letras e números!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 11);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            MenuScreen.Iniciar(repository);
        }

        var notFound = (repository.Where(veiculo => veiculo.Placa == placaTrim)).FirstOrDefault();

        if(notFound == null)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 7);
            System.Console.WriteLine("Veículo não encontrado!");
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Insira um veículo cadastrado!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 11);
            System.Console.Write("Pressione ENTER para ");
            Console.SetCursorPosition(2, 12);
            System.Console.Write("voltar ao Menu Principal");
            Console.ReadLine();
            MenuScreen.Iniciar(repository);
    
        }

        
    }
    
}

