using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using To_do_List.Models;

namespace To_do_List.ViewModels
{
	class VM
	{
		//public ObservableCollection<TaskItem> TaskList { get; set; }
		public ObservableCollection<string> TaskList { get; set; }

		public ICommand AddTask
		{
			get
			{
				return new RelayParametrizedCommand<string>(obj => TaskList.Add(obj));
			}
		}

		public ICommand RemoveTask
		{
			get
			{
				return new RelayParametrizedCommand<int>(obj => TaskList.RemoveAt(obj));
			}
		}

		public ICommand WriteToFile { get; }

		public VM()
		{
			TaskList = new ObservableCollection<string>();
		}
	}
}
