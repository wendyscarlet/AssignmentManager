using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	 
	class Homework
	{
		#region Properties
		public bool Done  { get; set; }
		/// <summary>
		/// Can be used to write something the student has to do, or a feedback received from the teacher, etc.
		/// </summary>								   
		public string Notes { get; set; }
		/// <summary>
		/// Date the assignment has to be submitted
		/// </summary>
		public DateTime DueDate { get; set; }
		/// <summary>
		/// The student can use this date to stablish a personal date to finish the Homework.
		/// </summary>
		public DateTime PersonalDueDate { get; set; }
		public List<HomeworkItem> HomeworkItems { get; }
		public Assignment Assignment { get; set; }
		#endregion

		#region Methods

		public Homework() {
		
			HomeworkItems = new List<HomeworkItem>();

		}

		public void Display() {
			Console.WriteLine($"DUEDATE: {DueDate} Done: {Done}  NOTES: {Notes}  PERSONALDUEDATE: {PersonalDueDate}");
		}

		public void DisplayItems() {

			foreach (HomeworkItem hi in HomeworkItems) {
				hi.Display();
			}
		}

		public void AddHomeworkItems(HomeworkItem hwi) {
			HomeworkItems.Add(hwi);
		}

		public void RemoveHomeworkItems(HomeworkItem hwi)
		{
			HomeworkItems.Remove(hwi);
		}
		

		#endregion
	}
}
