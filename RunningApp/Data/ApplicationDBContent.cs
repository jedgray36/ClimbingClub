using Microsoft.EntityFrameworkCore;
using RunningApp.Models;

namespace RunningApp.Data
{
	public class ApplicationDBContent : DbContext
	{
        public ApplicationDBContent(DbContextOptions<ApplicationDBContent> options) : base(options) 
        {
            
        }

        public DbSet<ClimbingEvent> Climbs { get; set; }
        public DbSet<Climb> Climb { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
