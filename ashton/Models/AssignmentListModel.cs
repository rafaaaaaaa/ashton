using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ashton.Models
{
	public class AssignmentListModel
	{
		public List<AssignmentModel> Assigments;
		public AssignmentListModel(List<Assignment> assignments)
		{
			Assigments = new List<AssignmentModel>();
			foreach (Assignment assigment in assignments)
			{
				createassignment(assigment);
			}
		}


		private void createassignment(Assignment assignment)
		{
			Assigments.Add(new AssignmentModel(assignment));
		}
	}
}