using EnergyPlusJsonSchemas._9_5_0.Converters;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas._9_5_0
{
    public static class Serialize
    {
        public static string ToJson(this EPJsonSchema self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}