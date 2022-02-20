using EnergyPlus_9_5_0_JsonSchema.Converters;
using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema
{
    public static class Serialize
    {
        public static string ToJson(this EPJsonSchema self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}