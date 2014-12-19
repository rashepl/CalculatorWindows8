using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorWindows8
{
	public class MainPageViewModel : NotifyingViewModel
	{
		#region member variables

		/// <summary>
		/// track the selected user value
		/// </summary>
		private string _selectedValueDisplayed = string.Empty;

		/// <summary>
		/// tracks the calculation entered by the user
		/// </summary>
		private string _equation = string.Empty;

		/// <summary>
		/// tracks indication if the user has entered an initial value to start an equation
		/// </summary>
		private bool _firstValueEntered = false;

		/// <summary>
		/// tracks the value selected by the user upon pressing a numeric button
		/// </summary>
		private int _selectedValue = 0;

		/// <summary>
		/// tracks indication if the calculator is in a state ready to calculate an equation
		/// </summary>
		private bool _calculate = false;

		/// <summary>
		/// tracks indication if the last entry by the user was an operand
		/// </summary>
		private bool _operandEnteredLast = false;

		/// <summary>
		/// tracks the last entered operand
		/// </summary>
		private string _lastEnteredOperand = string.Empty;

		#endregion

		#region properties

		/// <summary>
		/// gets the select seven button command 
		/// </summary>
		public ICommand SelectSevenButtonCommand
		{
			get { return new RelayCommand(SelectSevenButton); }
		}

		/// <summary>
		/// gets the select eight button command 
		/// </summary>
		public ICommand SelectEightButtonCommand
		{
			get { return new RelayCommand(SelectEightButton); }
		}

		/// <summary>
		/// gets the select nine button command 
		/// </summary>
		public ICommand SelectNineButtonCommand
		{
			get { return new RelayCommand(SelectNineButton); }
		}

		/// <summary>
		/// gets the select four button command 
		/// </summary>
		public ICommand SelectFourButtonCommand
		{
			get { return new RelayCommand(SelectFourButton); }
		}

		/// <summary>
		/// gets the select five button command 
		/// </summary>
		public ICommand SelectFiveButtonCommand
		{
			get { return new RelayCommand(SelectFiveButton); }
		}

		/// <summary>
		/// gets the select six button command 
		/// </summary>
		public ICommand SelectSixButtonCommand
		{
			get { return new RelayCommand(SelectSixButton); }
		}

		/// <summary>
		/// gets the select one button command 
		/// </summary>
		public ICommand SelectOneButtonCommand
		{
			get { return new RelayCommand(SelectOneButton); }
		}

		/// <summary>
		/// gets the select two button command 
		/// </summary>
		public ICommand SelectTwoButtonCommand
		{
			get { return new RelayCommand(SelectTwoButton); }
		}

		/// <summary>
		/// gets the select three button command 
		/// </summary>
		public ICommand SelectThreeButtonCommand
		{
			get { return new RelayCommand(SelectThreeButton); }
		}

		/// <summary>
		/// gets the select zero button command 
		/// </summary>
		public ICommand SelectZeroButtonCommand
		{
			get { return new RelayCommand(SelectZeroButton); }
		}

		/// <summary>
		/// gets the select equals button command 
		/// </summary>
		public ICommand SelectEqualsButtonCommand
		{
			get { return new RelayCommand(SelectEqualsButton); }
		}

		/// <summary>
		/// gets the select add button command 
		/// </summary>
		public ICommand SelectAddButtonCommand
		{
			get { return new RelayCommand(SelectAddButton); }
		}

		public ICommand SelectSubtractButtonCommand
		{
			get { return new RelayCommand(SelectSubtractButton); }
		}

		public ICommand SelectMultiplyButtonCommand
		{
			get { return new RelayCommand(SelectMultiplyButton); }
		}

		public ICommand SelectDivideButtonCommand
		{
			get { return new RelayCommand(SelectDivideButton); }
		}

		/// <summary>
		/// gets/sets the value selected by the user
		/// </summary>
		public string SelectedValueDisplayed
		{
			get { return _selectedValueDisplayed; }
			set
			{
				_selectedValueDisplayed = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// gets/sets the numeric value entered by the user
		/// </summary>
		private int SelectedValue
		{
			get { return _selectedValue; }
			set
			{
				_selectedValue = value;
			}
		}

		/// <summary>
		/// gets/sets the equation consisting of numbers and operands
		/// </summary>
		public string EquationDisplayed
		{
			get { return _equation; }
			set
			{
				_equation = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// gets/sets the first value entered
		/// </summary>
		private int CalculatedValue
		{
			get;
			set;
		}

		bool OperandEntered
		{
			get;
			set;
		}

		bool NumberEntered
		{
			get;
			set;
		}

		#endregion

		#region construction / destruction
		#endregion

		#region methods

		/// <summary>
		/// select the seven button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectSevenButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 7 : SelectedValue * 10 + 7;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the eight button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectEightButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 8 : SelectedValue * 10 + 8;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the nine button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectNineButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 9 : SelectedValue * 10 + 9;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the four button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectFourButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 4 : SelectedValue * 10 + 4;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the five button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectFiveButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 5 : SelectedValue * 10 + 5;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the six button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectSixButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 6 : SelectedValue * 10 + 6;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the one button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectOneButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 1 : SelectedValue * 10 + 1;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the two button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectTwoButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 2 : SelectedValue * 10 + 2;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the three button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectThreeButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 3 : SelectedValue * 10 + 3;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the zero button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectZeroButton(object sender)
		{
			SelectedValue = _operandEnteredLast ? 0 : SelectedValue * 10 + 0;
			_operandEnteredLast = false;

			if (!_firstValueEntered)
			{
				CalculatedValue = SelectedValue;
				_firstValueEntered = true;
			}

			SelectedValueDisplayed = SelectedValue.ToString();
		}

		/// <summary>
		/// select the equals button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectEqualsButton(object sender)
		{
			if (_firstValueEntered && _calculate)
			{
				EquationDisplayed = string.Empty;

				if (string.Compare(_lastEnteredOperand, "+") == 0)
				{
					CalculatedValue += CalculatedValue;
				}
				else if (string.Compare(_lastEnteredOperand, "-") == 0)
				{
					CalculatedValue -= CalculatedValue;
				}
				else if (string.Compare(_lastEnteredOperand, "*") == 0)
				{
					CalculatedValue *= CalculatedValue;
				}
				else if (string.Compare(_lastEnteredOperand, "/") == 0)
				{
					CalculatedValue /= CalculatedValue;
				}

				SelectedValueDisplayed = CalculatedValue.ToString();
			}
		}

		/// <summary>
		/// select the add button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectAddButton(object sender)
		{
			if (_firstValueEntered)
			{
				_operandEnteredLast = true;
				_lastEnteredOperand = "+";
				EquationDisplayed = EquationDisplayed != string.Empty ? string.Format("{0} {1} {2}", EquationDisplayed, SelectedValue.ToString(), "+") : string.Format("{0} {1}", SelectedValue.ToString(), "+");

				if (_calculate)
				{
					CalculatedValue += SelectedValue;
					SelectedValueDisplayed = CalculatedValue.ToString();
				}
				else
				{
					_calculate = true;
				}
			}
		}

		/// <summary>
		/// select the subtract button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectSubtractButton(object sender)
		{
			if (_firstValueEntered)
			{
				_operandEnteredLast = true;
				_lastEnteredOperand = "-";
				EquationDisplayed = EquationDisplayed != string.Empty ? string.Format("{0} {1} {2}", EquationDisplayed, SelectedValue.ToString(), "-") : string.Format("{0} {1}", SelectedValue.ToString(), "-");

				if (_calculate)
				{
					CalculatedValue -= SelectedValue;
					SelectedValueDisplayed = CalculatedValue.ToString();
				}
				else
				{
					_calculate = true;
				}
			}
		}

		/// <summary>
		/// select the multiply button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectMultiplyButton(object sender)
		{
			if (_firstValueEntered)
			{
				_operandEnteredLast = true;
				_lastEnteredOperand = "*";
				EquationDisplayed = EquationDisplayed != string.Empty ? string.Format("{0} {1} {2}", EquationDisplayed, SelectedValue.ToString(), "*") : string.Format("{0} {1}", SelectedValue.ToString(), "*");

				if (_calculate)
				{
					CalculatedValue *= SelectedValue;
					SelectedValueDisplayed = CalculatedValue.ToString();
				}
				else
				{
					_calculate = true;
				}
			}
		}

		/// <summary>
		/// select the divide button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectDivideButton(object sender)
		{
			if (_firstValueEntered)
			{
				_operandEnteredLast = true;
				_lastEnteredOperand = "/";
				EquationDisplayed = EquationDisplayed != string.Empty ? string.Format("{0} {1} {2}", EquationDisplayed, SelectedValue.ToString(), "/") : string.Format("{0} {1}", SelectedValue.ToString(), "/");

				if (_calculate)
				{
					CalculatedValue /= SelectedValue;
					SelectedValueDisplayed = CalculatedValue.ToString();
				}
				else
				{
					_calculate = true;
				}
			}
		}

		#endregion

		#region event handlers
		#endregion
	}
}
