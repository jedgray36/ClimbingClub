using Microsoft.AspNetCore.Identity;
using RunningApp.Data.Enum;
using RunningApp.Models;

namespace RunningApp.Data
{
	public class Seed
	{
		public static void SeedData(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDBContent>();

				context.Database.EnsureCreated();

				if (!context.Climb.Any())
				{
					context.Climb.AddRange(new List<Climb>()
					{
						new Climb()
						{
							Title = "Climbing V0",
							Image = "https://adrenalinevault.com.au/wp-content/uploads/2019/03/membership-1.jpg",
							Description = "Newbie climbing club for people just starting out",
							ClimbCategory = ClimbCategory.Newbie,
							Address = new Address()
							{
								Street = "123 Main St",
								City = "Charlotte",
								State = "NC"
							}
						 },
						new Climb()
						{
							Title = "Climbing Hanger Club",
							Image = "https://adrenalinevault.com.au/wp-content/uploads/2019/03/membership-1.jpg",
							Description = "Climbers that have a formed a layer of chalk on their hands",
                            ClimbCategory = ClimbCategory.HandsOfSteel,
							Address = new Address()
							{
								Street = "123 Main St",
								City = "Charlotte",
								State = "NC"
							}
						},
						new Climb()
						{
							Title = "River Climbing Club",
							Image = "https://adrenalinevault.com.au/wp-content/uploads/2019/03/membership-1.jpg",
							Description = "For Climbers that prefer the great outdoors",
                            ClimbCategory = ClimbCategory.OutdoorClimbs,
							Address = new Address()
							{
								Street = "123 Main St",
								City = "Charlotte",
								State = "NC"
							}
						},
						new Climb()
						{
							Title = "Crimps and Climbs",
							Image = "https://adrenalinevault.com.au/wp-content/uploads/2019/03/membership-1.jpg",
							Description = "Casual climbing ",
                            ClimbCategory = ClimbCategory.Casual,
							Address = new Address()
							{
								Street = "123 Main St",
								City = "Michigan",
								State = "NC"
							}
						}
					});
					context.SaveChanges();
				}
				//Climbing Events
				if (!context.Climbs.Any())
				{
					context.Climbs.AddRange(new List<ClimbingEvent>()
					{
						new ClimbingEvent()
						{
							Title = "New Climbers Event",
							Image = "https://adrenalinevault.com.au/wp-content/uploads/2019/03/membership-1.jpg",
							Description = "An event for new climbers",
                            ClimbEventCategory = ClimbingEventCategory.V1V3,
							Address = new Address()
							{
								Street = "123 Main St",
								City = "Charlotte",
								State = "NC"
							}
						},
						new ClimbingEvent()
						{
							Title = "Training Session",
							Image = "https://adrenalinevault.com.au/wp-content/uploads/2019/03/membership-1.jpg",
							Description = "Casual training session for experienced climbers",
                            ClimbEventCategory = ClimbingEventCategory.V4V6,
							AddressId = 5,
							Address = new Address()
							{
								Street = "123 Main St",
								City = "Charlotte",
								State = "NC"
							}
						}
					});
					context.SaveChanges();
				}
			}
		}

		//public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
		//{
		//	using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
		//	{
		//		//Roles
		//		var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

		//		if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
		//			await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
		//		if (!await roleManager.RoleExistsAsync(UserRoles.User))
		//			await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

		//		//Users
		//		var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
		//		string adminUserEmail = "teddysmithdeveloper@gmail.com";

		//		var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
		//		if (adminUser == null)
		//		{
		//			var newAdminUser = new AppUser()
		//			{
		//				UserName = "teddysmithdev",
		//				Email = adminUserEmail,
		//				EmailConfirmed = true,
		//				Address = new Address()
		//				{
		//					Street = "123 Main St",
		//					City = "Charlotte",
		//					State = "NC"
		//				}
		//			};
		//			await userManager.CreateAsync(newAdminUser, "Coding@1234?");
		//			await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
		//		}

		//		string appUserEmail = "user@etickets.com";

		//		var appUser = await userManager.FindByEmailAsync(appUserEmail);
		//		if (appUser == null)
		//		{
		//			var newAppUser = new AppUser()
		//			{
		//				UserName = "app-user",
		//				Email = appUserEmail,
		//				EmailConfirmed = true,
		//				Address = new Address()
		//				{
		//					Street = "123 Main St",
		//					City = "Charlotte",
		//					State = "NC"
		//				}
		//			};
		//			await userManager.CreateAsync(newAppUser, "Coding@1234?");
		//			await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
		//		}
		//	}
		//}
	}
}
