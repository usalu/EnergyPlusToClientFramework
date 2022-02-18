using System;
using EnergyPlusJsonSchemas._9_5_0.Fields;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas._9_5_0.Converters
{
    internal class DataTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPList) || t == typeof(EPList?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "external_list":
                    return EPList.ExternalList;
                case "object_list":
                    return EPList.ObjectList;
            }
            throw new Exception("Cannot unmarshal type EPList");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPList)untypedValue;
            switch (value)
            {
                case EPList.ExternalList:
                    serializer.Serialize(writer, "external_list");
                    return;
                case EPList.ObjectList:
                    serializer.Serialize(writer, "object_list");
                    return;
            }
            throw new Exception("Cannot marshal type EPList");
        }

        public static readonly DataTypeConverter Singleton = new DataTypeConverter();
    }
}