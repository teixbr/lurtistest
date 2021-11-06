using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class FieldMap : ClassMap<Field>
    {
        public FieldMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            References(x => x.District).Column("Fk_district");
            HasMany(x => x.DatasetList)
               .Inverse()
               .Cascade.All();
            HasMany(x => x.FacilityList)
               .Inverse()
               .Cascade.All();
            Table("Field");
        }
    }
}