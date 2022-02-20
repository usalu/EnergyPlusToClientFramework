using System;
using EnergyPlusJsonSchemas.Fields;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas.Converters
{
    internal class DefaultConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPDefaultValue) || t == typeof(EPDefaultValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new EPDefaultValue { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new EPDefaultValue { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type EPDefaultValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EPDefaultValue)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type EPDefaultValue");
        }

        public static readonly DefaultConverter Singleton = new DefaultConverter();
    }
}