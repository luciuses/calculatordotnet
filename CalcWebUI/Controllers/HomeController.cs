using System.Web.Mvc;
using CalcWebUI.Components;
using CalcWebUI.Models;

namespace CalcWebUI.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			var model = new IndexInputModel();

			return View(model);
		}

		[HttpPost]
		public double Index(IndexInputModel input)
		{
			switch (input.Operation)
			{
				case OperationType.Addition:
					return input.Argument1 + input.Argument2;
				case OperationType.Subtraction:
					return input.Argument1 - input.Argument2;
				case OperationType.Division:
					return input.Argument1 / input.Argument2;
				case OperationType.Multiplication:
					return input.Argument1 * input.Argument2;
				default: return double.NaN;
			}
		}
	}
}