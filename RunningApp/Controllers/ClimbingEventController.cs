using Microsoft.AspNetCore.Mvc;
using RunningApp.Data;
using RunningApp.Models;

namespace RunningApp.Controllers
{
	public class ClimbingEventController : Controller
	{
		private readonly ApplicationDBContent _context;

		public ClimbingEventController(ApplicationDBContent context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
            List<ClimbingEvent> climbs = _context.Climbs.ToList();
			return View(climbs);
		}
	}
}
