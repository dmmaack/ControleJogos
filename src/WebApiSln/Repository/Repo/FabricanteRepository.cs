using Repository.Entity;

namespace Repository.Services
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private readonly WebApiDbContext _context;

        public FabricanteRepository(WebApiDbContext context)
        {
            _context = context;
        }

        public FabricanteEntity BuscaFabricante(int id)
        {
			return null;
        }
    }
}