﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ashton.Models
{
	public class Assignment
	{
		public virtual long AssignmentID { get; set; }
		public virtual string AssignmentName { get; set; }
		public virtual long CreatorPersonID { get; set; }
		public virtual long ExecutorPersonID { get; set; }
		public virtual int KarmaValue { get; set; }
		public virtual string Specifications { get; set; }
	}
}