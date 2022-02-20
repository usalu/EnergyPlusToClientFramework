using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 0,
    }
}