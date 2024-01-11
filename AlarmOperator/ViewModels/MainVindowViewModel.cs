
using System.Collections.ObjectModel;

using AlarmOperator.ViewModels.Base;
using AlarmOperator.Models.DataView;

namespace AlarmOperator.ViewModels
{
	internal class MainVindowViewModel : BaseViewModel
	{
		#region Свойства

		#region Title
		private string? _Title = string.Empty;
		public string Title { get => _Title; set => Set(ref _Title, value); }
		#endregion

		#region Завершение сбора данных
		private bool bWorkService;
		public bool BWorkService { get => bWorkService; set => Set(ref bWorkService, value); }
		#endregion

		#region Данные представления
		public ObservableCollection<DataPackage> DataDown { get; } = new ObservableCollection<DataPackage>();
		public ObservableCollection<DetalModel> DetalModels { get; } = new ObservableCollection<DetalModel>();
		#endregion

		#region Выбранная сработка
		///// <summary>  /// Выбранная сработка   /// </summary>
		private DataPackage _SelectedDrawDown;
		public DataPackage SelectedDrawDown
		{
			get => _SelectedDrawDown;
			set
			{
				if (Set(ref _SelectedDrawDown, value))
				{
					//_ItemService._evendSelectedItem();
					App.IsButtonsEnable = true;
				}
			}
		}
		#endregion

		#region _selectedIndex
		private int _selectedIndex;
		public int SelectedIndex { get => _selectedIndex; set => Set(ref _selectedIndex, value); }
		#endregion

		#region _selectedItemLZAK
		private DetalModel _selectedItemLZAK;
		public DetalModel SelectedItemLZAK { get => _selectedItemLZAK; set => Set(ref _selectedItemLZAK, value); }
		#endregion

		public ObservableCollection<NumContract> NumContracts { get; } = new ObservableCollection<NumContract>();

		#region NumContract
		private NumContract _selectedItemNContract;
		public NumContract SelectedItemNContract { get => _selectedItemNContract; set => Set(ref _selectedItemNContract, value); }
		#endregion

		#region _SelectedIndexNC
		private int _SelectedIndexNC;
		public int SelectedIndexNC { get => _SelectedIndexNC; set => Set(ref _SelectedIndexNC, value); }
		#endregion



		#endregion

		public MainVindowViewModel()
		{
			Title = "Стартовое окно";
		}
	}
}
