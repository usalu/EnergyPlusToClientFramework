namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_MixedWaterLoop_WaterPumpType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PumpPerTowerOrBoiler")]
        PumpPerTowerOrBoiler = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SinglePump")]
        SinglePump = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
}