namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_RecurringCosts_Category
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Maintenance")]
        Maintenance = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MajorOverhaul")]
        MajorOverhaul = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MinorOverhaul")]
        MinorOverhaul = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Operation")]
        Operation = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherOperational")]
        OtherOperational = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Repair")]
        Repair = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Replacement")]
        Replacement = 7,
    }
}