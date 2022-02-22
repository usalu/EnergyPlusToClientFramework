namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Plant_CoincidentSizingFactorMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="GlobalCoolingSizingFactor")]
        GlobalCoolingSizingFactor = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="GlobalHeatingSizingFactor")]
        GlobalHeatingSizingFactor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LoopComponentSizingFactor")]
        LoopComponentSizingFactor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
}