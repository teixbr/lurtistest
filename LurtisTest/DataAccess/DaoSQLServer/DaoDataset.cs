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
    public class DaoDataset : Dao, IDaoDataset
    {
        public DaoDataset(ISession session)
        {
            _session = session;

            _logger = LogManager.GetLogger(typeof(DaoDataset));
        }

        public Dataset Find(Dataset entity)
        {
            _logger.Debug("IN - Find()");

            Dataset answer = null;

            try
            {
                answer = _session.CreateCriteria<Dataset>()
                                .Add(Restrictions.IdEq(entity.Id))
                                .List<Dataset>().FirstOrDefault();

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

        public List<Dataset> FindAll()
        {
            _logger.Debug("IN - FindAll()");

            List<Dataset> answer = null;

            try
            {
                answer = _session.Query<Dataset>()
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
