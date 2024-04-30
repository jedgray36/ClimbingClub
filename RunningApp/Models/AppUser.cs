using System.ComponentModel.DataAnnotations;

namespace RunningApp.Models
{
	public class AppUser
	{
		[Key]
		public string Id { get; set; }
		public int Grade { get; set; }
		public int DistanceClimbed { get; set; }
		public Address? Address { get; set; }
		public ICollection<Climb> Climb { get; set; }
		public ICollection<ClimbingEvent> Climbs { get; set; }

	}
}
