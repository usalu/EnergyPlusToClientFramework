using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelSupply_Constituent7Name
    {
        
        [JsonProperty("Butane")]
        Butane = 0,
        
        [JsonProperty("Ethane")]
        Ethane = 1,
        
        [JsonProperty("Ethanol")]
        Ethanol = 2,
        
        [JsonProperty("Hexane")]
        Hexane = 3,
        
        [JsonProperty("Hydrogen")]
        Hydrogen = 4,
        
        [JsonProperty("Methane")]
        Methane = 5,
        
        [JsonProperty("Methanol")]
        Methanol = 6,
        
        [JsonProperty("Pentane")]
        Pentane = 7,
        
        [JsonProperty("Propane")]
        Propane = 8,
    }
}