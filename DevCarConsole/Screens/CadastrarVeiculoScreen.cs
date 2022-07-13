using DevCarConsole.Repositories;
using DevCarConsole.Models;
namespace DevCarConsole.Screens;

public class CadastrarVeiculoScreen
{
    public static void Iniciar(VeiculoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: MotoTriciclo(repository); break;
            case 2: CarroPasseio(repository); break;
            case 3: Caminhonete(repository); break;
            case 0: MenuScreen.Iniciar(repository); break;
            default: break;
        }

        

    }

    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Qual Veículo Deseja Cadastrar?");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==============================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Moto / Triciclo");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Carro Passeio");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Caminhonete");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("0 - Voltar ao Menu Principal");

        Console.SetCursorPosition(2, 12);
        System.Console.Write("Digite a opção: ");

    }

    static void MotoTriciclo(VeiculoRepository repository)
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

        Console.SetCursorPosition(2, 6);
        System.Console.Write("Placa: ");
        string placa = Console.ReadLine()!;
        ValidarPlaca(placa, repository);


        Console.SetCursorPosition(2, 7);
        System.Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

        Console.SetCursorPosition(2, 8);
        System.Console.Write("Cor: ");
        string cor = Console.ReadLine()!;

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Potência: ");
        string potencia = Console.ReadLine()!;

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Quantidade de Rodas: ");
        string qtdRodas = Console.ReadLine()!;

        repository.ListaDeVeiculos.Add(new MotoTriciclo(dataFabricacao, marcaModelo, placa, valor, cor, potencia, qtdRodas));

        Console.Clear();
        System.Console.WriteLine("Moto / Triciclo Cadastrado com sucesso!");
        System.Console.WriteLine("=================================================================================");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($@"Veículo: {marcaModelo?.ToUpper()} | Cor: {char.ToUpper(cor[0]) + cor.Substring(1)} | Placa: {placa?.ToUpper()} | Valor: {valor.ToString("c")}
Data Fabricação: {dataFabricacao.ToString("d")} | Potencia: {potencia}cv | Quantidade de rodas: {qtdRodas}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");

        Console.ReadLine();
        Iniciar(repository);
    }

    static void CarroPasseio(VeiculoRepository repository)
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
        ValidarPlaca(placa, repository);

        Console.SetCursorPosition(2, 7);
        System.Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

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

        repository.ListaDeVeiculos.Add(new Carro(dataFabricacao, marcaModelo, placa, valor, cor, qtdPortas, combustivel, potencia));

        Console.Clear();
        System.Console.WriteLine("Carro Cadastrado com sucesso!");
        System.Console.WriteLine("=================================================================================");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($@"Veículo: {marcaModelo?.ToUpper()} | Cor: {char.ToUpper(cor[0]) + cor.Substring(1)} | Placa: {placa?.ToUpper()} | Valor: {valor.ToString("c")} | Data Fabricação: {dataFabricacao.ToString("d")} 
Potencia: {potencia}cv | Quantidade de Portas: {qtdPortas} | Combustível: {char.ToUpper(combustivel[0]) + combustivel.Substring(1)}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");

        Console.ReadLine();
        Iniciar(repository);
    }

    static void Caminhonete(VeiculoRepository repository)
    {
        Console.Clear();
        MenuScreen.Bordas();

        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Cadastro de Caminhonete");
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
        ValidarPlaca(placa, repository);

        Console.SetCursorPosition(2, 7);
        System.Console.Write("Valor: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

        Console.SetCursorPosition(2, 8);
        System.Console.Write("Quantidade de Portas: ");
        string qtdPortas = Console.ReadLine()!;

        Console.SetCursorPosition(2, 9);
        System.Console.Write("Capacidade da Caçamba: ");
        string cacamba = Console.ReadLine()!;

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Potência: ");
        string potencia = Console.ReadLine()!;

        Console.SetCursorPosition(2, 11);
        System.Console.Write("Combustível: ");
        string combustivel = Console.ReadLine()!;

        repository.ListaDeVeiculos.Add(new Caminhonete(dataFabricacao, marcaModelo, placa, valor, qtdPortas, cacamba, potencia, combustivel));

        Console.Clear();
        System.Console.WriteLine("Caminhonete Cadastrado com sucesso!");
        System.Console.WriteLine("=================================================================================");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($@"Veículo: {marcaModelo?.ToUpper()} | Placa: {placa?.ToUpper()} | Valor: {valor.ToString("c")} | Data Fabricação: {dataFabricacao.ToString("d")} 
Potencia: {potencia}cv | Quantidade de Portas: {qtdPortas} | Litragem Caçamba: {cacamba}lt | Combustível: {char.ToUpper(combustivel[0]) + combustivel.Substring(1)}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Anterior");

        Console.ReadLine();
        Iniciar(repository);

    }

    static void ValidarPlaca(string placa, VeiculoRepository repository)
    {
        if(placa.Trim().Length != 7)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 8);
            System.Console.WriteLine("Placa inválida!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 10);
            System.Console.WriteLine(@"Pressione ENTER para 
            voltar ao Menu Anterior");
            Console.ReadLine();
            CadastrarVeiculoScreen.Iniciar(repository);
        }
        foreach (var veiculo in repository.ListaDeVeiculos)
        {
            char[] charTrim = {' ', '-', '_'};
            if(veiculo.Placa == placa.Trim(charTrim))
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
}