namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirMassFlowConservation_InfiltrationBalancingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AddInfiltrationFlow")]
        AddInfiltrationFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustInfiltrationFlow")]
        AdjustInfiltrationFlow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
}