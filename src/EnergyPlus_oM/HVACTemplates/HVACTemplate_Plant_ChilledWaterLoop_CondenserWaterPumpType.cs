using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerTower")]
        PumpPerTower = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
}