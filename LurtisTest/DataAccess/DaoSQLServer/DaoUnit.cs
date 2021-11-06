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
    public class DaoUnit : Dao, IDaoUnit
    {
        public DaoUnit(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoUnit));
        }

        public Unit Find(Unit entity)
        {
            _logger.Debug("IN - Find()");

            Unit answer = null;

            try
            {
                answer = _session.CreateCriteria<Unit>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Unit>().FirstOrDefault();

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

        public List<Unit> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Unit> answer = null;

            try
            {
                answer = _session.Query<Unit>()
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
