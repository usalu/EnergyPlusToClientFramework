using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelSupply_Constituent4Name
    {
        
        [JsonProperty("Argon")]
        Argon = 0,
        
        [JsonProperty("Butane")]
        Butane = 1,
        
        [JsonProperty("CarbonDioxide")]
        CarbonDioxide = 2,
        
        [JsonProperty("Ethane")]
        Ethane = 3,
        
        [JsonProperty("Ethanol")]
        Ethanol = 4,
        
        [JsonProperty("Hexane")]
        Hexane = 5,
        
        [JsonProperty("Hydrogen")]
        Hydrogen = 6,
        
        [JsonProperty("Methane")]
        Methane = 7,
        
        [JsonProperty("Methanol")]
        Methanol = 8,
        
        [JsonProperty("Nitrogen")]
        Nitrogen = 9,
        
        [JsonProperty("Oxygen")]
        Oxygen = 10,
        
        [JsonProperty("Pentane")]
        Pentane = 11,
        
        [JsonProperty("Propane")]
        Propane = 12,
        
        [JsonProperty("Water")]
        Water = 13,
    }
}