	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	
	enum DataStructureType { Array = 0, Stack = 1, String = 2, Tree = 3, Queue = 4 }
	enum ProblemType { CreatedByStudent=0, Mandatory=1};
	
	/// <summary>
	/// Catalog with the exercises the student has to solve
	/// </summary>
	class Problem
	{
		#region properties	

		static private int ProblemID = 0;
		public int ID { get; private set; }
		public string Description { get; set; }
		/// <summary>
		/// Classification of the problem.
		/// </summary>
		public DataStructureType DataStructure { get; set; }
		/// <summary>									   
		/// The list of the assignments that use the problem. A Problem can exists without and Assignment								   
		/// </summary>
		public ProblemType Type { get; set; }
		public List<Assignment> Assignments { get;}
		#endregion

		#region Methods
		public Problem(string desc,DataStructureType dt,ProblemType t=ProblemType.Mandatory, Assignment a=null) {

			if(t == ProblemType.Mandatory && a == null)
				throw new ArgumentException("When Problem type is mandadory, the problem must have an Assignment",nameof(a));
			if (t == ProblemType.CreatedByStudent && a != null)
				throw new ArgumentException("When Problem type is CreatedByStudent, the problem cannot have an Assignment", nameof(a));

			Assignments = new List<Assignment> ();
			ID = ++ProblemID;
			Description = desc;
			DataStructure = dt;
			Type = t;
			AddAssignment(a);
			
		}

		public void Display() {
			Console.WriteLine($"ProblemID: {ProblemID}  Type: {Type}  DS: {DataStructure} Description: {Description}");
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
