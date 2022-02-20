using System.Collections.Generic;
using Newtonsoft.Json;
using NJsonSchema;

namespace EnergyPlusJsonSchemas.Fields
{
    public class NecessaryField : JsonSchema
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, EPFieldProperty> Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Required { get; set; }
    }
}