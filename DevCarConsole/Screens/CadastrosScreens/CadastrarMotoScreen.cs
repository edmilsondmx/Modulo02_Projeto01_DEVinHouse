using DevCarConsole.Validacoes;
using DevCarConsole.Repositories;
using DevCarConsole.Models;
using System.Text.RegularExpressions;

namespace DevCarConsole.Screens.CadastrosScreens;

public static class CadastrarMotoScreen
{
    public static void MotoTriciclo(IList<Veiculo> repository)
    {
        Console.Clear();
        MenuScreen.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Cadastro de Motocicleta / Triciclo");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==================================");

        Console.SetCursorPosition(2, 4);
        System.Console.Write("Data de Fabricação: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine()!);

        Console.SetCursorPosition(2, 5);
        System.Console.Write("Marca / Modelo: ");
        string marcaModelo = Console.ReadLine()!;
        ValidarInput.ValidacaoDeInput(marcaModelo);

        Console.SetCursorPosition(2, 6);
        System.Console.Write("Placa: ");
        string placa = Console.ReadLine()!;
        string placaTrim = Regex.Replace(placa, @"\s", "").ToUpper();
        ValidacaoPlaca.ValidarPlaca(placaTrim, repository);


        Console.SetCursorPosition(2, 7);
        System.Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);
        ValidacaoValor.ValidarValorCadastroMaiorQueZero(valor, repository);

        Console.SetCursorPosition(2, 8);
        System.Console.Write("Cor: ");
        string cor = Console.ReadLine()!;

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Potência: ");
        string potencia = Console.ReadLine()!;

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Quantidade de Rodas: ");
        string qtdRodas = Console.ReadLine()!;

        repository.Add(new MotoTriciclo(dataFabricacao, marcaModelo, placaTrim, valor, cor, potencia, qtdRodas));

        Console.Clear();
        System.Console.WriteLine("Moto / Triciclo Cadastrado com sucesso!");
        System.Console.WriteLine("=================================================================================");
        foreach (var veiculo in repository)
        {
            if(veiculo.Placa == placaTrim)
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