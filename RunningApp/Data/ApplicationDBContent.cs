using Microsoft.EntityFrameworkCore;
using RunningApp.Models;

namespace RunningApp.Data
{
	public class ApplicationDBContent : DbContext
	{
        public ApplicationDBContent(DbContextOptions<ApplicationDBContent> options) : base(options) 
        {
            
        }

        public DbSet<Races> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
