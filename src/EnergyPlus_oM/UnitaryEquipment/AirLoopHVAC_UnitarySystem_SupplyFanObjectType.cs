namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_SupplyFanObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:ComponentModel")]
        FanComponentModel = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:ConstantVolume")]
        FanConstantVolume = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:OnOff")]
        FanOnOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:SystemModel")]
        FanSystemModel = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:VariableVolume")]
        FanVariableVolume = 4,
    }
}