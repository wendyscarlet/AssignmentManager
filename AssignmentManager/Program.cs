using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	class Program
	{
		static void Main(string[] args)
		{
			Course course= School.CreateCourse("CC", "Algorithms I", "The student learn how to crack the coding interview", 4);
			Class cl = School.CreateClass("ALG", new DateTime(2018, 07, 01), new DateTime(2018, 12, 15), course);
			Student s = School.CreateAndEnrollStudent("Doe", "John", "JohnDoe@mail.com", "Address", cl);
			Student s2 = School.CreateAndEnrollStudent("Doe", "Jane", "JoneDoe@mail.com", "My Address", cl);
			course.Display();
			cl.Display();
			cl.DisplayStudents();
			Console.ReadKey();
			

		}
	}
}
