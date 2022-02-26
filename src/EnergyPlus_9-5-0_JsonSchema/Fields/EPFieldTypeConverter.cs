using System;
using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Fields
{
    internal class EPFieldTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPFieldType) || t == typeof(EPFieldType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return EPFieldType.array;
                case "number":
                    return EPFieldType.number;
                case "string":
                    return EPFieldType.@string;
                case "object":
                    return EPFieldType.@object;
            }
            throw new Exception("Cannot unmarshal type EPFieldType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPFieldType)untypedValue;
            switch (value)
            {
                case EPFieldType.array:
                    serializer.Serialize(writer, "array");
                    return;
                case EPFieldType.number:
                    serializer.Serialize(writer, "number");
                    return;
                case EPFieldType.@string:
                    serializer.Serialize(writer, "string");
                    return;
                case EPFieldType.@object:
                    serializer.Serialize(writer, "object");
                    return;
            }
            throw new Exception("Cannot marshal type EPFieldType");
        }

        public static readonly EPFieldTypeConverter Singleton = new EPFieldTypeConverter();
    }
}