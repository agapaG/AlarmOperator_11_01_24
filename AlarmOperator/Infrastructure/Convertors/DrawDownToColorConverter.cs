using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


using AlarmOperator.Models.DataView;
namespace AlarmOperator.Infrastructure.Convertors
{
	public class DrawDownToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var ColorType = (DataPackage)value;

			if (ColorType != null)
			{

				Brush Color;

				switch (ColorType.Color)
				{
					case 1: Color = Brushes.OrangeRed; break;
					case 2: Color = Brushes.Yellow; break;
					case 3: Color = Brushes.LightGreen; break;
					//case 4: Color = Brushes.LightGray; break;
					default: throw new NotImplementedException();
				}
				return Color;
			}
			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

	}

}
