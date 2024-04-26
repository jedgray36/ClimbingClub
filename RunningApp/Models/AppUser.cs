namespace RunningApp.Models
{
	public class AppUser
	{

		public int Pace { get; set; }
		public int Milage { get; set; }
		public Address? Address { get; set; }
		public ICollection<Club> Clubs { get; set; }
		public ICollection<Races> Races { get; set; }

	}
}
