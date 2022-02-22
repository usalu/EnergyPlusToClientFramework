namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolReheatDesuperheater")]
        CoolReheatDesuperheater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolReheatHeatingCoil")]
        CoolReheatHeatingCoil = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Multimode")]
        Multimode = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
}