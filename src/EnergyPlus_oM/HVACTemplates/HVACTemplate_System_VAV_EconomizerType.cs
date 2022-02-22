namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_VAV_EconomizerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedDryBulb")]
        FixedDryBulb = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="NoEconomizer")]
        NoEconomizer = 8,
    }
}