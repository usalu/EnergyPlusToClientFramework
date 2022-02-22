namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_FanCoil_CoolingCoilType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ChilledWater")]
        ChilledWater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
    }
}