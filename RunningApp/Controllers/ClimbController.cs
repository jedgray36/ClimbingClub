using Microsoft.AspNetCore.Mvc;
using RunningApp.Data;
using RunningApp.Models;

namespace RunningApp.Controllers
{
	public class ClimbController : Controller
	{

		private readonly ApplicationDBContent _context;
		public ClimbController(ApplicationDBContent context) {

			_context = context;
		}
		public IActionResult Index() // Control
		{
			List<Climb> clubs = _context.Climb.ToList(); //Database Modal
			return View(clubs); //View 
		}

		//public IActionResult Details(int id)
		//{
		//	Climb climb = _context.Climbs.FirstOrDefault(c => c.Id == id);
		//	return View(climb);

		//}
	}
}
