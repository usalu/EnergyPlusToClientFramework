using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelSupply_FuelType
    {
        
        [JsonProperty("GaseousConstituents")]
        GaseousConstituents = 0,
        
        [JsonProperty("LiquidGeneric")]
        LiquidGeneric = 1,
    }
}