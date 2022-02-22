namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_PolygonClippingAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvexWeilerAtherton")]
        ConvexWeilerAtherton = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SlaterBarskyandSutherlandHodgman")]
        SlaterBarskyandSutherlandHodgman = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SutherlandHodgman")]
        SutherlandHodgman = 3,
    }
}