
using Microsoft.Extensions.DependencyInjection;

namespace AlarmOperator.ViewModels
{
	internal static class ViewModelRegistrator
	{
		public static IServiceCollection RegisterViewModel(this IServiceCollection services) => services
			.AddSingleton<MainVindowViewModel>()
		;
	}
}
