using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{

	class Assignment
	{

		private static int ID = 0;
		#region Properties
		public int IDNumber { get; set; }
		public string Description { get; set; }
		public string Title  { get; set; }
		public Course Course { get; set; }
		public List<Problem> Problems { get; }
		#endregion

		#region Methods

		public Assignment(string title, string desc,Course c) {
			IDNumber = ID++;
			Title = title;
			Description = desc;
			Course = c;
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
