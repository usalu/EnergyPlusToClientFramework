using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_MixedWaterLoop_WaterPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerTowerOrBoiler")]
        PumpPerTowerOrBoiler = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
}