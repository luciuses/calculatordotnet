using System.ComponentModel.DataAnnotations;
using CalcWebUI.Components;

namespace CalcWebUI.Models
{
	public class IndexInputModel
	{
		[Display(Name = "Argument 1")]
		public double Argument1 { get; set; }

		[Display(Name = "Argument 2")]
		public double Argument2 { get; set; }

		[Display(Name = "Operation")]
		public OperationType Operation { get; set; }
	}
}