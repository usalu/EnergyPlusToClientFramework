using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_CentralCoolingCapacityControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Bypass")]
        Bypass = 1,
        
        [JsonProperty("OnOff")]
        OnOff = 2,
        
        [JsonProperty("VAV")]
        VAV = 3,
        
        [JsonProperty("VT")]
        VT = 4,
    }
}