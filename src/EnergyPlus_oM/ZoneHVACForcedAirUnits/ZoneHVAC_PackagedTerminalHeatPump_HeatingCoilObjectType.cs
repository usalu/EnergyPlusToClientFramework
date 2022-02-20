using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_PackagedTerminalHeatPump_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 1,
    }
}