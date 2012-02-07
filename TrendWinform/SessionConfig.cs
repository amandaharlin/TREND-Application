using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using TrendWinForm.Domain.Entities;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using TrendWinForm.Domain.ValueObjects;


namespace TrendWinForm
{
    public class SessionConfig
    {
        //private const string databaseName = "TrendTest";
        //const string connString = "server=JESSE_HARLIN-PC;" + "database=" + databaseName + ";" + "Integrated Security=SSPI;";


        static readonly string _connString = Properties.Settings.Default.TrendConnectionString;

        public static void BeginNhProfiler()
        {
            
            HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
        }

        public static void CreateDatabaseFromMappings()
        {
            Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(_connString))

                //Add All Mappings
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Case>())

                //CreateSchema
                .ExposeConfiguration(CreateSchema)
                .BuildConfiguration();
        }

        private static void CreateSchema(Configuration cfg)
        {
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Drop(false, true);
            schemaExport.Create(false, true);

           
        }


        private static ISessionFactory CreateSessionFactory()
        {



            return Fluently.Configure()
              .Database(MsSqlConfiguration.MsSql2008.ConnectionString(_connString))
              .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Case>())
              
              .BuildSessionFactory();

        }

        private static  ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory { 
            
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = CreateSessionFactory();
                }
                return _sessionFactory;

            }

        }



    }





}
