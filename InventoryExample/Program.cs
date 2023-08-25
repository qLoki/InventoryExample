using Microsoft.Extensions.Configuration;

namespace InventoryExample
{
	internal class Program
	{
		private static IConfigurationRoot _configuration;
		//private static DbContextOptionsBuilder<InventoryDbContext>_optionsBuilder;
		static void Main(string[] args)
		{
			BuildOptions();
		}
		static void BuildOptions()
		{
			_configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
			//_optionsBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
			//_optionsBuilder.UseSqlServer(_configuration.GetConnectionString("InventoryManager"));
		}
	}
}