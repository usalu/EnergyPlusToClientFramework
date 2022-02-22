namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Water_PerformanceInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NominalCapacity")]
        NominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
}