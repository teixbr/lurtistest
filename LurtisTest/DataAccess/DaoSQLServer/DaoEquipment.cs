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
    public class DaoEquipment : Dao, IDaoEquipment
    {
        public DaoEquipment(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoEquipment));
        }

        public Equipment Find(Equipment entity)
        {
            _logger.Debug("IN - Find()");

            Equipment answer = null;

            try
            {
                answer = _session.CreateCriteria<Equipment>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Equipment>().FirstOrDefault();

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

        public List<Equipment> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Equipment> answer = null;

            try
            {
                answer = _session.Query<Equipment>()
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
