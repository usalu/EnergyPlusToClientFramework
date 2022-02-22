namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_IdealLoadsAirSystem_OutdoorAirEconomizerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialEnthalpy")]
        DifferentialEnthalpy = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NoEconomizer")]
        NoEconomizer = 3,
    }
}