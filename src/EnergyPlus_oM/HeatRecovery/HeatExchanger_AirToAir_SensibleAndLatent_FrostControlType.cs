namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    public enum HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ExhaustAirRecirculation")]
        ExhaustAirRecirculation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ExhaustOnly")]
        ExhaustOnly = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumExhaustTemperature")]
        MinimumExhaustTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
}