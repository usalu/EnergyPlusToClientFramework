namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_MeanRadiantTemperatureCalculationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AngleFactor")]
        AngleFactor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceWeighted")]
        SurfaceWeighted = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAveraged")]
        ZoneAveraged = 3,
    }
}