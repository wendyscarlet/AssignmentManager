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
		private static int studentNumber = 0;
		/// <summary>
		/// Unique Number that identifies the student
		/// </summary>
		public int ID { get; set; }
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
		public List <Class>  Classes { get; }
		/// <summary>
		/// List of Homeworks the student must do in order to pass the course
		/// </summary>
		public List <Homework> Homeworks { get; }
		#endregion

		#region Methods
		public Student() {
			ID = ++studentNumber;
			Classes = new List<Class>();
		}

		public void Display() {
			Console.WriteLine($"ID: {ID}  NAME: {FirstName} {MiddleName} {LastName} Email: {Email}  Address: {Address}");
		}

		public void EnrollInClass(Class c) {
			Classes.Add(c);
		}

		public void DisenrollFromClass(Class c) {
			Classes.Remove(c);
		}

		#endregion


	}
}
