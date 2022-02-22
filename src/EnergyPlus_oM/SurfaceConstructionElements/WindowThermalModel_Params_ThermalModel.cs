namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowThermalModel_Params_ThermalModel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectiveScalarModel_NoSDThickness")]
        ConvectiveScalarModelNoSDThickness = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectiveScalarModel_withSDThickness")]
        ConvectiveScalarModelWithSDThickness = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099")]
        ISO15099 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ScaledCavityWidth")]
        ScaledCavityWidth = 4,
    }
}