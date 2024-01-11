using System.Windows;

using AlarmOperator.Infrastructure.Commands.Base;
using AlarmOperator.Views.Windows;

namespace AlarmOperator.Infrastructure.Commands
{
	internal class ManageDDRegisterCommand : BaseCommand
	{
		private DarwDownRegisterWindow _Window;


		public override bool CanExecute(object parameter)
		{
			if (_Window == null)// && App.IsButtonsEnable)
				return true;
			return false;
		}

		public override void Execute(object parameter)
		{
			var window = new DarwDownRegisterWindow()
			{
				Owner = App.Current.MainWindow,
				WindowStartupLocation = WindowStartupLocation.CenterOwner,
			};

			_Window = window;

			window.Closed += Window_Closed;

			window.ShowDialog();
		}

		private void Window_Closed(object sender, System.EventArgs e)
		{
			((Window)sender).Closed -= Window_Closed;

			_Window = null;
		}
	}

}
