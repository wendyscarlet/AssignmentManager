using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManager
{
	class Class
	{
		#region Properties
		/// <summary>
		/// Unique identifier
		/// </summary>
		public int IDNumber { get; set; }
		/// <summary>
		/// First day of class
		/// </summary>
		public DateTime StartDate { get; set; }
		/// <summary>
		/// Last day of class
		/// </summary>
		public DateTime FinishDate { get; set; }	
		/// <summary>
		/// List of all the students enrolled in the class
		/// </summary>
		public Student [] Students { get; set; }

		#endregion

	}
}
