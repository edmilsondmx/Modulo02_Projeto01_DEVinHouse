using DevCarConsole.Models;
namespace DevCarConsole.Repositories;

public class VeiculoRepository
{
    public IList<Veiculo> ListaDeVeiculos;

    public VeiculoRepository()
    {
        ListaDeVeiculos = new List<Veiculo>();
    }
}