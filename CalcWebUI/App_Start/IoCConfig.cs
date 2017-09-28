using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using CalcWebUI.Calculators;
using CalcWebUI.Services;

namespace CalcWebUI
{
	public class IoCConfig
	{
		public static void RegisterContainerConfiguration()
		{
			var builder = new ContainerBuilder();

			var assembly = typeof(MvcApplication).Assembly;
			builder.RegisterControllers(assembly);
			
			builder
				.RegisterAssemblyTypes(assembly)
				.AssignableTo<ICalculator>()
				.AsImplementedInterfaces();

			builder.RegisterType<CalculationService>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<CalculatorProvider>().AsImplementedInterfaces().SingleInstance();
			
			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}