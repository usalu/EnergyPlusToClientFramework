using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas._9_5_0.Fields.Legacy
{
    public class EPLegacyFieldInfo
    {
        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("field_type")]
        public EPLegacyFieldType EPLegacyFieldType { get; set; }
    }
}