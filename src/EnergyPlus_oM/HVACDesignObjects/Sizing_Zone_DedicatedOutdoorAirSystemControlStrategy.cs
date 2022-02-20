using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ColdSupplyAir")]
        ColdSupplyAir = 1,
        
        [JsonProperty("NeutralDehumidifiedSupplyAir")]
        NeutralDehumidifiedSupplyAir = 2,
        
        [JsonProperty("NeutralSupplyAir")]
        NeutralSupplyAir = 3,
    }
}