using Newtonsoft.Json;

namespace LurtisTest.Common.Entities
{
    public abstract class BaseEntity
    {
        [JsonProperty(PropertyName = "id")]
        public virtual long Id { get; set; }
    }
}