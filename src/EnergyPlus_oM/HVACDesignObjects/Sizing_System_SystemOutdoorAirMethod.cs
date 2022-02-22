namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_SystemOutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="VentilationRateProcedure")]
        VentilationRateProcedure = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneSum")]
        ZoneSum = 2,
    }
}