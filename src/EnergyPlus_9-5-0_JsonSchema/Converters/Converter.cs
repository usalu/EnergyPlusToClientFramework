using System.Globalization;
using EnergyPlus_9_5_0_JsonSchema.Fields;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EnergyPlus_9_5_0_JsonSchema.Converters
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                FormatConverter.Singleton,
                FieldTypeConverter.Singleton,
                DataTypeConverter.Singleton,
                ReferenceClassNameConverter.Singleton,
                EPFieldTypeConverter.Singleton,
                EnumUnionConverter.Singleton,
                EnumEnumConverter.Singleton,
                DefaultConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            }
        };
    }
}