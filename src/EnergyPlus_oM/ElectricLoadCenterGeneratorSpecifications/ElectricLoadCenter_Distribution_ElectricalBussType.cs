namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Distribution_ElectricalBussType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlternatingCurrent")]
        AlternatingCurrent = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AlternatingCurrentWithStorage")]
        AlternatingCurrentWithStorage = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DirectCurrentWithInverter")]
        DirectCurrentWithInverter = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DirectCurrentWithInverterACStorage")]
        DirectCurrentWithInverterACStorage = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="DirectCurrentWithInverterDCStorage")]
        DirectCurrentWithInverterDCStorage = 5,
    }
}