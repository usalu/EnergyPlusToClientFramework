using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_SolarModelIndicator
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAEClearSky")]
        ASHRAEClearSky = 1,
        
        [JsonProperty("ASHRAETau")]
        ASHRAETau = 2,
        
        [JsonProperty("ASHRAETau2017")]
        ASHRAETau2017 = 3,
        
        [JsonProperty("Schedule")]
        Schedule = 4,
        
        [JsonProperty("ZhangHuang")]
        ZhangHuang = 5,
    }
}