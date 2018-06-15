using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManager
{
	static class HomeworkFactory
	{
		public static Homework CreateHomework( DateTime classStartDate,Assignment a) {


			return new Homework {
				DueDate = classStartDate,
				Done = false,
				Assignment = a
			};
		}

		public static Homework CreateHomeworkAndItems( DateTime classStartDate, Assignment a)
		{
			Homework newHomework = CreateHomework(classStartDate, a);
			foreach (Problem p in a.Problems) {
				HomeworkItem item = new HomeworkItem {
					Problem = p,
					Homework = newHomework,
					Status = StatusType.Open
				};
				newHomework.AddHomeworkItems(item);
			}
			return newHomework;
		}

		//private DateTime CalculateDueDate(DateTime startDate, int weekNumber) {

		//}

	}
}
