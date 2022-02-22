namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_VentilatedSlab_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceTemperature")]
        SurfaceTemperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirDewPointTemperature")]
        ZoneAirDewPointTemperature = 7,
    }
}