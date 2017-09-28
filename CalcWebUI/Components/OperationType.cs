using System.ComponentModel;

namespace CalcWebUI.Components
{
	public enum OperationType
	{
		[Description("+")]
		Addition,

		[Description("-")]
		Subtraction,

		[Description("/")]
		Division,

		[Description("*")]
		Multiplication
	}
}