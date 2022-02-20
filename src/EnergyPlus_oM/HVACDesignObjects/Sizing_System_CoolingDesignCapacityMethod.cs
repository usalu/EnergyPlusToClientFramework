using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_CoolingDesignCapacityMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [JsonProperty("CoolingDesignCapacity")]
        CoolingDesignCapacity = 2,
        
        [JsonProperty("FractionOfAutosizedCoolingCapacity")]
        FractionOfAutosizedCoolingCapacity = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}