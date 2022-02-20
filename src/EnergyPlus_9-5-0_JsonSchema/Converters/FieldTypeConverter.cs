using System;
using EnergyPlus_9_5_0_JsonSchema.Fields.Legacy;
using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Converters
{
    internal class FieldTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPLegacyFieldType) || t == typeof(EPLegacyFieldType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "a":
                    return EPLegacyFieldType.A;
                case "n":
                    return EPLegacyFieldType.N;
            }
            throw new Exception("Cannot unmarshal type EPLegacyFieldType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPLegacyFieldType)untypedValue;
            switch (value)
            {
                case EPLegacyFieldType.A:
                    serializer.Serialize(writer, "a");
                    return;
                case EPLegacyFieldType.N:
                    serializer.Serialize(writer, "n");
                    return;
            }
            throw new Exception("Cannot marshal type EPLegacyFieldType");
        }

        public static readonly FieldTypeConverter Singleton = new FieldTypeConverter();
    }
}