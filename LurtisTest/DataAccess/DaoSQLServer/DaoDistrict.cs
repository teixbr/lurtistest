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
    public class DaoDistrict : Dao, IDaoDistrict
    {
        public DaoDistrict(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoDistrict));
        }

        public District Find(District entity)
        {
            _logger.Debug("IN - Find()");

            District answer = null;

            try
            {
                answer = _session.CreateCriteria<District>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<District>().FirstOrDefault();

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

        public List<District> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<District> answer = null;

            try
            {
                answer = _session.Query<District>()
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
