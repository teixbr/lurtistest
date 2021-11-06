using System.Collections.Generic;
using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public class Facility : BaseEntity
    {
        [JsonProperty(PropertyName = "name")]
        public virtual string Name { get; set; }

        [JsonProperty(PropertyName = "field")]
        public virtual Field Field { get; set; }

        [JsonProperty(PropertyName = "datasetList")]
        public virtual IList<Dataset> DatasetList { get; set; }

        [JsonProperty(PropertyName = "unitList")]
        public virtual IList<Unit> UnitList { get; set; }

        public Facility()
        {
            DatasetList = new List<Dataset>();
            UnitList = new List<Unit>();
        }
    }
}