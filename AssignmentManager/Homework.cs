using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManager
{
	/// <summary>
	///Group of  problems the student has to solve in order to pass the course. 
	/// </summary>
	class Homework
	{
		#region properties



		public string Title { get; set; }
		public string Description { get; set; }
		/// <summary>
		/// Problems that have to be solved by dueDate
		/// </summary>
		public Problem[] Problems { get; set; }




		#endregion
	}
}
