namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:VariableRefrigerantFlow")]
        CoilHeatingDXVariableRefrigerantFlow = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl")]
        CoilHeatingDXVariableRefrigerantFlowFluidTemperatureControl = 1,
    }
}