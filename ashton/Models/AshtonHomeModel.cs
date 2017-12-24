using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ashton.Models
{
	public class AshtonHomeModel
	{
		private List<Assignment> _assignments;
		public AssignmentListModel AssignmentListModel;

		public AshtonHomeModel(List<Assignment> assignments)
		{
			_assignments = assignments;
			AssignmentListModel = new AssignmentListModel(assignments);
		}

		public List<Assignment> Assignments
		{
			get => _assignments;
			set => _assignments = value;
		}
	}
}