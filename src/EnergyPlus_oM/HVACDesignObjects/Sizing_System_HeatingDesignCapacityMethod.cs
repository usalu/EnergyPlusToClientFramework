using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_HeatingDesignCapacityMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [JsonProperty("FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [JsonProperty("HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}