using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using TrendWinForm.Domain.Entities;
using Settings = TrendWinForm.Properties.Settings;

namespace TrendWinForm
{
    public class SessionConfig
    {
        //private const string databaseName = "TrendTest";
        //const string connString = "server=JESSE_HARLIN-PC;" + "database=" + databaseName + ";" + "Integrated Security=SSPI;";
        private static readonly string _connString = Settings.Default.TrendConnectionString;
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = CreateSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static void BeginNhProfiler()
        {
            NHibernateProfiler.Initialize();
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


        public static void UpdateDatabaseFromMapping()
        {
            Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(_connString))

                //Add All Mappings
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Case>())

                //CreateSchema
                .ExposeConfiguration(UpdateSchema)
                .BuildConfiguration();
        }

        private static void CreateSchema(Configuration cfg)
        {
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Drop(false, true);
            schemaExport.Create(false, true);
        }

        private static void UpdateSchema(Configuration cfg)
        {
            var schemaUpdate = new SchemaUpdate(cfg);

            schemaUpdate.Execute(false, true);

        }


        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(_connString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Case>())
                .BuildSessionFactory();
        }
    }
}