using System;
using System.Globalization;
using System.Windows.Data;

namespace AlarmOperator.Infrastructure.Convertors.Base
{
	public abstract class Convertor : IValueConverter
	{
		public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

		public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

	}

}
