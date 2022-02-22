namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Tariff_DemandWindowLength
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Day")]
        Day = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FullHour")]
        FullHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HalfHour")]
        HalfHour = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="QuarterHour")]
        QuarterHour = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Week")]
        Week = 4,
    }
}