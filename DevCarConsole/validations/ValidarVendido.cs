using System.Text.RegularExpressions;
using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Screens;
using DevCarConsole.Screens.ListagensScreens;

namespace DevCarConsole.Validations;

public static class ValidarVendido
{
    public static void ValidarTodosVeiculosVendidos(IList<Veiculo> repository)
    {
        bool quantidadeVeiculos = true;
        foreach (var veiculo in repository)
        {
            if(veiculo.CpfComprador != null)
            {
                quantidadeVeiculos = false;
            }
            
        }
        
        if(quantidadeVeiculos)
        {
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Não há veículo Vendidos na lista!");

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("================================ ");
        }
        return;
    }
    public static void ValidarCarrosDisponiveis(IList<Veiculo> repository)
    {
        bool quantidadeVeiculos = true;
        foreach (var veiculo in repository)
        {
            if(veiculo.ValorVenda == 0)
            {
                quantidadeVeiculos = false;
                System.Console.WriteLine(veiculo.ListarInformacoes());

                Console.ForegroundColor = ConsoleColor.Green;

                System.Console.WriteLine("=======================================================================================================================");
            }
            
        }
        if(quantidadeVeiculos)
        {
            
            System.Console.WriteLine("Não há veículo disponíveis na lista!");
            Console.ForegroundColor = ConsoleColor.Green;

            System.Console.WriteLine("=================================== ");
        }
    }

    public static void ValidarSeExisteMaiorOuMenorValor(decimal? valorVeiculo, IList<Veiculo> repository)
    {
        if(valorVeiculo == null)
        {
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Não há veículo Vendidos na lista!");

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("================================ ");

            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            
            ListarVendidosScreen.Iniciar(repository);
        }
    }

    public static Veiculo VaidarSeOVeiculoJaFoiVendido(string placa)
    {
        string placaTrim = Regex.Replace(placa, @"\s", "").ToUpper();
        Veiculo? existeVeiculo = VeiculoRepository.ListaDeVeiculos.Where(veiculo => veiculo.Placa == placaTrim).ToList().FirstOrDefault();

        if(existeVeiculo?.ValorVenda != 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 7);
            System.Console.WriteLine("Veículo já vendido!");
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Insira outro veículo cadastrado!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 11);
            System.Console.Write("Pressione ENTER para ");
            Console.SetCursorPosition(2, 12);
            System.Console.Write("voltar ao Menu Principal");
            Console.ReadLine();
            MenuScreen.Iniciar(VeiculoRepository.ListaDeVeiculos);
        }
        
        return existeVeiculo!;
    }
}