namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_ControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Load")]
        Load = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SetPoint")]
        SetPoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleZoneVAV")]
        SingleZoneVAV = 3,
    }
}