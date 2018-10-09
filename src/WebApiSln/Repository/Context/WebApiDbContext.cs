using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Repository.Entity
{
	public class WebApiDbContext : DbContext
	{
		public WebApiDbContext(DbContextOptions<WebApiDbContext> options) : base(options)
		{
            
		}

		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			modelbuilder.Entity<JogoEntity>().HasOne(ho => ho.FabricanteJogo).WithMany(wm => wm.Jogos).OnDelete(DeleteBehavior.Restrict);
            modelbuilder.Entity<JogoEntity>().HasOne(ho => ho.Emprestimo).WithOne(wo => wo.Jogo);
            modelbuilder.Entity<JogoEntity>().HasOne(ho => ho.Console).WithMany(wm => wm.Jogos);
            modelbuilder.Entity<ConsoleEntity>().HasOne(ho => ho.FabricanteConsole).WithMany(wm => wm.Consoles).OnDelete(DeleteBehavior.Restrict);
            modelbuilder.Entity<EmprestimoEntity>().HasOne(ho => ho.Amigo).WithMany(wm => wm.Emprestimos).OnDelete(DeleteBehavior.Restrict);
            modelbuilder.Entity<EmprestimoEntity>().HasOne(ho => ho.Jogo).WithOne(wo => wo.Emprestimo);
		}

		public DbSet<ConsoleEntity> Console { get; set; }
		public DbSet<FabricanteEntity> FabricanteJogos { get; set; }
		public DbSet<JogoEntity> Jogo { get; set; }
        public DbSet<AmigoEntity> Amigo { get; set; }
        public DbSet<EmprestimoEntity> Emprestimo { get; set; }

    }
}