using DevCarConsole.Screens;
using DevCarConsole.Repositories;
namespace DevCarConsole.Validations;

public static class ValidarInput
{
    public static void ValidacaoDeInput(string valor)
    {
        try
        {
            if(string.IsNullOrEmpty(valor))
            {
                Console.Clear();
                System.Console.WriteLine("Dado Inválido!");
                System.Console.WriteLine("Pressione ENTER para voltar ao menu inicial!");
                Console.ReadLine();
                CadastrarVeiculoScreen.Iniciar(VeiculoRepository.ListaDeVeiculos);
            }
                
        }
        catch (Exception ex)
        {
            
            throw new Exception($"Formato inválido. {ex.Message}");
        }
    }

}