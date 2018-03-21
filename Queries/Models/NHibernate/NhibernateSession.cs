﻿using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queries.Models
{
    public class NhibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var queryConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mappings\Query.hbm.xml");
            var userConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mappings\User.hbm.xml");
            configuration.AddFile(queryConfigurationFile);
            configuration.AddFile(userConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}