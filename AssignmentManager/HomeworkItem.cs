using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	enum StatusType { Open = 0, Code = 1, Video = 2, Done = 3 }
	class HomeworkItem
	{

		#region properties	

		/// <summary>
		/// State of the HomeworkItem
		/// Open: The HomeworkItem hasn’t been solved
		/// Code: The student has write the code that solve the problem
		/// Video: The student has record the video explaining how to solve the problem
		/// Done: Means the student have record the video and have write the code.
		/// </summary>

		public StatusType Status { get; set; }
		/// <summary>
		/// Text with any issue found by the teacher( For example: Try to find a better solution in order to reduce the time complexity  -  The explanation was not clear so record again the video  -Record the Video Again)
		/// </summary>
		public string ActionRequired { get; set; }
		public DateTime PersonalDueDate { get; set; }
		public Problem Problem { get; set; }
		public Homework Homework { get; set; }

		#endregion
		#region Methods
		public void Display() {
			Console.WriteLine($" TYPE: {Problem.Type} STATUS: {Status}  PERSONALDUEDATE: {PersonalDueDate} PROBLEM: {Problem.Description} ACTIONREQUIRED: {ActionRequired} ");
			
		}

		#endregion
	}
}
