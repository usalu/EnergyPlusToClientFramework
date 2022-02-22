namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativeCooler:Direct:CelDekPad")]
        EvaporativeCoolerDirectCelDekPad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativeCooler:Direct:ResearchSpecial")]
        EvaporativeCoolerDirectResearchSpecial = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativeCooler:Indirect:CelDekPad")]
        EvaporativeCoolerIndirectCelDekPad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativeCooler:Indirect:ResearchSpecial")]
        EvaporativeCoolerIndirectResearchSpecial = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativeCooler:Indirect:WetCoil")]
        EvaporativeCoolerIndirectWetCoil = 4,
    }
}