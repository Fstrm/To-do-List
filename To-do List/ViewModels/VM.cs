using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using To_do_List.Models;

namespace To_do_List.ViewModels
{
	class VM
	{
		public ObservableCollection<TaskItem> TaskList { get; set; }

		public ICommand AddTask { get; }

		public ICommand RemoveTask { get; }

		public ICommand WriteToFile { get; }

		public VM()
		{
			TaskList = new ObservableCollection<TaskItem>();
		}
	}
}
