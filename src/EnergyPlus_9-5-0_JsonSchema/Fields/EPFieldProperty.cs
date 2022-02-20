using Newtonsoft.Json;
using NJsonSchema;

namespace EnergyPlus_9_5_0_JsonSchema.Fields
{
    public class EPFieldProperty : JsonSchemaProperty
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldType? EPType { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public EPDefaultValue? Default { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string EPNote { get; set; }

        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EPEnum { get; set; }

        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minimum { get; set; }

        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
        public double? Maximum { get; set; }

        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public string Units { get; set; }

        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExclusiveMinimum { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public JsonSchema Items { get; set; }

        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPList? EPList { get; set; }

        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ObjectList { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Reference { get; set; }

        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retaincase { get; set; }

        [JsonProperty("anyOf", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty[] AnyOf { get; set; }

        [JsonProperty("exclusiveMaximum", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExclusiveMaximum { get; set; }

        [JsonProperty("ip-units", NullValueHandling = NullValueHandling.Ignore)]
        public string IpUnits { get; set; }

        [JsonProperty("external_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ExternalList { get; set; }

        [JsonProperty("unitsBasedOnField", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitsBasedOnField { get; set; }
    }
}