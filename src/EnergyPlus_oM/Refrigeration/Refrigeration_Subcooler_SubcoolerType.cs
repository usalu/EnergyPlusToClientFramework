using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Subcooler_SubcoolerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LiquidSuction")]
        LiquidSuction = 1,
        
        [JsonProperty("Mechanical")]
        Mechanical = 2,
    }
}