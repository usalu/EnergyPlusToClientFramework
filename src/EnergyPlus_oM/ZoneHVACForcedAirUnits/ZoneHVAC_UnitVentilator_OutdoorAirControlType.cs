namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitVentilator_OutdoorAirControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FixedAmount")]
        FixedAmount = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedTemperature")]
        FixedTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="VariablePercent")]
        VariablePercent = 2,
    }
}