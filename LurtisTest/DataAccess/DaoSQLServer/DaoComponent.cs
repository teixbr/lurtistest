using log4net;
using NHibernate;
using NHibernate.Criterion;
using LurtisTest.Common.Entities;
using LurtisTest.Common.Exceptions;
using LurtisTest.DataAccess.SQLServerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LurtisTest.DataAccess.DaoSQLServer
{
    public class DaoComponent : Dao, IDaoComponent
    {
        public DaoComponent(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoComponent));
        }

        public Component Find(Component entity)
        {
            _logger.Debug("IN - Find()");

            Component answer = null;

            try
            {
                answer = _session.CreateCriteria<Component>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Component>().FirstOrDefault();

                if (answer.Id == 0)
                {
                    throw new LTFindException();
                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw new LTFindException(e);
            }

            _logger.Debug("OUT - Find()");

            return answer;
        }

        public List<Component> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Component> answer = null;

            try
            {
                answer = _session.Query<Component>()
                    .ToList();
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw new LTFindException(e);
            }

            _logger.Debug("OUT - FindAll()");

            return answer;
        }
    }
}
