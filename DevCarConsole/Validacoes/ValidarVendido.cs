using DevCarConsole.Repositories;

namespace DevCarConsole.Validacoes;

public static class ValidarVendido
{
    public static void ValidarCarrosVendidos(VeiculoRepository repository)
    {
        bool quantidadeVeiculos = true;
        foreach (var veiculo in repository.ListaDeVeiculos)
        {
            if(veiculo.ValorVenda != 0)
            {
                quantidadeVeiculos = false;
                System.Console.WriteLine(veiculo.ListarInformacoes());
                System.Console.WriteLine($"Valor de Venda: {veiculo.ValorVenda.ToString("c")} | CPF do Comprador: {veiculo.CpfComprador}");

                Console.ForegroundColor = ConsoleColor.Green;

                System.Console.WriteLine("=======================================================================================================================");
            }
            
        }
        
        if(quantidadeVeiculos)
        {
            
            System.Console.WriteLine("Não há veículo Vendidos na lista!");
            Console.ForegroundColor = ConsoleColor.Green;

            System.Console.WriteLine("================================ ");
        }
    }
    public static void ValidarCarrosDisponiveis(VeiculoRepository repository)
    {
        bool quantidadeVeiculos = true;
        foreach (var veiculo in repository.ListaDeVeiculos)
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
}