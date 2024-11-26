﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.DB.Helper;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;



namespace DataAccess.Helpers
{
    public class PostgresHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            var build = Fluently
                .Configure()
                .Database(PostgreSQLConfiguration.PostgreSQL82)
                .Mappings(p => p.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
            return build;
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }

        

    }
}