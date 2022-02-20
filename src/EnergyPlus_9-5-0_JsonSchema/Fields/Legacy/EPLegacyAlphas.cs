using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Fields.Legacy
{
    public class EPLegacyAlphas
    {
        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Extensions { get; set; }
    }
}