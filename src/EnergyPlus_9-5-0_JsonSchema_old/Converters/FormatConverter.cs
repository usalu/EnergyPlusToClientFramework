using System;
using EnergyPlusJsonSchemas.Objects;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas.Converters
{
    internal class FormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPFormat) || t == typeof(EPFormat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FluidProperty":
                    return EPFormat.FluidProperty;
                case "Spectral":
                    return EPFormat.Spectral;
                case "ViewFactor":
                    return EPFormat.ViewFactor;
                case "compactSchedule":
                    return EPFormat.CompactSchedule;
                case "singleLine":
                    return EPFormat.SingleLine;
                case "vertices":
                    return EPFormat.Vertices;
            }
            throw new Exception("Cannot unmarshal type EPFormat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPFormat)untypedValue;
            switch (value)
            {
                case EPFormat.FluidProperty:
                    serializer.Serialize(writer, "FluidProperty");
                    return;
                case EPFormat.Spectral:
                    serializer.Serialize(writer, "Spectral");
                    return;
                case EPFormat.ViewFactor:
                    serializer.Serialize(writer, "ViewFactor");
                    return;
                case EPFormat.CompactSchedule:
                    serializer.Serialize(writer, "compactSchedule");
                    return;
                case EPFormat.SingleLine:
                    serializer.Serialize(writer, "singleLine");
                    return;
                case EPFormat.Vertices:
                    serializer.Serialize(writer, "vertices");
                    return;
            }
            throw new Exception("Cannot marshal type EPFormat");
        }

        public static readonly FormatConverter Singleton = new FormatConverter();
    }
}