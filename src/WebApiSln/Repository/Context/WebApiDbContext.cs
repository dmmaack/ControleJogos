using Microsoft.EntityFrameworkCore;

namespace Repository.Entity
{
	public class WebApiDbContext : DbContext
	{
		public WebApiDbContext(DbContextOptions<WebApiDbContext> options) : base(options)
		{

		}

		public DbSet<ConsoleEntity> Console { get; set; }
	}
}