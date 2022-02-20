using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Boiler_HotWater_EfficiencyCurveTemperatureEvaluationVariable
    {
        
        [JsonProperty("EnteringBoiler")]
        EnteringBoiler = 0,
        
        [JsonProperty("LeavingBoiler")]
        LeavingBoiler = 1,
    }
}