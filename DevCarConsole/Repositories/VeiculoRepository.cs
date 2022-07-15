using DevCarConsole.Models;
namespace DevCarConsole.Repositories;

//ToDo: Refatorar classe para estática
public class VeiculoRepository
{
    public IList<Veiculo> ListaDeVeiculos {get; set;} = null!;

    public VeiculoRepository()
    {
        ListaDeVeiculos = new List<Veiculo>();
    }
}