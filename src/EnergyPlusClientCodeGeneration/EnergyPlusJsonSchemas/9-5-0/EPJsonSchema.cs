using System;
using System.Collections.Generic;
using EnergyPlusJsonSchemas._9_5_0.Converters;
using EnergyPlusJsonSchemas._9_5_0.Objects;
using EnergyPlusJsonSchemas.Properties;
using Newtonsoft.Json;
using NJsonSchema;

namespace EnergyPlusJsonSchemas._9_5_0
{

    public class EPJsonSchema : JsonSchema
    {
        public static string GetOfficalEPJsonSchema => Resources.EnergyPlus_V9_5_0_Schema.ToString();

        [JsonProperty("$schema")]
        public Uri Schema { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, EPObjectJsonSchemeProperty> Properties { get; set; }

        [JsonProperty("required")]
        public string[] EPJsonSchemaRequired { get; set; }

        [JsonProperty("epJSON_schema_version")]
        public string EpJsonSchemaVersion { get; set; }

        [JsonProperty("epJSON_schema_build")]
        public string EpJsonSchemaBuild { get; set; }

        public static EPJsonSchema FromJson(string json) => JsonConvert.DeserializeObject<EPJsonSchema>(json, Converter.Settings);
    }
}
