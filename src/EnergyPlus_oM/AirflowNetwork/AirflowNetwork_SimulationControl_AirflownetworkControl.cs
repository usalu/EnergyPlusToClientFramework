namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_AirflownetworkControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MultizoneWithDistribution")]
        MultizoneWithDistribution = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MultizoneWithDistributionOnlyDuringFanOperation")]
        MultizoneWithDistributionOnlyDuringFanOperation = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MultizoneWithoutDistribution")]
        MultizoneWithoutDistribution = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="NoMultizoneOrDistribution")]
        NoMultizoneOrDistribution = 4,
    }
}