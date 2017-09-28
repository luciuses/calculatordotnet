using System;
using CalcWebUI.Components;

namespace CalcWebUI.Calculators
{
	public interface ICalculator<T> : ICalculator
	{
		T Calculate(T argument1, T argument2);
	}

	public interface ICalculator
	{
		Type ArgumentType { get; }
		OperationType Operation { get; }
		object Calculate(object argument1, object argument2);
	}

	public abstract class BaseCalculator<T> : ICalculator<T>
	{
		public abstract OperationType Operation { get; }

		object ICalculator.Calculate(object argument1, object argument2)
		{
			return Calculate((T)argument1, (T)argument2);
		}

		public abstract T Calculate(T argument1, T argument2);
		public Type ArgumentType => typeof(T);
	}
}