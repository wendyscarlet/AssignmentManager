	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	
	enum DataStructureType { Array = 0, Stack = 1, String = 2, Tree = 3, Queue = 4 }
	enum ProblemType { Optional=0, Mandatory=1};
	
	/// <summary>
	/// Catalog with the exercises the student has to solve
	/// </summary>
	class Problem
	{
		#region properties	

		static private int ProblemID = 0;
		public int ID { get; set; }
		public string Description { get; set; }
		/// <summary>
		/// Classification of the problem.
		/// </summary>
		public DataStructureType DataStructure { get; set; }
		/// <summary>									   
		/// The list of the assignments that use the problem.								   
		/// </summary>
		public ProblemType Type { get; set; }
		public List<Assignment> Assignments { get;}
		#endregion

		#region Methods
		public Problem(string desc,DataStructureType dt, ProblemType t=ProblemType.Mandatory) {
			ID = ++ProblemID;
			Description = desc;
			DataStructure = dt;
			Type = t;
		}

		public void AddAssignment(Assignment a) {
			Assignments.Add(a);
		}
		public void RemoveAssigment(Assignment a) {
			Assignments.Remove(a);
		}
		#endregion
	}
}
