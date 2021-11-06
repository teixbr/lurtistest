using NHibernate;
using LurtisTest.DataAccess.SQLServerInterfaces;

namespace LurtisTest.DataAccess.DaoSQLServer
{
    public class DaoFactory
    {
        public static DaoHandler InstanceDaoHadler()
        {
            return new DaoHandler();
        }

        public static IDaoComponent InstanceDaoComponent(ISession daoHandler)
        {
            return new DaoComponent(daoHandler);
        }

        public static IDaoDataset InstanceDaoDataset(ISession daoHandler)
        {
            return new DaoDataset(daoHandler);
        }

        public static IDaoDistrict InstanceDaoDistrict(ISession daoHandler)
        {
            return new DaoDistrict(daoHandler);
        }

        public static IDaoEquipment InstanceDaoEquipment(ISession daoHandler)
        {
            return new DaoEquipment(daoHandler);
        }

        public static IDaoFacility InstanceDaoFacility(ISession daoHandler)
        {
            return new DaoFacility(daoHandler);
        }

        public static IDaoField InstanceDaoField(ISession daoHandler)
        {
            return new DaoField(daoHandler);
        }

        public static IDaoLocation InstanceDaoLocation(ISession daoHandler)
        {
            return new DaoLocation(daoHandler);
        }

        public static IDaoMaterial InstanceDaoMaterial(ISession daoHandler)
        {
            return new DaoMaterial(daoHandler);
        }

        public static IDaoUnit InstanceDaoUnit(ISession daoHandler)
        {
            return new DaoUnit(daoHandler);
        }
    }
}
