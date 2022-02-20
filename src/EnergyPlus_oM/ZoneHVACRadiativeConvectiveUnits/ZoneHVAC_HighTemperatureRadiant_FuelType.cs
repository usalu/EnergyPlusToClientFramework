using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_HighTemperatureRadiant_FuelType
    {
        
        [JsonProperty("Electricity")]
        Electricity = 0,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 1,
    }
}