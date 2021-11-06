using FluentNHibernate.Mapping;

namespace LurtisTest.Common.Entities.Mappings
{
    public class DatasetMap : ClassMap<Dataset>
    {
        public DatasetMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Date);
            Map(x => x.RetirementDate);
            Map(x => x.NextSurveyDate);
            Map(x => x.CorrotionRate);
            Map(x => x.Thickness);
            Map(x => x.Date);
            Map(x => x.NominalThickness);
            Map(x => x.DangerThickness);
            Map(x => x.RemainingLife);
            Map(x => x.Temperature);
            References(x => x.Equipment).Column("Fk_equipment");
            References(x => x.Component).Column("Fk_component");
            References(x => x.Location).Column("Fk_location");
            References(x => x.Material).Column("Fk_material");
            References(x => x.District).Column("Fk_district");
            References(x => x.Field).Column("Fk_field");
            References(x => x.Facility).Column("Fk_facility");
            References(x => x.Unit).Column("Fk_unit");
            Table("Dataset");
        }
    }
}