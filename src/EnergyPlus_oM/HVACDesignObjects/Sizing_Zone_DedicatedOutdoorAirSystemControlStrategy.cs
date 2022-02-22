namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ColdSupplyAir")]
        ColdSupplyAir = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NeutralDehumidifiedSupplyAir")]
        NeutralDehumidifiedSupplyAir = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NeutralSupplyAir")]
        NeutralSupplyAir = 3,
    }
}