using Microsoft.EntityFrameworkCore;

namespace Repository.Entity
{
	public class WebApiDbContext : DbContext
	{
		public WebApiDbContext(DbContextOptions<WebApiDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			modelbuilder.Entity<JogoEntity>().HasOne(p => p.FabricanteJogo).WithMany(w => w.Jogos);
		}

		public DbSet<ConsoleEntity> Console { get; set; }
		public DbSet<FabricanteJogosEntity> FabricanteJogos { get; set; }
		public DbSet<JogoEntity> Jogo { get; set; }

	}
}