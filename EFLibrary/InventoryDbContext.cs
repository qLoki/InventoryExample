using InventoryModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFLibrary
{
	public class InventoryDbContext:DbContext
	{
		public DbSet<Item> Items { get; set; }
		private static IConfigurationRoot _configuration;

		public InventoryDbContext() { }
		public InventoryDbContext(DbContextOptions options) : base(options)
		{
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
		{
			if (!optionsBuilder.IsConfigured)
			{
				var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
				_configuration= builder.Build();
				var cnstr = _configuration.GetConnectionString("InventoryManager");
				optionsBuilder.UseSqlServer(cnstr);
				//optionsBuilder.UseSqlServer("Data source=localhost;Initial Catalog=InventoryManagerDb;user=sa;password=loloshka228");
			}
		}
	}
}