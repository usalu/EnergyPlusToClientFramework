namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirHeatBalanceAlgorithm_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AnalyticalSolution")]
        AnalyticalSolution = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EulerMethod")]
        EulerMethod = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThirdOrderBackwardDifference")]
        ThirdOrderBackwardDifference = 3,
    }
}