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

		#region Catalogs

		public static Course CreateCourse(string prefixForID,string name,string desc,int duration) {
			return  new Course(prefixForID,name,desc,duration);
		}
	

		public static Assignment CreateAssignment(string title, string desc, Course c, int weekNumber) {
			Assignment a= new  Assignment(title,desc,c,weekNumber);
			c.AddAssignment(a);
			return a;
		}

		public static Problem CreateProblem(string desc, DataStructureType dt,ProblemType t = ProblemType.CreatedByStudent, Assignment a = null)
		{
			Problem p = new Problem(desc,dt,t,a);
			if (a != null)
				a.AddProblem(p);
			return p;

		}


		#endregion


		public static Class CreateClass(string classPrefix, DateTime startDate, DateTime finishDate, Course c)
		{
			return new Class(classPrefix, startDate, finishDate, c);
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

		#region Enrollment

		public static void EnrollStudentToClass(Class c, Student s) {
			c.EnrollStudent(s);
			s.EnrollInClass(c);
			foreach (Assignment a in c.Course.Assignments) {
				s.AddHomework(HomeworkFactory.CreateHomeworkAndItems(c.StartDate, a));
			}
			
		}
		//Todo: Eliminate Homework when disenroll student. I am not sure
		public static void DisenrollStudentFromClass(Class c, Student s) {
			c.DisEnrollStudent(s);
			s.DisenrollFromClass(c);
		}

		
		static public Student CreateAndEnrollStudent(string lastName, string firstName, string email, string addr, Class c, string middleName = null) {
			Student s = CreateStudent(lastName,firstName,email,addr,middleName);
			EnrollStudentToClass(c, s);
			return s;
		}
		#endregion 
	}
}
