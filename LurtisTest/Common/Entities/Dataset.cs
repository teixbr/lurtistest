using System;
using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public class Dataset: BaseEntity
    {
        [JsonProperty(PropertyName = "date")]
        public virtual DateTime Date { get; set; }

        [JsonProperty(PropertyName = "retirementDate")]
        public virtual DateTime RetirementDate { get; set; }

        [JsonProperty(PropertyName = "nextSurveydate")]
        public virtual DateTime NextSurveyDate { get; set; }

        [JsonProperty(PropertyName = "thickness")]
        public virtual double Thickness { get; set; }

        [JsonProperty(PropertyName = "corrotionRate")]
        public virtual double CorrotionRate { get; set; }

        [JsonProperty(PropertyName = "nominalThickness")]
        public virtual double NominalThickness { get; set; }

        [JsonProperty(PropertyName = "dangerThickness")]
        public virtual double DangerThickness { get; set; }

        [JsonProperty(PropertyName = "remainingLife")]
        public virtual double RemainingLife { get; set; }

        [JsonProperty(PropertyName = "temperature")]
        public virtual double Temperature { get; set; }

        [JsonProperty(PropertyName = "equipment")]
        public virtual Equipment Equipment { get; set; }

        [JsonProperty(PropertyName = "component")]
        public virtual Component Component { get; set; }

        [JsonProperty(PropertyName = "location")]
        public virtual Location Location { get; set; }

        [JsonProperty(PropertyName = "material")]
        public virtual Material Material { get; set; }

        [JsonProperty(PropertyName = "district")]
        public virtual District District { get; set; }

        [JsonProperty(PropertyName = "field")]
        public virtual Field Field { get; set; }

        [JsonProperty(PropertyName = "facility")]
        public virtual Facility Facility { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public virtual Unit Unit { get; set; }

        public Dataset()
        {
        }
    }
}
