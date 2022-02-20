using System;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas.Converters
{
    internal class ReferenceClassNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPReferenceClassName) || t == typeof(EPReferenceClassName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "validBranchEquipmentTypes":
                    return EPReferenceClassName.ValidBranchEquipmentTypes;
                case "validCondenserEquipmentTypes":
                    return EPReferenceClassName.ValidCondenserEquipmentTypes;
                case "validOASysEquipmentTypes":
                    return EPReferenceClassName.ValidOaSysEquipmentTypes;
                case "validPlantEquipmentTypes":
                    return EPReferenceClassName.ValidPlantEquipmentTypes;
            }
            throw new Exception("Cannot unmarshal type EPReferenceClassName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPReferenceClassName)untypedValue;
            switch (value)
            {
                case EPReferenceClassName.ValidBranchEquipmentTypes:
                    serializer.Serialize(writer, "validBranchEquipmentTypes");
                    return;
                case EPReferenceClassName.ValidCondenserEquipmentTypes:
                    serializer.Serialize(writer, "validCondenserEquipmentTypes");
                    return;
                case EPReferenceClassName.ValidOaSysEquipmentTypes:
                    serializer.Serialize(writer, "validOASysEquipmentTypes");
                    return;
                case EPReferenceClassName.ValidPlantEquipmentTypes:
                    serializer.Serialize(writer, "validPlantEquipmentTypes");
                    return;
            }
            throw new Exception("Cannot marshal type EPReferenceClassName");
        }

        public static readonly ReferenceClassNameConverter Singleton = new ReferenceClassNameConverter();
    }
}