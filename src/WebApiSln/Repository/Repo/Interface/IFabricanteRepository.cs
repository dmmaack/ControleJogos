using Repository.Entity;

namespace Repository.Services
{
    public interface IFabricanteRepository
    {
         FabricanteEntity BuscaFabricante(int id);
    }
}