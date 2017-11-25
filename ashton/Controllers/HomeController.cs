using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ashton.Models;
using NHibernate;

namespace ashton.Controllers
{
	public class HomeController : Controller
	{
		public List<Assignment> Assignment { get; private set; }

		public ActionResult AshtonHome()
		{
			using (ISession session = NhibernateSession.OpenSession())  // Open  a session to conect to the database
			{
				Assignment = session.Query<Assignment>().ToList(); //  Querying to get all the assignments
			}

			

			return View();
		}	
	}
}