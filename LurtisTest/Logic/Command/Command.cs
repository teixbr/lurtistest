using log4net;
using NHibernate;

namespace LurtisTest.Logic.Command
{
    public abstract class Command<T>
    {
        protected static ILog _logger;
        protected ISession _daoHandler { get; set; }

        public abstract void Execute();

        public abstract T GetReturnParam();
    }
}
