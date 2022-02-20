using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 0,
        
        [JsonProperty("Coil:Heating:Electric:MultiStage")]
        CoilHeatingElectricMultiStage = 1,
        
        [JsonProperty("Coil:Heating:Gas:MultiStage")]
        CoilHeatingGasMultiStage = 2,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 4,
    }
}