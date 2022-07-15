using DevCarConsole.Validacoes;
using DevCarConsole.Repositories;
using DevCarConsole.Models;
using System.Text.RegularExpressions;

namespace DevCarConsole.Screens.CadastrosScreens;

public static class CadastrarCarroScreen
{
    public static void CarroPasseio(VeiculoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Cadastro de Carro de Passeio");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==================================");

        Console.SetCursorPosition(2, 4);
        System.Console.Write("Data de Fabricação: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine()!);

        Console.SetCursorPosition(2, 5);
        System.Console.Write("Marca / Modelo: ");
        string marcaModelo = Console.ReadLine()!;

        Console.SetCursorPosition(2, 6);
        System.Console.Write("Placa: ");
        string placa = Console.ReadLine()!;
        string placaTrim = Regex.Replace(placa, @"\s", "");
        ValidacaoPlaca.ValidarPlaca(placaTrim, repository);

        Console.SetCursorPosition(2, 7);
        System.Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);
        ValidacaoValor.ValidarValorCadastroMaiorQueZero(valor, repository);

        Console.SetCursorPosition(2, 8);
        System.Console.Write("Cor: ");
        string cor = Console.ReadLine()!;

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Quantidade de Portas: ");
        string qtdPortas = Console.ReadLine()!;

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Combustível: ");
        string combustivel = Console.ReadLine()!;

        Console.SetCursorPosition(2, 11);
        System.Console.Write("Potência: ");
        string potencia = Console.ReadLine()!;

        repository.ListaDeVeiculos.Add(new Carro(dataFabricacao, marcaModelo, placaTrim.ToUpper(), valor, cor, qtdPortas, combustivel, potencia));

        Console.Clear();
        System.Console.WriteLine("Carro Cadastrado com sucesso!");
        System.Console.WriteLine("=================================================================================");
        foreach (var veiculo in repository.ListaDeVeiculos)
        {
            if(veiculo.Placa == placaTrim.ToUpper())
                System.Console.WriteLine(veiculo.ListarInformacoes());
                
        }
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");

        Console.ReadLine();
        CadastrarVeiculoScreen.Iniciar(repository);
    }
}