namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum Building_Terrain
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="City")]
        City = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Country")]
        Country = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Ocean")]
        Ocean = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Suburbs")]
        Suburbs = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Urban")]
        Urban = 5,
    }
}