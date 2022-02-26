using EnergyPlus_9_5_0_JsonSchema.Fields;
using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Objects
{
    public class EPPatternProperties
    {
        [JsonProperty(".*", NullValueHandling = NullValueHandling.Ignore)]
        public EPField OptionalField { get; set; }

        [JsonProperty("^.*\\S.*$", NullValueHandling = NullValueHandling.Ignore)]
        public EPField NecessaryField { get; set; }
    }
}