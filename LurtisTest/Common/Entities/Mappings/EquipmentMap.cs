using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class EquipmentMap : ClassMap<Equipment>
    {
        public EquipmentMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            Table("Equipment");
        }
    }
}