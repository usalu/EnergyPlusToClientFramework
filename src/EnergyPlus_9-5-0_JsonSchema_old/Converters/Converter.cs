using System.Globalization;
using EnergyPlusJsonSchemas.Fields;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EnergyPlusJsonSchemas.Converters
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