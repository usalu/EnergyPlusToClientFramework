using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 1,
        
        [JsonProperty("CoilSystem:IntegratedHeatPump:AirSource")]
        CoilSystemIntegratedHeatPumpAirSource = 2,
    }
}