namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_Unitary_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureDifference")]
        TemperatureDifference = 3,
    }
}