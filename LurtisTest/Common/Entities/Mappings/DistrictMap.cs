using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class DistrictMap : ClassMap<District>
    {
        public DistrictMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            Table("District");
        }
    }
}