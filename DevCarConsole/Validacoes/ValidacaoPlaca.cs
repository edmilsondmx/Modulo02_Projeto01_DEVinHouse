
using System.Text.RegularExpressions;
using DevCarConsole.Repositories;
using DevCarConsole.Screens;

namespace DevCarConsole.Validacoes;

public static class ValidacaoPlaca
{
    public static void ValidarPlaca(string placa, VeiculoRepository repository)
    {
        if(placa.Length != 7)
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
        foreach (var veiculo in repository.ListaDeVeiculos)
        {
            if(veiculo.Placa == placa)
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
    }
    public static void ValidarFormatoPlaca(string placa, VeiculoRepository repository)
    {
        if(placa.Length != 7)
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
    }
    
}

