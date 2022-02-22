namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowThermalModel_Params_DeflectionModel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeasuredDeflection")]
        MeasuredDeflection = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NoDeflection")]
        NoDeflection = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureAndPressureInput")]
        TemperatureAndPressureInput = 3,
    }
}