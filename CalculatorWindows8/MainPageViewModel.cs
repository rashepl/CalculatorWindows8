using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorWindows8
{
	public class MainPageViewModel
	{
		#region member variables
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
		public ICommand SelectFiveuttonCommand
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

		}

		/// <summary>
		/// select the eight button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectEightButton(object sender)
		{

		}

		/// <summary>
		/// select the nine button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectNineButton(object sender)
		{

		}

		/// <summary>
		/// select the four button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectFourButton(object sender)
		{

		}

		/// <summary>
		/// select the five button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectFiveButton(object sender)
		{

		}

		/// <summary>
		/// select the six button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectSixButton(object sender)
		{

		}

		/// <summary>
		/// select the one button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectOneButton(object sender)
		{

		}

		/// <summary>
		/// select the two button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectTwoButton(object sender)
		{

		}

		/// <summary>
		/// select the three button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectThreeButton(object sender)
		{

		}

		/// <summary>
		/// select the zero button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectZeroButton(object sender)
		{

		}

		/// <summary>
		/// select the equals button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectEqualsButton(object sender)
		{

		}

		/// <summary>
		/// select the add button
		/// </summary>
		/// <param name="sender"></param>
		private void SelectAddButton(object sender)
		{

		}

		#endregion

		#region event handlers
		#endregion
	}
}
