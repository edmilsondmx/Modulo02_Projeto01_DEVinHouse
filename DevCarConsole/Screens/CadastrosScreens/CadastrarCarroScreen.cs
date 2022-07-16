using DevCarConsole.Validations;
using DevCarConsole.Models;
using System.Text.RegularExpressions;

namespace DevCarConsole.Screens.CadastrosScreens;

public static class CadastrarCarroScreen
{
    public static void CarroPasseio(IList<Veiculo> repository)
    {
        Console.Clear();
        MenuScreen.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Cadastro de Carro de Passeio");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==================================");

        Console.SetCursorPosition(2, 4);
        System.Console.Write("Data de Fabricação: ");
        DateTime dataFabricacao;
        
        try
        {
            dataFabricacao = DateTime.Parse(Console.ReadLine()!);
        }
        catch(FormatException ex)
        {
            throw new Exception($"Formato inválido. Digite a placa Corretamente (dd/mm/aaaa). {ex.Message}");
        }

        Console.SetCursorPosition(2, 5);
        System.Console.Write("Marca / Modelo: ");
        string marcaModelo = Console.ReadLine()!.ToUpper();
        ValidarInput.ValidacaoDeInput(marcaModelo);

        Console.SetCursorPosition(2, 6);
        System.Console.Write("Placa: ");
        string placa = Console.ReadLine()!.ToUpper();
        string placaTrim = Regex.Replace(placa, @"\s", "");
        ValidacaoPlaca.ValidarPlaca(placa, repository);

        Console.SetCursorPosition(2, 7);
        System.Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);
        ValidacaoValor.ValidarValorCadastroMaiorQueZero(valor, repository);

        Console.SetCursorPosition(2, 8);
        System.Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        ValidarInput.ValidacaoDeInput(cor);

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Quantidade de Portas: ");
        string qtdPortas = Console.ReadLine()!;
        ValidarInput.ValidacaoDeInput(qtdPortas);

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Combustível: ");
        string combustivel = Console.ReadLine()!;
        ValidarInput.ValidacaoDeInput(combustivel);

        Console.SetCursorPosition(2, 11);
        System.Console.Write("Potência: ");
        string potencia = Console.ReadLine()!;
        ValidarInput.ValidacaoDeInput(potencia);

        repository.Add(new Carro(dataFabricacao, marcaModelo, placaTrim, valor, cor, potencia, qtdPortas, combustivel));

        Console.Clear();
        System.Console.WriteLine("Carro Cadastrado com sucesso!");
        System.Console.WriteLine("=================================================================================");
        foreach (var veiculo in repository)
        {
            if(veiculo.Placa == placaTrim)
                System.Console.WriteLine(veiculo.ListarInformacoes());
                
        }
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior!");

        Console.ReadLine();
        CadastrarVeiculoScreen.Iniciar(repository);
    }
}