namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="StandardDesignCapacity")]
        StandardDesignCapacity = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UserSpecifiedDesignCapacity")]
        UserSpecifiedDesignCapacity = 2,
    }
}