namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_HeatExchangeModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CounterFlow")]
        CounterFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossFlowBothMixed")]
        CrossFlowBothMixed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossFlowBothUnMixed")]
        CrossFlowBothUnMixed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossFlowSupplyMixedDemandUnMixed")]
        CrossFlowSupplyMixedDemandUnMixed = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossFlowSupplyUnMixedDemandMixed")]
        CrossFlowSupplyUnMixedDemandMixed = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Ideal")]
        Ideal = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ParallelFlow")]
        ParallelFlow = 7,
    }
}