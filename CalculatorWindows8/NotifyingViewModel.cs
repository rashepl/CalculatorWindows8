using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalculatorWindows8
{
	public class NotifyingViewModel : INotifyPropertyChanged
	{
		#region events

		/// <summary>
		/// event that gets fired when a property changes
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null && !string.IsNullOrEmpty(propertyName))
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
     
		#endregion

		#region member variables
		#endregion

		#region properties
		#endregion

		#region construction / destruction
		#endregion

		#region methods
		#endregion

		#region event handlers
		#endregion
	}
}
