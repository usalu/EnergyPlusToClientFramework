using System.Globalization;
using EnergyPlusJsonSchemas._9_5_0.Fields;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EnergyPlusJsonSchemas._9_5_0.Converters
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