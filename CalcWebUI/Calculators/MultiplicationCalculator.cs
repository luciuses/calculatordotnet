using CalcWebUI.Components;

namespace CalcWebUI.Calculators
{
	public class MultiplicationCalculator : BaseCalculator<double>
	{
		public override OperationType Operation => OperationType.Multiplication;

		public override double Calculate(double argument1, double argument2)
		{
			return argument1 * argument2;
		}
	}
}