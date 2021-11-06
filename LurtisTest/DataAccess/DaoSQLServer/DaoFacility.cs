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
    public class DaoFacility : Dao, IDaoFacility
    {
        public DaoFacility(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoFacility));
        }

        public Facility Find(Facility entity)
        {
            _logger.Debug("IN - Find()");

            Facility answer = null;

            try
            {
                answer = _session.CreateCriteria<Facility>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Facility>().FirstOrDefault();

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

        public List<Facility> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Facility> answer = null;

            try
            {
                answer = _session.Query<Facility>()
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
