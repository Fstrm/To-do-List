using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using To_do_List.Models;

namespace To_do_List.ViewModels
{
	class VM
	{
		private string path;

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

		public ICommand WriteToFile
		{
			get
			{
				return new RelayParametrizedCommand<ObservableCollection<string>>(obj =>
				{
					if (obj.Count != 0)
					{
						using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
						{
							foreach (var task in obj)
							{
								sw.WriteLine(task);
							}
						}
					}
				});
			}
		}

		public VM()
		{
			TaskList = new ObservableCollection<string>();
			path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\tasks.txt";
			
			if (!File.Exists(path))
				File.Create(path);
			using (StreamReader sr = new StreamReader(path))
			{
				string task;
				while((task = sr.ReadLine()) != null)
				{
					TaskList.Add(task);
				}
			}
			MessageBox.Show(path);
		}
	}
}
