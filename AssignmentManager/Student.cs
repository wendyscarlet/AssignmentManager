using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	/// <summary>
	/// Person taking classes
	/// </summary>
	class Student
	{
		#region properties
		/// <summary>
		/// Unique Number that identifies the student
		/// </summary>
		public int IDNumber { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		/// <summary>
		/// The email used to communicate with the student
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// The address where the student lives.
		/// </summary>
		public string Address { get; set; }
		/// <summary>
		/// The list of courses the Student is enrolled
		/// </summary>
		public Course [] Courses { get; set; }
		/// <summary>
		/// List of exercises the student must do in order to pass the course
		/// </summary>
		public Assignment Assignments { get; set; }
		#endregion

	}
}
