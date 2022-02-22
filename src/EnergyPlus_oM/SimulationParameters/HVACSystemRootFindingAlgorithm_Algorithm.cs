namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum HVACSystemRootFindingAlgorithm_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Alternation")]
        Alternation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Bisection")]
        Bisection = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="BisectionThenRegulaFalsi")]
        BisectionThenRegulaFalsi = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="RegulaFalsi")]
        RegulaFalsi = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="RegulaFalsiThenBisection")]
        RegulaFalsiThenBisection = 5,
    }
}