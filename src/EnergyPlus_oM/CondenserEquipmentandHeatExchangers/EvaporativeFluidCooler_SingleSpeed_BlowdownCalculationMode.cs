namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConcentrationRatio")]
        ConcentrationRatio = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduledRate")]
        ScheduledRate = 2,
    }
}