using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManager
{
	/// <summary>
	/// Catalog with all the courses available in the academy.
	/// </summary>
	class Course
	{
		#region Properties
		/// <summary>
		/// Unique identification number for the course
		/// </summary>
		public int IDNumber { get; set; }
		public string Name { get; set; }
		/// <summary>
		/// Short Explanation about the course
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// How many weeks takes to teach all the content of the course.
		/// </summary>
		public int Duration { get; set; }
		public Homework []  Homework { get; set; }
		#endregion

	}
}
