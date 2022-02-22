namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HeightAdjust")]
        HeightAdjust = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ParallelComponent")]
        ParallelComponent = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ParallelComponentHeightAdjust")]
        ParallelComponentHeightAdjust = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="WeatherFile")]
        WeatherFile = 4,
    }
}