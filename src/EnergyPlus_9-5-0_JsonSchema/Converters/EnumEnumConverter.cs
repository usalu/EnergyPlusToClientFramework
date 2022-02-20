using System;
using EnergyPlus_9_5_0_JsonSchema.Fields;
using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Converters
{
    internal class EnumEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPSmartValue) || t == typeof(EPSmartValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return EPSmartValue.OptionalField;
                case "Autocalculate":
                    return EPSmartValue.Autocalculate;
                case "Autosize":
                    return EPSmartValue.Autosize;
            }
            throw new Exception("Cannot unmarshal type EPSmartValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPSmartValue)untypedValue;
            switch (value)
            {
                case EPSmartValue.OptionalField:
                    serializer.Serialize(writer, "");
                    return;
                case EPSmartValue.Autocalculate:
                    serializer.Serialize(writer, "Autocalculate");
                    return;
                case EPSmartValue.Autosize:
                    serializer.Serialize(writer, "Autosize");
                    return;
            }
            throw new Exception("Cannot marshal type EPSmartValue");
        }

        public static readonly EnumEnumConverter Singleton = new EnumEnumConverter();
    }
}