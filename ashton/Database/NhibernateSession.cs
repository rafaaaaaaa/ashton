using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace ashton
{
	public class NhibernateSession
	{
		public static ISession OpenSession()
		{
            //var configuration = new Configuration();
            //var configurationPath = HttpContext.Current.Server.MapPath(@"~\Database\hibernate.cfg.xml");
            //configuration.Configure(configurationPath);
            //var assignmentconfigfile = HttpContext.Current.Server.MapPath(@"~\Database\Mappings\Assignment.hbm.xml");
            //configuration.AddFile(assignmentconfigfile);
            //ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            //return sessionFactory.OpenSession();
            return null;
		}
	}
}