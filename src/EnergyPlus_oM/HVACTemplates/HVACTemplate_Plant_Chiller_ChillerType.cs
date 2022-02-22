namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Chiller_ChillerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictChilledWater")]
        DistrictChilledWater = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectricCentrifugalChiller")]
        ElectricCentrifugalChiller = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectricReciprocatingChiller")]
        ElectricReciprocatingChiller = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectricScrewChiller")]
        ElectricScrewChiller = 3,
    }
}