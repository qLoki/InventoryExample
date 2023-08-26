using InventoryModels;
using Microsoft.EntityFrameworkCore;

namespace EFLibrary
{
	public class InventoryDbContext:DbContext
	{
		public DbSet<Item> Items { get; set; }

		public InventoryDbContext() { }
		public InventoryDbContext(DbContextOptions options) : base(options)
		{
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data source=localhost;Initial Catalog=InventoryManagerDb;user=sa;password=loloshka228");
			}
		}
	}
}