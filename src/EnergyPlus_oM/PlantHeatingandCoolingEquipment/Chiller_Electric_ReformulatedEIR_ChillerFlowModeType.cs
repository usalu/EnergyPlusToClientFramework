using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Chiller_Electric_ReformulatedEIR_ChillerFlowModeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("LeavingSetpointModulated")]
        LeavingSetpointModulated = 2,
        
        [JsonProperty("NotModulated")]
        NotModulated = 3,
    }
}