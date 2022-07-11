namespace DevCarConsole.Screens;

public class CadastrarVeiculoScreen
{
    public static void Iniciar()
    {
        Console.Clear();
        MenuScreen.Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine()!);
        switch (opcoes)
        {
            case 1: MotoTriciclo(); break;
            case 2: CarroPasseio(); break;
            case 3: Caminhonete(); break;
            case 0: MenuScreen.Iniciar(); break;
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

    static void MotoTriciclo()
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

        string chassi = Guid.NewGuid().ToString().Substring(0,18);

        Console.Clear();
        System.Console.WriteLine("=================================================================================");
        System.Console.WriteLine($@"Veículo: {marcaModelo?.ToUpper()} | Cor: {char.ToUpper(cor[0]) + cor.Substring(1)} | Placa: {placa?.ToUpper()} | Valor: {valor.ToString("c")}
Data Fabricação: {dataFabricacao.ToString("d")} | Chassi: {chassi?.ToUpper()} | Potencia: {potencia}cv | Quantidade de rodas: {qtdRodas}");
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");

        Console.ReadLine();
        Iniciar();
    }

    static void CarroPasseio()
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


        string chassi = Guid.NewGuid().ToString().Substring(0,18);

        Console.Clear();
        System.Console.WriteLine("=================================================================================");
        System.Console.WriteLine($@"Veículo: {marcaModelo?.ToUpper()} | Cor: {char.ToUpper(cor[0]) + cor.Substring(1)} | Placa: {placa?.ToUpper()} | Valor: {valor.ToString("c")} | Data Fabricação: {dataFabricacao.ToString("d")} 
Chassi: {chassi?.ToUpper()} | Potencia: {potencia}cv | Quantidade de Portas: {qtdPortas} | Combustível: {char.ToUpper(combustivel[0]) + combustivel.Substring(1)}");
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");

        Console.ReadLine();
        Iniciar();
    }

    static void Caminhonete()
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

        string chassi = Guid.NewGuid().ToString().Substring(0,18);

        string cor = "Roxo";

        Console.Clear();
        System.Console.WriteLine("=================================================================================");
        System.Console.WriteLine($@"Veículo: {marcaModelo?.ToUpper()} | Cor: {char.ToUpper(cor[0]) + cor.Substring(1)} | Placa: {placa?.ToUpper()} | Valor: {valor.ToString("c")} | Data Fabricação: {dataFabricacao.ToString("d")} 
Chassi: {chassi?.ToUpper()} | Potencia: {potencia}cv | Quantidade de Portas: {qtdPortas} | Litragem Caçamba: {cacamba}lt | Combustível: {char.ToUpper(combustivel[0]) + combustivel.Substring(1)}");
        System.Console.WriteLine("=================================================================================");

        System.Console.Write(Environment.NewLine);
        System.Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");

        Console.ReadLine();
        Iniciar();

    }
}