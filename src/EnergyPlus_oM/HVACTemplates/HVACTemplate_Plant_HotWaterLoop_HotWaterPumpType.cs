using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerBoiler")]
        PumpPerBoiler = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
}