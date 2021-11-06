using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class MaterialMap : ClassMap<Material>
    {
        public MaterialMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            Table("Material");
        }
    }
}