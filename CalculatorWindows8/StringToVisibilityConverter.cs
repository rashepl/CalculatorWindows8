using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace CalculatorWindows8
{
	public class StringToVisibilityConverter : IValueConverter
	{
		object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
		{
			Visibility isVisible = Visibility.Collapsed;
			if (!string.IsNullOrEmpty(value.ToString()))
			{
				isVisible = Visibility.Visible;
			}
			return isVisible;
		}

		object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return Visibility.Visible;
		}
	}
}
