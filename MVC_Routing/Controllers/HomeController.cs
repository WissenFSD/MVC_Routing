using Microsoft.AspNetCore.Mvc;
using MVC_Routing.Models;
using System.Diagnostics;

namespace MVC_Routing.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult Test()
		{
			return View();
		}

		// Routing istenilirse, direk olarak action'un �zerine de verilebilir. �rnekte s�z konusu action Home/Insert olmas�na ra�men
		// Browser �zerinden Kayit yaz�larak direk olarak bu action'a y�nlenebilir.
		[Route("Kayit")]
		public IActionResult Insert()
		{
			return View();
		}
		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
