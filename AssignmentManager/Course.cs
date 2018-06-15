using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	/// <summary>
	/// Catalog with all the courses available in the academy.
	/// </summary>
	class Course
	{


		#region Properties
		private static int courseNumber = 0;
		/// <summary>
		/// Unique identification number for the course
		/// </summary>
		public string ID { get; private set; }
		public string Name { get; set; }
		/// <summary>
		/// Short Explanation about the course
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// How many weeks takes to teach all the content of the course.
		/// </summary>
		public int Duration { get; set; }
		/// <summary>
		/// All the assignments the student must do in order to pass the course.
		/// </summary>
		public List<Assignment> Assignments { get;}
		#endregion


		#region methods

	
		public Course(string prefixForID,string name, string des, int duration) {
			ID = prefixForID + courseNumber++;
			Name = name;
			Description = des;
			Duration = duration;
			Assignments = new List<Assignment>();
		}


		public void AddAssignment(Assignment a) {
			Assignments.Add(a);
			a.Course = this;
		}

		public void Display() {
			Console.WriteLine("*********** COURSE  *****************");
			Console.WriteLine($"ID: {ID}   NAME: {Name}   DURATION: {Duration}");
			Console.WriteLine($"DESCRIPTION: {Description}");
		}

		public void DisplayAssignments() {
			Console.WriteLine("ASSIGNMENTS OF THE COURSE");
			foreach (Assignment a in Assignments) {
				a.Display();
			}
		}

		#endregion
	}
}
