using Microsoft.EntityFrameworkCore;

namespace EFLibrary
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
			
		}
	}
}