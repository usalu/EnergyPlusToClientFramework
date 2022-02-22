namespace BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections
{
    public enum ZoneHVAC_EquipmentList_LoadDistributionScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialLoad")]
        SequentialLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialUniformPLR")]
        SequentialUniformPLR = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformLoad")]
        UniformLoad = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformPLR")]
        UniformPLR = 4,
    }
}