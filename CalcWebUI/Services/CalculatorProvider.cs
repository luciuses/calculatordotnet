using System;
using System.Collections.Generic;
using System.Linq;
using CalcWebUI.Calculators;
using CalcWebUI.Components;

namespace CalcWebUI.Services
{
	public interface ICalculatorProvider
	{
		ICalculator GetCalculator(OperationType operation, Type argumentType);
	}

	public class CalculatorProvider : ICalculatorProvider
	{
		private readonly IEnumerable<ICalculator> _calculators;

		public CalculatorProvider(IEnumerable<ICalculator> calculators)
		{
			_calculators = calculators;
		}

		public ICalculator GetCalculator(OperationType operation, Type argumentType)
		{
			return _calculators.FirstOrDefault(c => c.Operation.Equals(operation) && c.ArgumentType == argumentType);
		}
	}
}