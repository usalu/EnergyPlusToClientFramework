using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:VariableRefrigerantFlow")]
        CoilCoolingDXVariableRefrigerantFlow = 0,
        
        [JsonProperty("Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl")]
        CoilCoolingDXVariableRefrigerantFlowFluidTemperatureControl = 1,
    }
}