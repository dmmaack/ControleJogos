namespace Repository.Services
{
    public class FabricanteService : IfabricanteService
    {
        private readonly WebApiDbContext _context;

        public FabricanteService(WebApiDbContext context)
        {
            _context = context;
        }
        public FabricanteEntiry BuscaFabricante(int id)
        {
            var retorno = 
        }
    }
}