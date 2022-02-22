namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowShadingControl_TypeOfSlatAngleControlForBlinds
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BlockBeamSolar")]
        BlockBeamSolar = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSlatAngle")]
        FixedSlatAngle = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduledSlatAngle")]
        ScheduledSlatAngle = 3,
    }
}