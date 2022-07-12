using DevCarConsole.Models;
using DevCarConsole.Screens;
namespace DevCarConsole;

public class Program
{
    static void Main(string[] args)
    {

        PopularLista();
        MenuScreen.Iniciar();

        //Veiculo novoVeiculo = new Veiculo(new DateTime(2021,01,15), "VW Polo", "edp-5420", 22900m, "Preto");

       // System.Console.WriteLine($"Veículo: {novoVeiculo.Nome} | Cor: {novoVeiculo.Cor} | Placa: {novoVeiculo.Placa} | Valor: {novoVeiculo.Valor.ToString("c")} | Data Fabricação: {novoVeiculo.DataFabricacao.ToString("d")} | Chassi: {novoVeiculo.NumChassi?.ToUpper()}");

        /* Caminhonete caminhonete1 = new Caminhonete(new DateTime(2021,01,15), "D20", "erd-2555", 98522.99m, "2", "500", "3000cv", "Diesel");

        caminhonete1.AlterarInformacoes(190000m, "azul");

        System.Console.WriteLine($"Veículo: {caminhonete1.Nome} | Cor: {caminhonete1.Cor} | Placa: {caminhonete1.Placa} | Valor: {caminhonete1.Valor.ToString("c")} | Data Fabricação: {caminhonete1.DataFabricacao.ToString("d")} | Chassi: {caminhonete1.NumChassi?.ToUpper()} | Total de Portas: {caminhonete1.TotalPortas} | Capacidade de Carga: {caminhonete1.CapacidadeCacamba}Lts | Potencia: {caminhonete1.Potencia} | Combustivel: {caminhonete1.Combustivel} | Categoria: {caminhonete1.Categoria}"); */

    }

    static void PopularLista()
    {
        //TODO
        //popular lista
    }
}