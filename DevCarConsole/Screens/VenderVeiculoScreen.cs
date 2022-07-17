using DevCarConsole.Models;
using DevCarConsole.Validations;
using DevCarConsole.Repositories;

namespace DevCarConsole.Screens;

public class VenderVeiculoScreen
{
    
    public static void Iniciar(IList<Veiculo> repository)
    {
        var veiculosdisponiveis = repository.Where(veiculo => veiculo.CpfComprador == null).ToList();
        if(veiculosdisponiveis.Count == 0)
        {
            Console.Clear();
            System.Console.WriteLine("ATENÇÂO");
            System.Console.WriteLine("=======");

            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Não há Veículos disponíveis na Lista!");
            
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(Environment.NewLine);
            System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");
            Console.ReadLine();
            MenuScreen.Iniciar(repository);
        }
        Console.Clear();
        MenuScreen.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Vender Veículo");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==============");

        Console.SetCursorPosition(2, 3);
        System.Console.WriteLine("Digite a placa do");
        Console.SetCursorPosition(2, 4);
        System.Console.Write("Veículo a ser vendido: ");

        string placa = Console.ReadLine()!.ToUpper();

        ValidacaoPlaca.ValidarFormatoPlaca(placa, repository);
        Veiculo veiculoEncontrado = ValidarVendido.VaidarSeOVeiculoJaFoiVendido(placa);


        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine($"{veiculoEncontrado.Nome} | {veiculoEncontrado.Cor}");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine($"{veiculoEncontrado.DataFabricacao.Year} | {veiculoEncontrado.Valor.ToString("c")}");

        Console.SetCursorPosition(2, 8);
        System.Console.Write("CPF do Comprador: ");
        string cpfComprador = Console.ReadLine()!;
        ValidacaoCPF.ValidarCPF(cpfComprador, repository);

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Valor da venda: ");
        decimal valorVenda = decimal.Parse(Console.ReadLine()!);
        ValidacaoValor.ValidarValorVendaMaiorQueZero(valorVenda, repository);

        veiculoEncontrado.VenderVeiculo(cpfComprador, valorVenda);

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(2, 11);
        System.Console.WriteLine("Veículo Vendido com sucesso!");
        Console.ForegroundColor = ConsoleColor.Green;

        Console.SetCursorPosition(2, 13);
        System.Console.Write("Pressione ENTER para ");
        Console.SetCursorPosition(2, 14);
        System.Console.Write("voltar ao Menu Principal");

        if(Console.ReadKey().Key == ConsoleKey.Enter)
        {
            MenuScreen.Iniciar(repository);
        }
    }

}