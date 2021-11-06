using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class UnitMap : ClassMap<Unit>
    {
        public UnitMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            References(x => x.Facility).Column("Fk_facility");
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            Table("Unit");
        }
    }
}