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
			modelbuilder.Entity<JogoEntity>().HasOne(ho => ho.FabricanteJogo).WithMany(wm => wm.Jogos);
			modelbuilder.Entity<ConsoleEntity>().HasOne(ho => ho.FabricanteConsole).WithMany(wm => wm.Consoles);
		}

		public DbSet<ConsoleEntity> Console { get; set; }
		public DbSet<FabricanteEntity> FabricanteJogos { get; set; }
		public DbSet<JogoEntity> Jogo { get; set; }

	}
}