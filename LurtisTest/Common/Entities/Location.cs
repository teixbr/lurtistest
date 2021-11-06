using System.Collections.Generic;
using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public class Location : BaseEntity
    {
        [JsonProperty(PropertyName = "name")]
        public virtual string Name { get; set; }

        [JsonProperty(PropertyName = "datasetList")]
        public virtual IList<Dataset> DatasetList { get; set; }

        public Location()
        {
            DatasetList = new List<Dataset>();
        }
    }
}
