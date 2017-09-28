using System;
using System.Web.Mvc;
using CalcWebUI.Models;
using CalcWebUI.Services;

namespace CalcWebUI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICalculationService _calculationService;

		public HomeController(ICalculationService calculationService)
		{
			_calculationService = calculationService;
		}

		[HttpGet]
		public ActionResult Index()
		{
			var model = new IndexInputModel();

			return View(model);
		}

		[HttpPost]
		public ContentResult Index(IndexInputModel input)
		{
			string result;
			try
			{
				result = _calculationService.Calculate(input.Argument1, input.Argument2, input.Operation).ToString();
			}
			catch (Exception e)
			{
				result = $"Error:{e.Message}";
			}

			return Content(result);
		}
	}
}