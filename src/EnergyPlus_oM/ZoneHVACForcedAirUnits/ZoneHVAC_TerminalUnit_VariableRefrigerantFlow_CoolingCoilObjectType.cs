namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:VariableRefrigerantFlow")]
        CoilCoolingDXVariableRefrigerantFlow = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl")]
        CoilCoolingDXVariableRefrigerantFlowFluidTemperatureControl = 1,
    }
}