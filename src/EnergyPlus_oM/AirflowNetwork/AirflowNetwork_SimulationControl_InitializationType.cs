namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_InitializationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LinearInitializationMethod")]
        LinearInitializationMethod = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZeroNodePressures")]
        ZeroNodePressures = 2,
    }
}