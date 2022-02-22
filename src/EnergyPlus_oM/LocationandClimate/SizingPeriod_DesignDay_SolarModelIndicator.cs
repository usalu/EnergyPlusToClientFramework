namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_SolarModelIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEClearSky")]
        ASHRAEClearSky = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAETau")]
        ASHRAETau = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAETau2017")]
        ASHRAETau2017 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ZhangHuang")]
        ZhangHuang = 5,
    }
}