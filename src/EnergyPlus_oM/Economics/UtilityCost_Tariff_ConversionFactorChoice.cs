using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Tariff_ConversionFactorChoice
    {
        
        [JsonProperty("CCF")]
        CCF = 0,
        
        [JsonProperty("MCF")]
        MCF = 1,
        
        [JsonProperty("MJ")]
        MJ = 2,
        
        [JsonProperty("MMBtu")]
        MMBtu = 3,
        
        [JsonProperty("Therm")]
        Therm = 4,
        
        [JsonProperty("UserDefined")]
        UserDefined = 5,
        
        [JsonProperty("gal")]
        Gal = 6,
        
        [JsonProperty("kBtu")]
        KBtu = 7,
        
        [JsonProperty("kWh")]
        KWh = 8,
        
        [JsonProperty("kgal")]
        Kgal = 9,
        
        [JsonProperty("m3")]
        M3 = 10,
    }
}