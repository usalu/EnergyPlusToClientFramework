using EnergyPlusJsonSchemas.Fields;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas.Objects
{
    public class EPPatternProperties
    {
        [JsonProperty(".*", NullValueHandling = NullValueHandling.Ignore)]
        public OptionalField OptionalField { get; set; }

        [JsonProperty("^.*\\S.*$", NullValueHandling = NullValueHandling.Ignore)]
        public NecessaryField NecessaryField { get; set; }
    }
}