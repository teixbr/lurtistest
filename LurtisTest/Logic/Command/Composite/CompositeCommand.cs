using NHibernate;
using LurtisTest.DataAccess.DaoSQLServer;

namespace LurtisTest.Logic.Command.Composite
{
    public abstract class CompositeCommand<T> : Command<T>
    {
        protected ITransaction _transaction { get; set; }

        public void CreateSession(bool read)
        {
            if (_daoHandler == null)
            {
                _daoHandler = DaoFactory.InstanceDaoHadler().GetSession();
            }

            if (read)
            {
                _daoHandler.DefaultReadOnly = true;
            }
        }
    }
}