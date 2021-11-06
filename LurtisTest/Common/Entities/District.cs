using System.Collections.Generic;
using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public class District : BaseEntity
    {
        [JsonProperty(PropertyName = "name")]
        public virtual string Name { get; set; }

        [JsonProperty(PropertyName = "datasetList")]
        public virtual IList<Dataset> DatasetList { get; set; }

        [JsonProperty(PropertyName = "fieldList")]
        public virtual IList<Field> FieldList { get; set; }

        public District()
        {
            DatasetList = new List<Dataset>();
            FieldList = new List<Field>();
        }
    }
}
