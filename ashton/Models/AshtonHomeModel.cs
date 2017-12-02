using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ashton.Models
{
	public class AshtonHomeModel
	{
		private List<Assignment> _assignments;

		public AshtonHomeModel(List<Assignment> assignments)
		{
			_assignments = assignments;
		}

		public List<Assignment> Assignments
		{
			get => _assignments;
			set => _assignments = value;
		}
	}
}