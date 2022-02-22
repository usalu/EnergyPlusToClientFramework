namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirMassFlowConservation_InfiltrationBalancingZones
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AllZones")]
        AllZones = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MixingSourceZonesOnly")]
        MixingSourceZonesOnly = 2,
    }
}