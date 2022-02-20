using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum GroundHeatExchanger_Slinky_HeatExchangerConfiguration
    {
        
        [JsonProperty("Horizontal")]
        Horizontal = 0,
        
        [JsonProperty("Vertical")]
        Vertical = 1,
    }
}