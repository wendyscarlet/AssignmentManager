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
			Assignment assign1 = School.CreateAssignment("Week I", "Exercises about arrays", course,1);
			Assignment assign2 = School.CreateAssignment("Week II", "Exercises about staks", course,2);
			Assignment assign3 = School.CreateAssignment("Week III", "Exercises about trees", course,3);

			Problem p1 = School.CreateProblem("Given an array that contains numbers from 1 to n­1 and .....", DataStructureType.Array, ProblemType.Mandatory, assign1);
			Problem p2 = School.CreateProblem("Given an array of numbers, split the array into ... ..", DataStructureType.Array, ProblemType.Mandatory, assign1);
			Problem p3 = School.CreateProblem("Print an Array", DataStructureType.Array, ProblemType.Mandatory, assign1);
			course.Display();
			course.DisplayAssignments();
			assign1.DisplayProblems();



			Class cl = School.CreateClass("ALG", new DateTime(2018, 07, 01), new DateTime(2018, 12, 15), course);
			Student s = School.CreateAndEnrollStudent("Doe", "John", "JohnDoe@mail.com", "Address", cl);
			Student s2 = School.CreateAndEnrollStudent("Doe", "Jane", "JoneDoe@mail.com", "My Address", cl);
			course.Display();
			cl.Display();
			cl.DisplayStudents();
			Console.WriteLine("**********Homework for Student 1 ***********************");
			//Homework and Items generated automatically based in the catalog Assigment and Problem
			s.DisplayHomework();
			
			Console.ReadKey();
			
		}
	}
}
