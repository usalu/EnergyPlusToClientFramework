using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:VariableRefrigerantFlow")]
        CoilHeatingDXVariableRefrigerantFlow = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl")]
        CoilHeatingDXVariableRefrigerantFlowFluidTemperatureControl = 1,
    }
}