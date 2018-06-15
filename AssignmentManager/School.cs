using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	/// <summary>
	/// Factory Class
	/// </summary>
	  static class  School
	{
		
		 static Course CreateCourse(string prefixForID,string name,string desc,int duration) {
			return  new Course(prefixForID,name,desc,duration);
		}

		static Assignment CreateAssignment(string title, string desc, Course c) {
			return new Assignment(title,desc,c);
		}

		

	}
}
