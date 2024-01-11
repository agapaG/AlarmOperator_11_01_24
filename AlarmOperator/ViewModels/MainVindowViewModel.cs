
using AlarmOperator.ViewModels.Base;

namespace AlarmOperator.ViewModels
{
	internal class MainVindowViewModel : BaseViewModel
	{
		#region Свойства

		#region Title
		private string? _Title = string.Empty;
		public string Title { get => _Title; set => Set(ref _Title, value); }
		#endregion
		#endregion

		public MainVindowViewModel()
		{
			Title = "Стартовое окно";
		}
	}
}
