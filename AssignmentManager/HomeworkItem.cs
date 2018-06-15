using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	class HomeworkItem
	{

		#region properties		
		/// <summary>
		/// Text with any issue found by the teacher( For example: Try to find a better solution in order to reduce the time complexity  -  The explanation was not clear so record again the video  -Record the Video Again)
		/// </summary>
		public string ActionRequired { get; set; }
		public DateTime PersonalDueDate { get; set; }
		public Problem Problem { get; set; }
		public Homework Homework { get; set; }
	
		#endregion
	}
}
