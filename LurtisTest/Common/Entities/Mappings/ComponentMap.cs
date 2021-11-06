using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class ComponentMap : ClassMap<Component>
    {
        public ComponentMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            Table("Component");
        }
    }
}