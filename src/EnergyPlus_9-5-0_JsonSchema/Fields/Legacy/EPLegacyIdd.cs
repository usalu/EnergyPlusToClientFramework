using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Fields.Legacy
{
    public class EPLegacyIdd
    {
        [JsonProperty("field_info")]
        public Dictionary<string, EPLegacyFieldInfo> EPLegacyFieldInfo { get; set; }

        [JsonProperty("fields")]
        public string[] EPLegacyFields { get; set; }

        [JsonProperty("alphas")]
        public EPLegacyAlphas EPLegacyAlphas { get; set; }

        [JsonProperty("numerics")]
        public EPLegacyAlphas EPLegacyNumerics { get; set; }

        [JsonProperty("extensibles", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EPLegacyExtensibles { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public string EPLegacyExtension { get; set; }
    }
}