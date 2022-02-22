namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_CaseDefrostType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Electric")]
        Electric = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ElectricWithTemperatureTermination")]
        ElectricWithTemperatureTermination = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HotFluid")]
        HotFluid = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="HotFluidWithTemperatureTermination")]
        HotFluidWithTemperatureTermination = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="HotGas")]
        HotGas = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="HotGasWithTemperatureTermination")]
        HotGasWithTemperatureTermination = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OffCycle")]
        OffCycle = 8,
    }
}