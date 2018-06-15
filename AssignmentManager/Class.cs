using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	class Class
	{
		#region Properties
		private static int classNumber = 0;
		/// <summary>
		/// Unique identifier
		/// </summary>
		public string ID { get; set; }
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
		public List <Student> Students { get;}

		#endregion

		#region Methods

		
		
		public Class(string classPrefix,DateTime startDate, DateTime finishDate) {
			ID = classPrefix + ++classNumber;

			if (startDate < DateTime.Today)
				throw new ArgumentException(string.Format("{0} : {1} must be grater than today", nameof(startDate), startDate), nameof(startDate));

			if (startDate > finishDate)
				throw new ArgumentException(string.Format("{0} : {1} must be grater than {2} : {3}", nameof(finishDate), finishDate, nameof(startDate), startDate), nameof(finishDate));

			StartDate = startDate;
			FinishDate = finishDate;
			Students = new List<Student>();

		}

		public void Display() {
	
			Console.WriteLine($"CLASS  ID: {ID}   StartDate: {StartDate}   FinishDate: {FinishDate}");
		}

		public void DisplayStudents() {
			Console.WriteLine("Students");
			foreach (Student s in Students) {
				s.Display();
			}

		}
		public void EnrollStudent(Student s) {
			Students.Add(s);
		}

		public void DisEnrollStudent(Student s) {
			Students.Remove(s);
		}

		#endregion

	}
}
