namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum Building_SolarDistribution
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FullExterior")]
        FullExterior = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FullExteriorWithReflections")]
        FullExteriorWithReflections = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FullInteriorAndExterior")]
        FullInteriorAndExterior = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FullInteriorAndExteriorWithReflections")]
        FullInteriorAndExteriorWithReflections = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimalShadowing")]
        MinimalShadowing = 5,
    }
}