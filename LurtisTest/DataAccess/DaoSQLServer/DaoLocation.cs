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
    public class DaoLocation : Dao, IDaoLocation
    {
        public DaoLocation(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoLocation));
        }

        public Location Find(Location entity)
        {
            _logger.Debug("IN - Find()");

            Location answer = null;

            try
            {
                answer = _session.CreateCriteria<Location>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Location>().FirstOrDefault();

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

        public List<Location> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Location> answer = null;

            try
            {
                answer = _session.Query<Location>()
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
