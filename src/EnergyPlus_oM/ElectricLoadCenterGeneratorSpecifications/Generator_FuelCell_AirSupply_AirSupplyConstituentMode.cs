using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AirSupply_AirSupplyConstituentMode
    {
        
        [JsonProperty("AmbientAir")]
        AmbientAir = 0,
        
        [JsonProperty("UserDefinedConstituents")]
        UserDefinedConstituents = 1,
    }
}