using EnergyPlusJsonSchemas.Converters;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas
{
    public static class Serialize
    {
        public static string ToJson(this EPJsonSchema self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}