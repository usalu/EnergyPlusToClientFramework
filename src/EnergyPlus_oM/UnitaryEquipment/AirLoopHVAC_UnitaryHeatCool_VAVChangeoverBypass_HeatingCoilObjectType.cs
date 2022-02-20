using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 1,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 2,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 3,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 4,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 5,
    }
}