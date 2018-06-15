using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	/// <summary>
	/// Catalog with the assignments for each course
	/// </summary>
	class Assignment
	{

		private static int ID = 0;
		#region Properties
		public int IDNumber { get; private set; }
		public string Description { get; set; }
		public string Title  { get; set; }
		public Course Course { get; set; }
		public int WeekNumber { get; set; }
		public List<Problem> Problems { get; }
		#endregion

		#region Methods

		public Assignment() {
			IDNumber = ID++;
		}

		public Assignment(string title, string desc, Course c,int weekNumber)
		{
			IDNumber = ID++;
			Title = title;
			Description = desc;
			Course = c;
			WeekNumber = weekNumber;
			Problems = new List<Problem>();
		}


		public void Display() {
			
			Console.WriteLine($"ID: {IDNumber} TITLE: {Title}  DESC: {Description} COURSE: {Course.Name} ");
		}

		public void DisplayProblems() {
			Console.WriteLine("PROBLEMS");
			foreach (Problem p in Problems) {
				Console.WriteLine($" DS: {p.DataStructure} - {p.Description}");
			}
		}

		
		public void AddProblem(Problem p) {
			Problems.Add(p);		
		}

		public void RemoveProblem(Problem p) {
			Problems.Remove(p);
		}
		
		#endregion
	}
}
