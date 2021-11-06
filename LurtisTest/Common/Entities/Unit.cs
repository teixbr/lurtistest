using System.Collections.Generic;
using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public class Unit : BaseEntity
    {
        [JsonProperty(PropertyName = "name")]
        public virtual string Name { get; set; }

        [JsonProperty(PropertyName = "facility")]
        public virtual Facility Facility { get; set; }

        [JsonProperty(PropertyName = "datasetList")]
        public virtual IList<Dataset> DatasetList { get; set; }

        public Unit()
        {
            DatasetList = new List<Dataset>();
        }
    }
}