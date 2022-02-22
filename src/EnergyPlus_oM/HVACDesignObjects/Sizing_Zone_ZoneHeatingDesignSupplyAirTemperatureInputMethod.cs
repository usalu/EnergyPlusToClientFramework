namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureDifference")]
        TemperatureDifference = 2,
    }
}