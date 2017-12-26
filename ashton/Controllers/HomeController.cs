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
            //using (ISession session = NhibernateSession.OpenSession())  // Open  a session to conect to the database
            //{
            //	Assignment = session.Query<Assignment>().ToList(); //  Querying to get all the assignments
            //}
            Assignment = new List<Models.Assignment>();

            Assignment.Add(new Assignment { AssignmentID = 1735, CreatorPersonID = 735, AssignmentName = "Translate Word to Dutch", ExecutorPersonID = 212, KarmaValue = 30, Specifications = "You have to translate a German Word Text to the language Dutch" });
            Assignment.Add(new Assignment { AssignmentID = 64, CreatorPersonID = 845, AssignmentName = "Translate Word to French", ExecutorPersonID = 443, KarmaValue = 110, Specifications = "You have to translate a German Word Text to the language Dutch" });
            Assignment.Add(new Assignment { AssignmentID = 1664, CreatorPersonID = 624, AssignmentName = "Translate Word to Spain", ExecutorPersonID = 73, KarmaValue = 20, Specifications = "You have to translate a German Word Text to the language Dutch" });
            Assignment.Add(new Assignment { AssignmentID = 2564, CreatorPersonID = 552, AssignmentName = "Translate Word to Mandarin", ExecutorPersonID = 214, KarmaValue = 67, Specifications = "You have to translate a German Word Text to the language Dutch" });
            var model = new AshtonHomeModel(Assignment);
            return View(model);
		}

		public PartialViewResult SignUp()
		{
			return PartialView();
		}
	}
}