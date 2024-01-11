
using Microsoft.Extensions.DependencyInjection;

namespace AlarmOperator.ViewModels
{
	internal class ViewModelLocator
	{
		public MainVindowViewModel MainViewModel =>
			App.Services.GetRequiredService<MainVindowViewModel>();

		public DrawDownRegisterViewModel DDRegisterViewModel =>
			App.Services.GetRequiredService<DrawDownRegisterViewModel>();

	}
}
