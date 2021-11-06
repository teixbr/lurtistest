using log4net;
using NHibernate;

namespace LurtisTest.DataAccess.DaoSQLServer
{
    public class Dao
    {
        protected static ILog _logger;
        protected ISession _session;
    }
}
