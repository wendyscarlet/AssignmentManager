	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	
	enum DataStructureType { Array = 0, Stack = 1, String = 2, Tree = 3, Queue = 4 }
	enum ProblemType { By};
	/// <summary>
	/// Catalog with the exercises the student has to solve
	/// </summary>
	class Problem
	{
		#region properties	
		public string Description { get; set; }
		/// <summary>
		/// Classification of the problem.
		/// </summary>
		public DataStructureType DataStructure { get; set; }			
		/// <summary>									   
		/// The list of the assignments that use the problem.								   
		/// </summary>
		public List<Assignment> Assignments { get;}
		#endregion
	}
}
