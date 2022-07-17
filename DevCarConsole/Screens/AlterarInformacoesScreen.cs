using System.Text.RegularExpressions;
using DevCarConsole.Models;
using DevCarConsole.Validations;

namespace DevCarConsole.Screens;

public class AlterarInformacoesScreen
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
        System.Console.WriteLine("Alterar informações de Veículos");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("===============================");

        Console.SetCursorPosition(2, 3);
        System.Console.WriteLine("Digite a placa do");
        Console.SetCursorPosition(2, 4);
        System.Console.Write("Veículo a ser alterado: ");

        string placa = Console.ReadLine()!.ToUpper();
        
        ValidacaoPlaca.ValidarFormatoPlaca(placa, repository);
        Veiculo veiculoEncontrado = ValidarVendido.VaidarSeOVeiculoJaFoiVendido(placa);


        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine($"{veiculoEncontrado.Nome} | {veiculoEncontrado.Cor}");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine($"{veiculoEncontrado.DataFabricacao.Year} | {veiculoEncontrado.Valor.ToString("c")}");

        Console.SetCursorPosition(2, 8);
        System.Console.Write("Valor do Veículo: ");
        decimal novoValor = decimal.Parse(Console.ReadLine()!);
        ValidacaoValor.ValidarValorCadastroMaiorQueZero(novoValor, repository);

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Cor: ");
        string novaCor = Console.ReadLine()!;

        veiculoEncontrado.AlterarInformacoes(novoValor, novaCor);

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(2, 12);
        System.Console.WriteLine("Veículo Alterado com sucesso!");
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