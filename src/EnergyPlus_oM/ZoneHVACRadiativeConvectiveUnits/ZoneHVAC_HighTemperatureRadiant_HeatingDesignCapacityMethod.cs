using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [JsonProperty("FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [JsonProperty("HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
}