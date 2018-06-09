	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManager
{
	/// <summary>
	/// Catalog with the exercises the student has to solve
	/// </summary>
	class Problem
	{
		#region properties		
		/// <summary>
		/// Classification of the problem.
		/// </summary>
		enum DataStructureType { Array = 0, Stack = 1, String = 2, Tree = 3, Queue = 4 }
		public int DataStructure { get; set; }
		public string Description { get; set; }
		/// <summary>
		/// The list of the assignments that use the problem.
		/// </summary>
		public Assignment Assignments { get; set; }
		#endregion
	}
}
