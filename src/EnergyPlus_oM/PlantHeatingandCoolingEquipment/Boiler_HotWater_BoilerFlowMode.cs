using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Boiler_HotWater_BoilerFlowMode
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