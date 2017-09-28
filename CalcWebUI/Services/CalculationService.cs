using CalcWebUI.Components;

namespace CalcWebUI.Services
{
	public interface ICalculationService
	{
		object Calculate(object argument1, object argument2, OperationType operation);
	}

	public class CalculationService : ICalculationService
	{
		private readonly ICalculatorProvider _calculatorProvider;

		public CalculationService(ICalculatorProvider calculatorProvider)
		{
			_calculatorProvider = calculatorProvider;
		}

		public object Calculate(object argument1, object argument2, OperationType operation)
		{
			var calculator = _calculatorProvider.GetCalculator(operation, argument1.GetType());
			return calculator.Calculate(argument1, argument2);
		}
	}
}