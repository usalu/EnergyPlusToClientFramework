namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PumpPerChiller")]
        PumpPerChiller = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SinglePump")]
        SinglePump = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
}