using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace To_do_List.ViewModels
{
	class RelayParametrizedCommand<T> : ICommand
	{
		private Action<T> mAction;

		public RelayParametrizedCommand(Action<T> passedAction)
		{
			mAction = passedAction;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			mAction((T)parameter);
		}
	}
}
