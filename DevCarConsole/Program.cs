using DevCarConsole.Repositories;
using DevCarConsole.Models;
using DevCarConsole.Screens;
namespace DevCarConsole;

public class Program
{
    static void Main(string[] args)
    {
        VeiculoRepository repository = new VeiculoRepository();

        PopularLista(repository);
        MenuScreen.Iniciar(repository);

    }

    static void PopularLista(VeiculoRepository repository)
    {
        //popular com lista estática
        repository.ListaDeVeiculos.Add(new MotoTriciclo(new DateTime(2022, 05, 22), "HONDA CB", "EDI8564", 15800m, "Preto", "250", "2"));
        repository.ListaDeVeiculos.Add(new MotoTriciclo(new DateTime(2022, 06, 15), "HONDA CB", "KFL8965", 16900m, "Prata", "300", "2"));
        repository.ListaDeVeiculos.Add(new Carro(new DateTime(2022, 03, 20), "VW POLO", "BVH8564", 89800m, "Cinza", "4", "Flex", "1400"));
        repository.ListaDeVeiculos.Add(new Carro(new DateTime(2022, 03, 15), "VW VIRTUS", "TBS4582", 104800m, "Preto", "4", "Flex", "2000"));
        repository.ListaDeVeiculos.Add(new Caminhonete(new DateTime(2022, 02, 10), "FORD RANGER", "NFG1285", 170500m, "4", "400lt", "3000", "Diesel"));
        repository.ListaDeVeiculos.Add(new Caminhonete(new DateTime(2022, 03, 28), "VW AMAROK", "FRD4585", 200300m, "4", "350", "3000", "Gasolina"));
        
    }

}