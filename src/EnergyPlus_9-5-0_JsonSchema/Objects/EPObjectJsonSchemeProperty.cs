using EnergyPlus_9_5_0_JsonSchema.Fields;
using EnergyPlus_9_5_0_JsonSchema.Fields.Legacy;
using Newtonsoft.Json;
using NJsonSchema;

namespace EnergyPlus_9_5_0_JsonSchema.Objects
{
    public class EPObjectJsonSchemeProperty : JsonSchemaProperty
    {
        [JsonProperty("patternProperties")]
        public EPPatternProperties PatternProperties { get; set; }

        [JsonProperty("group")]
        public string EPGroup { get; set; }

        [JsonProperty("legacy_idd")]
        public EPLegacyIdd EPLegacyIdd { get; set; }

        [JsonProperty("type")]
        public EPFieldType Type { get; set; }

        [JsonProperty("maxProperties", NullValueHandling = NullValueHandling.Ignore)]
        public int MaxProperties { get; set; }

        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string EPMemo { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public EPFormat? EPFormat { get; set; }

        [JsonProperty("min_fields", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinFields { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public EPName EPName { get; set; }

        [JsonProperty("minProperties", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinProperties { get; set; }

        [JsonProperty("extensible_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? EPExtensibleSize { get; set; }

        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdditionalProperties { get; set; }
    }
}