using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using log4net;
using NHibernate;
using LurtisTest.Common.Exceptions;
using System;

namespace LurtisTest.DataAccess.DaoSQLServer
{
    public class DaoHandler
    {
        private static ISession _session;

        private static ILog _logger = LogManager.GetLogger(typeof(DaoHandler));

        public DaoHandler()
        {
            _logger.Debug("IN - DaoHandler()");

            try
            {
                if (_session == null)
                {
                    _session = GetSession();
                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw new LTSQLServerHandlerException();
            }

            _logger.Debug("OUT - DaoHandler()");
        }

        public ISession GetSession()
        {
            _logger.Debug("IN - GetSession()");

            try
            {
                var sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(Common.Utils.ReadProperty.DB_CONNECTION).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .BuildSessionFactory();

                _logger.Debug("OUT - GetSession()");

                return sessionFactory.OpenSession();
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw new LTSQLServerHandlerException();
            }
        }
    }
}
