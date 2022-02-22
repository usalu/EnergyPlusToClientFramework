namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantSupplyHumidityRatio")]
        ConstantSupplyHumidityRatio = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Humidistat")]
        Humidistat = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
}