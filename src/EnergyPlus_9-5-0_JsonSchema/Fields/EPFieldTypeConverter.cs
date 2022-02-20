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
                    return EPFieldType.Array;
                case "number":
                    return EPFieldType.Number;
                case "string":
                    return EPFieldType.String;
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
                case EPFieldType.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case EPFieldType.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case EPFieldType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type EPFieldType");
        }

        public static readonly EPFieldTypeConverter Singleton = new EPFieldTypeConverter();
    }
}