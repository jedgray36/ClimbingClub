using Microsoft.AspNetCore.Mvc;

namespace RunningApp.Controllers
{
	public class RaceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
