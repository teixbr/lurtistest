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
    public class DaoField : Dao, IDaoField
    {
        public DaoField(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoField));
        }

        public Field Find(Field entity)
        {
            _logger.Debug("IN - Find()");

            Field answer = null;

            try
            {
                answer = _session.CreateCriteria<Field>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Field>().FirstOrDefault();

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

        public List<Field> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Field> answer = null;

            try
            {
                answer = _session.Query<Field>()
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
