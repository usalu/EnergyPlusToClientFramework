namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Connections_DrainWaterHeatExchangerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CounterFlow")]
        CounterFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossFlow")]
        CrossFlow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Ideal")]
        Ideal = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
}