using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Chiller_Electric_ReformulatedEIR_ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LeavingCondenserWaterTemperature")]
        LeavingCondenserWaterTemperature = 1,
        
        [JsonProperty("Lift")]
        Lift = 2,
    }
}