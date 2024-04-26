using Microsoft.AspNetCore.Mvc;

namespace RunningApp.Controllers
{
	public class ClubController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
