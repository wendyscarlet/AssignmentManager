using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManager
{

	class Assignment
	{
		#region Properties
		/// <summary>
		/// State of the Assignment
		/// Open: The assignment hasn’t been solved
		/// Code: The student has write the code that solve the problem
		/// Video: The student has record the video explaining how to solve the problem
		/// Done: Means the student have record the video and have write the code.
		/// </summary>
		enum StatusType { Open = 0, Code = 1, Video = 2, Done = 3 }
		public int Status { get; set; }
		/// <summary>
		/// Can be used to write something the student has to do, or a feedback received from the teacher, etc.
		/// </summary>
		public string Notes { get; set; }
		/// <summary>
		/// Date the assignment has to be submitted
		/// </summary>
		public DateTime DueDate { get; set; }
		/// <summary>
		/// The student can use this date to stablish a personal date to finish the assignment.
		/// </summary>
		public DateTime PersonalDueDate { get; set; }
		public Problem Problem { get; set; }
		#endregion
	}
}
