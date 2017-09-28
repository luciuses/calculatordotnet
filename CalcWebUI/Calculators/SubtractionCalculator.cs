using CalcWebUI.Components;

namespace CalcWebUI.Calculators
{
	public class SubtractionCalculator : BaseCalculator<double>
	{
		public override OperationType Operation => OperationType.Subtraction;

		public override double Calculate(double argument1, double argument2)
		{
			return argument1 - argument2;
		}
	}
}