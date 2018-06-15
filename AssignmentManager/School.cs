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
		
		 public static Course CreateCourse(string prefixForID,string name,string desc,int duration) {
			return  new Course(prefixForID,name,desc,duration);
		}

		public static Class CreateClass(string classPrefix, DateTime startDate, DateTime finishDate) {
			return new Class(classPrefix, startDate, finishDate);
		}

		public static Assignment CreateAssignment(string title, string desc, Course c) {
			return new Assignment(title,desc,c);
		}

		public static Student CreateStudent(string lastName,string firstName,string email, string addr,string middleName = null) {

			Student newStudent = new Student
			{
				LastName = lastName,
				FirstName = firstName,
				Email = email,
				Address = addr,
				MiddleName= middleName
			};
			return newStudent;
		}

		public static void EnrollStudentToClass(Class c, Student s) {
			c.EnrollStudent(s);
			s.EnrollInClass(c);
		}

		public static void DisenrollStudentFromClass(Class c, Student s) {
			c.DisEnrollStudent(s);
			s.DisenrollFromClass(c);
		}

		static public Student CreateAndEnrollStudent(string lastName, string firstName, string email, string addr, Class c, string middleName = null) {
			Student s = CreateStudent(lastName,firstName,email,addr,middleName);
			EnrollStudentToClass(c, s);
			return s;
		}

	}
}
