namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Steam_CoilControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureSetpointControl")]
        TemperatureSetpointControl = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneLoadControl")]
        ZoneLoadControl = 1,
    }
}