using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_ITE_AirCooled_EnvironmentalClass
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("A1")]
        A1 = 1,
        
        [JsonProperty("A2")]
        A2 = 2,
        
        [JsonProperty("A3")]
        A3 = 3,
        
        [JsonProperty("A4")]
        A4 = 4,
        
        [JsonProperty("B")]
        B = 5,
        
        [JsonProperty("C")]
        C = 6,
        
        [JsonProperty("None")]
        None = 7,
    }
}