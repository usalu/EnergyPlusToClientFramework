using EnergyPlusJsonSchemas._9_5_0.Fields;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas._9_5_0.Objects
{
    public class EPPatternProperties
    {
        [JsonProperty(".*", NullValueHandling = NullValueHandling.Ignore)]
        public OptionalField OptionalField { get; set; }

        [JsonProperty("^.*\\S.*$", NullValueHandling = NullValueHandling.Ignore)]
        public NecessaryField NecessaryField { get; set; }
    }
}