namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustMixingOnly")]
        AdjustMixingOnly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustMixingThenReturn")]
        AdjustMixingThenReturn = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustReturnOnly")]
        AdjustReturnOnly = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustReturnThenMixing")]
        AdjustReturnThenMixing = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
    }
}