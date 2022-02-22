namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingPriority")]
        CoolingPriority = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingPriority")]
        HeatingPriority = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LoadPriority")]
        LoadPriority = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ZonePriority")]
        ZonePriority = 4,
    }
}