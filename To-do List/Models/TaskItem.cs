using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List.Models
{
	class TaskItem
	{
		public string Name { get; set; }
		public bool Completed { get; set; } = false;

		public TaskItem(string taskName)
		{
			Name = taskName;
		}
	}
}
