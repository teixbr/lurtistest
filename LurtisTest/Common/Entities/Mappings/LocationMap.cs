using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            Table("Location");
        }
    }
}