using System.Collections.Generic;
using Newtonsoft.Json;
using NJsonSchema;

namespace EnergyPlus_9_5_0_JsonSchema.Fields
{
    public class OptionalField : JsonSchema
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, EPFieldProperty> Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Required { get; set; }
    }
}