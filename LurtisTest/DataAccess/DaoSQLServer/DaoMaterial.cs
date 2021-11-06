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
    public class DaoMaterial : Dao, IDaoMaterial
    {
        public DaoMaterial(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoMaterial));
        }

        public Material Find(Material entity)
        {
            _logger.Debug("IN - Find()");

            Material answer = null;

            try
            {
                answer = _session.CreateCriteria<Material>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Material>().FirstOrDefault();

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

        public List<Material> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Material> answer = null;

            try
            {
                answer = _session.Query<Material>()
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
