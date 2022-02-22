namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_ShadingCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Imported")]
        Imported = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PixelCounting")]
        PixelCounting = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PolygonClipping")]
        PolygonClipping = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 4,
    }
}