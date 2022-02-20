using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum ChillerHeaterPerformance_Electric_EIR_CoolingModeTemperatureCurveCondenserWaterIndependentVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EnteringCondenser")]
        EnteringCondenser = 1,
        
        [JsonProperty("LeavingCondenser")]
        LeavingCondenser = 2,
    }
}