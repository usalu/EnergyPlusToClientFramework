using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum ChillerHeater_Absorption_DirectFired_TemperatureCurveInputVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EnteringCondenser")]
        EnteringCondenser = 1,
        
        [JsonProperty("LeavingCondenser")]
        LeavingCondenser = 2,
    }
}