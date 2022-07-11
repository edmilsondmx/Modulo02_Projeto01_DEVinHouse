using DevCarConsole.Models;
using DevCarConsole.Screens;
namespace DevCarConsole;

public class Program
{
    static void Main(string[] args)
    {
        //MenuScreen.Iniciar();

        Veiculo novoVeiculo = new Veiculo(new DateTime(2021,01,15), "VW Polo", "edp-5420", 22900m, "Preto");

        System.Console.WriteLine($"Veículo: {novoVeiculo.Nome} | Cor: {novoVeiculo.Cor} | Placa: {novoVeiculo.Placa} | Valor: {novoVeiculo.Valor.ToString("c")} | Data Fabricação: {novoVeiculo.DataFabricacao.ToString("d")} | Chassi: {novoVeiculo.NumChassi?.ToUpper()}");
    }
}