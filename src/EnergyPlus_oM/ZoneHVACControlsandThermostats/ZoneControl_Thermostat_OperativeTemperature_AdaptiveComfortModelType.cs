using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_OperativeTemperature_AdaptiveComfortModelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdaptiveASH5580PercentUpperLine")]
        AdaptiveASH5580PercentUpperLine = 1,
        
        [JsonProperty("AdaptiveASH5590PercentUpperLine")]
        AdaptiveASH5590PercentUpperLine = 2,
        
        [JsonProperty("AdaptiveASH55CentralLine")]
        AdaptiveASH55CentralLine = 3,
        
        [JsonProperty("AdaptiveCEN15251CategoryIIIUpperLine")]
        AdaptiveCEN15251CategoryIIIUpperLine = 4,
        
        [JsonProperty("AdaptiveCEN15251CategoryIIUpperLine")]
        AdaptiveCEN15251CategoryIIUpperLine = 5,
        
        [JsonProperty("AdaptiveCEN15251CategoryIUpperLine")]
        AdaptiveCEN15251CategoryIUpperLine = 6,
        
        [JsonProperty("AdaptiveCEN15251CentralLine")]
        AdaptiveCEN15251CentralLine = 7,
        
        [JsonProperty("None")]
        None = 8,
    }
}