using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_HybridUnitaryHVAC_ObjectiveFunctionToMinimize
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electricity Use")]
        ElectricityUse = 1,
        
        [JsonProperty("Second Fuel Use")]
        SecondFuelUse = 2,
        
        [JsonProperty("Third Fuel Use")]
        ThirdFuelUse = 3,
        
        [JsonProperty("Water Use")]
        WaterUse = 4,
    }
}