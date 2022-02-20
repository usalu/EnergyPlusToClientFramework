using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum ChillerHeaterPerformance_Electric_EIR_ChilledWaterFlowModeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("VariableFlow")]
        VariableFlow = 2,
    }
}