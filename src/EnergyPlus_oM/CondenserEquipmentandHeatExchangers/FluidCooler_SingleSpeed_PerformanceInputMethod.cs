namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum FluidCooler_SingleSpeed_PerformanceInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NominalCapacity")]
        NominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
}