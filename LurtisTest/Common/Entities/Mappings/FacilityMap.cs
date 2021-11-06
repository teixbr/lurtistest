using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class FacilityMap : ClassMap<Facility>
    {
        public FacilityMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            References(x => x.Field).Column("Fk_field");
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            HasMany(x => x.UnitList)
               .Inverse()
               .Cascade.All();
            Table("Facility");
        }
    }
}