using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Screens;
using DevCarConsole.Screens.ListagensScreens;

namespace DevCarConsole.Validacoes;

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
}