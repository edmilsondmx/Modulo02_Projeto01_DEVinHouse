using DevCarConsole.Models;
using DevCarConsole.Repositories;
using DevCarConsole.Validacoes;

namespace DevCarConsole.Screens;

public class AlterarInformacoesScreen
{
    public static void Iniciar(IList<Veiculo> repository)
    {
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

        string placa = Console.ReadLine()!;
        ValidacaoPlaca.ValidarFormatoPlaca(placa.ToUpper(), repository);

        foreach (var veiculo in repository)
        {
            if(veiculo.Placa == placa.ToUpper())
            {
                if(veiculo.ValorVenda == 0)
                {
                    Console.SetCursorPosition(2, 5);
                    System.Console.WriteLine($"{veiculo.Nome} | {veiculo.Cor}");

                    Console.SetCursorPosition(2, 6);
                    System.Console.WriteLine($"{veiculo.DataFabricacao.Year} | {veiculo.Valor.ToString("c")}");

                    Console.SetCursorPosition(2, 8);
                    System.Console.Write("Valor do Veículo: ");
                    decimal novoValor = decimal.Parse(Console.ReadLine()!);

                    Console.SetCursorPosition(2, 9);
                    System.Console.Write("Cor: ");
                    string novaCor = Console.ReadLine()!;

                    veiculo.AlterarInformacoes(novoValor, novaCor);

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
                else
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
                    MenuScreen.Iniciar(repository);
                }

            }
        }

    }

}