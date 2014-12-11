using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorWindows8
{
	public class RelayCommand : ICommand
	{
		#region events

		/// <summary>
		/// event that gets fired when our ability to execute the command has changed
		/// </summary>
		public event EventHandler CanExecuteChanged;
		protected virtual void OnCanExecuteChanged()
		{
			EventHandler handler = CanExecuteChanged;
			if (handler != null)
			{
				handler(this, new EventArgs());
			}
		}

		#endregion

		#region member variables

		/// <summary>
		/// tracks a parameterless delegate method which determines if a command can execute
		/// </summary>
		private Func<bool> _canExecute;

		/// <summary>
		/// delegate method with one parameter and no return type which performs execution of a command
		/// </summary>
		private Action<object> _execute;

		#endregion

		#region properties
		#endregion

		#region construction / destruction

		/// <summary>
		/// construct the command relay, passing in the delegate to execute
		/// </summary>
		/// <param name="execute">delegate which executes the command</param>
		public RelayCommand(Action<object> execute)
		{
			_execute = execute;
			_canExecute = null;
		}

		/// <summary>
		/// construct the command relay, passing in the delegate to execute the command and the delegate to determine if the command can be executed
		/// </summary>
		/// <param name="execute">delete which executes the command</param>
		/// <param name="canExecute">delegate which determines if the command can be executed</param>
		public RelayCommand(Action<object> execute, Func<bool> canExecute)
		{
			_execute = execute;
			_canExecute = canExecute;
		}

		#endregion

		#region methods

		/// <summary>
		/// determine if the command can be executed
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		bool ICommand.CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute();
		}

		/// <summary>
		/// execute the command
		/// </summary>
		/// <param name="parameter"></param>
		void ICommand.Execute(object parameter)
		{
			_execute(parameter);
		}

		#endregion

		#region event handlers
		#endregion
	}
}
