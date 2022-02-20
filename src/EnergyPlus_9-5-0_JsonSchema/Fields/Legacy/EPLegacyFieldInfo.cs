using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Fields.Legacy
{
    public class EPLegacyFieldInfo
    {
        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("field_type")]
        public EPLegacyFieldType EPLegacyFieldType { get; set; }
    }
}