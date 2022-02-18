using System;
using EnergyPlusJsonSchemas._9_5_0.Fields;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas._9_5_0.Converters
{
    internal class EnumUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPNumberOrSmartValue) || t == typeof(EPNumberOrSmartValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new EPNumberOrSmartValue { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "":
                            return new EPNumberOrSmartValue { Enum = EPSmartValue.OptionalField };
                        case "Autocalculate":
                            return new EPNumberOrSmartValue { Enum = EPSmartValue.Autocalculate };
                        case "Autosize":
                            return new EPNumberOrSmartValue { Enum = EPSmartValue.Autosize };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type EPNumberOrSmartValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EPNumberOrSmartValue)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
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
            }
            throw new Exception("Cannot marshal type EPNumberOrSmartValue");
        }

        public static readonly EnumUnionConverter Singleton = new EnumUnionConverter();
    }
}