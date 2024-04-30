﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RunningApp.Data.Enum;

namespace RunningApp.Models
{
	public class Climb
	{
		[Key]
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Image { get; set; }
		[ForeignKey("Address")]
		public int? AddressId { get; set; }
		public Address? Address { get; set; }
		public ClimbCategory ClimbCategory { get; set; }
		[ForeignKey("AppUser")]
		public string? AppUserId { get; set; }
		public AppUser? AppUser { get; set; }
	}
}
