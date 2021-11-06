using System.Collections.Generic;
using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public class Field : BaseEntity
    {
        [JsonProperty(PropertyName = "name")]
        public virtual string Name { get; set; }

        [JsonProperty(PropertyName = "district")]
        public virtual District District { get; set; }

        [JsonProperty(PropertyName = "datasetList")]
        public virtual IList<Dataset> DatasetList { get; set; }

        [JsonProperty(PropertyName = "facilityList")]
        public virtual IList<Facility> FacilityList { get; set; }

        public Field()
        {
            DatasetList = new List<Dataset>();
            FacilityList = new List<Facility>();
        }
    }
}
