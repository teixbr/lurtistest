using System.Collections.Generic;

namespace LurtisTest.DataAccess.SQLServerInterfaces
{
    public interface IDao<BaseEntity>
    {
        abstract BaseEntity Find(BaseEntity entity);
        abstract List<BaseEntity> FindAll();
    }
}
