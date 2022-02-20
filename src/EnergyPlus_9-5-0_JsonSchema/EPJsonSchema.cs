using System;
using System.Collections.Generic;
using EnergyPlus_9_5_0_JsonSchema.Converters;
using EnergyPlus_9_5_0_JsonSchema.Objects;
using EnergyPlus_9_5_0_JsonSchema.Properties;
using Newtonsoft.Json;
using NJsonSchema;

namespace EnergyPlus_9_5_0_JsonSchema
{

    public class EPJsonSchema : JsonSchema
    {
        public static EPJsonSchema GetOfficalEPJsonSchema => FromJson(Resources.EnergyPlus_9_5_0_Schema);
        public static string GetOfficalEPJsonSchemaString => Resources.EnergyPlus_9_5_0_Schema;

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
