namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_FourPipeFanCoil_CapacityControlMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAE90VariableFan")]
        ASHRAE90VariableFan = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantFanVariableFlow")]
        ConstantFanVariableFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CyclingFan")]
        CyclingFan = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiSpeedFan")]
        MultiSpeedFan = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableFanConstantFlow")]
        VariableFanConstantFlow = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VariableFanVariableFlow")]
        VariableFanVariableFlow = 5,
    }
}