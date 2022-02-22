namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum RunPeriodControl_SpecialDays_SpecialDayType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay1")]
        CustomDay1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay2")]
        CustomDay2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Holiday")]
        Holiday = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerDesignDay")]
        SummerDesignDay = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterDesignDay")]
        WinterDesignDay = 5,
    }
}