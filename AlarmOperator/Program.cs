using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace AlarmOperator
{
	internal class Program
	{
		[System.STAThreadAttribute()]
		internal static void Main(string[] Args)
		{
			try
			{
				AlarmOperator.App app = new AlarmOperator.App();
				app.InitializeComponent();
				app.Run();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] Args) => Host
			.CreateDefaultBuilder(Args)
			.ConfigureServices(App.ConfigureServices)
		;
	}
}
